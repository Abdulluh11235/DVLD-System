using Common_Components;
using Domain_Layer.Models.User;
using Microsoft.Data.SqlClient;
using Service_Layer.Interfaces.Person;
using Service_Layer.Interfaces.User;

using System.Diagnostics;


namespace Infrastructure_Layer.DataAccess.Repositories.Specific.User;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;
    private readonly IPersonRepository _personRepository;

    public UserRepository(string connectionString, IPersonRepository personRepository)
    {
        _connectionString = connectionString;
        _personRepository = personRepository;
    }

    public async Task<IEnumerable<UserModel>>GetAllUsers()
    {
        var users = new List<UserModel>();

        try
        {
            string query = "SELECT * FROM Users";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync()) users.Add(MapUser(reader));
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in GetAllUsers: {sqlEx.Message}");
            throw new DataAccessException("Error retrieving Users data", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in GetAllUsers: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }

        return users;
    }

    public UserModel? GetUserById(int id)
    {
        try
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", id);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return MapUser(reader);
            }

            return null;
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in GetUserById: {sqlEx.Message}");
            throw new DataAccessException($"Error retrieving user with ID {id}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in GetUserById: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }
    public UserModel? GetUserByUserName(string username)
    {
        try
        {
            string query = "SELECT * FROM Users WHERE UserName = @UserName";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", username);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return MapUser(reader);
            }

            return null;
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in UserName: {sqlEx.Message}");
            throw new DataAccessException($"Error retrieving user with username {username}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in UserName: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }


    public int? AddUser(UserModel user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        try
        {
            string query = @"INSERT INTO Users 
                        (UserName, PersonID, Password, IsActive) 
                        VALUES 
                        (@UserName, @PersonID, @Password, @IsActive);
                        SELECT SCOPE_IDENTITY();";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(GetAddParameters(user));

            conn.Open();
            object? result = cmd.ExecuteScalar();

            if (result != null)
            {
                user.UserID = Convert.ToInt32(result);
                return user.UserID;
            }

            return null;
        }
        catch (SqlException sqlEx) when (sqlEx.Number == 2627) // Unique constraint violation
        {
            Debug.WriteLine($"Duplicate entry in AddUser: {sqlEx.Message}");
            throw new DataAccessException("A User with these details already exists", sqlEx);
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in AddUser: {sqlEx.Message}");
            throw new DataAccessException("Error adding new user", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in AddUser: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }

    public bool UpdateUser(UserModel user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        try
        {
            string query = @"UPDATE Users SET 
                        UserName = @UserName, PersonID = @PersonID, Password = @Password, IsActive = @IsActive
                        WHERE UserID = @UserID";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(GetUpdateParameters(user));

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in UpdateUser: {sqlEx.Message}");
            throw new DataAccessException($"Error updating user with ID {user.UserID}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in UpdateUser: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }

    public bool DeleteUser(int id)
    {
        try
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        catch (SqlException sqlEx) when (sqlEx.Number == 547)
        {
            Debug.WriteLine($"Constraint violation in DeleteUser: {sqlEx.Message}");
            throw new DataAccessException("Cannot delete user because related records exist", sqlEx);
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in DeleteUser: {sqlEx.Message}");
            throw new DataAccessException($"Error deleting user with ID {id}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in DeleteUser: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }

    private UserModel MapUser(SqlDataReader reader)
    {
        return new UserModel
        {
            Person = _personRepository.GetPersonById(reader.GetInt32(reader.GetOrdinal("PersonID")))!,
            HashedPassword = reader.GetString(reader.GetOrdinal("Password")),
            Active = reader.GetBoolean(reader.GetOrdinal("IsActive")),
            UserName = reader.GetString(reader.GetOrdinal("UserName")),
            UserID = reader.GetInt32(reader.GetOrdinal("UserID"))
        };
    }

    private SqlParameter[] GetAddParameters(UserModel user) => new SqlParameter[]
    {
        new("@UserName", user.UserName),
        new("@PersonID", user.PersonId),
        new("@Password", user.HashedPassword),
        new("@IsActive", user.Active)
    };

    private SqlParameter[] GetUpdateParameters(UserModel user)
    {
        var baseParams = GetAddParameters(user).ToList();
        baseParams.Insert(0, new SqlParameter("@UserID", user.UserID));
        return baseParams.ToArray();
    }

    public async Task<IEnumerable<UserModel>> GetUsersByUserName(string userName)
    {
        var users = new List<UserModel>();

        try
        {
            string query = @"SELECT * FROM Users 
                             WHERE UserName LIKE @UserName";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserName", userName + "%");

            conn.Open();

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                users.Add(MapUser(reader));
            }
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in GetByUserName: {sqlEx.Message}");
            throw new DataAccessException("Error retrieving users by username", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in GetByUserName: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }

        return users;
    }
    public async Task<IEnumerable<UserModel>> GetByIsActive(bool isActive)
    {
        var users = new List<UserModel>();
        try
        {
            string query = "SELECT * FROM Users WHERE IsActive = @IsActive";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
            conn.Open();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync()) users.Add(MapUser(reader));
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine(sqlEx, "SQL Error in GetByIsActive");
            throw new DataAccessException("Error retrieving users by active status", sqlEx);
        }
        return users;
    }
}