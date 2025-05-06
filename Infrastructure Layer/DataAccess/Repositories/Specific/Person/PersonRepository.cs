using Common_Components;
using Domain_Layer;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Country;
using Microsoft.Data.SqlClient;
using Service_Layer.Interfaces.Country;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure_Layer.DataAccess.Repositories.Specific.Person
{
    public class PersonRepository : IPersonRepository
    // Result Pattern stead of return bool in Operations delete,updtae
    {
        private readonly string _connectionString;
        private readonly ICountryRepository _countryRepository;

        public PersonRepository(string connectionString, ICountryRepository countryRepository)
        {
            _connectionString = connectionString;
            _countryRepository = countryRepository;
        }
         
 
        public IEnumerable<IPersonModel> GetAllPeople()
        {
            var people = new List<IPersonModel>();

            try
            {
                string query = "SELECT * FROM People";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader(); 
                while(reader.Read()) people.Add(MapPerson(reader));      
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetAllPeople: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving people data", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetAllPeople: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return people;
        }


        public IPersonModel? GetPersonById(int id)
        {
            try
            {
                string query = "SELECT * FROM People WHERE PersonID = @PersonID";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", id);

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return MapPerson(reader);
                }

                return null;
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetPersonById: {sqlEx.Message}");
                throw new DataAccessException($"Error retrieving person with ID {id}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetPersonById: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }
        }

        public int? AddPerson(IPersonModel person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            try
            {
                string query = @"INSERT INTO People 
                    (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath) 
                    VALUES 
                    (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                    SELECT SCOPE_IDENTITY();";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(GetAddParameters(person));

                conn.Open();
                object? result = cmd.ExecuteScalar();

                if (result != null)
                {
                    person.PersonID = Convert.ToInt32(result);
                    return person.PersonID;
                }

                return null;
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627) // Unique constraint violation
            {
                Debug.WriteLine($"Duplicate entry in AddPerson: {sqlEx.Message}");
                throw new DataAccessException("A person with these details already exists", sqlEx);
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in AddPerson: {sqlEx.Message}");
                throw new DataAccessException("Error adding new person", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in AddPerson: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }
        }

        public bool UpdatePerson(IPersonModel person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            try
            {
                string query = @"UPDATE People SET 
                    NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, 
                    LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, 
                    Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath 
                    WHERE PersonID = @PersonID";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(GetUpdateParameters(person));

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in UpdatePerson: {sqlEx.Message}");
                throw new DataAccessException($"Error updating person with ID {person.PersonID}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in UpdatePerson: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }
        }

        public bool DeletePerson(int id)
        {
            try
            {
                string query = "DELETE FROM People WHERE PersonID = @PersonID";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 547) // Foreign key constraint
            {
                Debug.WriteLine($"Constraint violation in DeletePerson: {sqlEx.Message}");
                throw new DataAccessException("Cannot delete person because related records exist", sqlEx);
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in DeletePerson: {sqlEx.Message}");
                throw new DataAccessException($"Error deleting person with ID {id}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in DeletePerson: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }
        }

        private IPersonModel MapPerson(SqlDataReader reader)
        {
            return new PersonModel
            {
                PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                NationalNo = reader.GetString(reader.GetOrdinal("NationalNo")),
                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                SecondName = reader.GetString(reader.GetOrdinal("SecondName")),
                ThirdName = reader["ThirdName"] as string,
                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                Gender = Convert.ToBoolean(reader.GetOrdinal("Gender")),
                Address = reader.GetString(reader.GetOrdinal("Address")),
                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                Email = reader["Email"] as string,
                Country = _countryRepository.GetCountryById(reader.GetInt32(reader.GetOrdinal("NationalityCountryID")))!,
                ImagePath = reader["ImagePath"] as string
            };
        }

        private SqlParameter[] GetAddParameters(IPersonModel person) => new SqlParameter[]
        {
        new("@NationalNo", person.NationalNo),
        new("@FirstName", person.FirstName),
        new("@SecondName", person.SecondName),
        new("@ThirdName", (object?)person.ThirdName ?? DBNull.Value),
        new("@LastName", person.LastName),
        new("@DateOfBirth", person.DateOfBirth),
        new("@Gender", person.Gender),
        new("@Address", person.Address),
        new("@Phone", person.Phone),
        new("@Email", (object?)person.Email ?? DBNull.Value),
        new("@NationalityCountryID", person.Country.Id),
        new("@ImagePath", (object?)person.ImagePath ?? DBNull.Value)
        };

        private SqlParameter[] GetUpdateParameters(IPersonModel person)
        {
            var baseParams = GetAddParameters(person).ToList();
            baseParams.Insert(0, new SqlParameter("@PersonID", person.PersonID));
            return baseParams.ToArray();
        }

        public IEnumerable<IPersonModel> GetByFirstName(string firstName)
        {
            var people = new List<IPersonModel>();

            try
            {
                string query = @"SELECT * FROM People 
                         WHERE FirstName LIKE @FirstName";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FirstName",firstName+"%");

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    people.Add(MapPerson(reader));
                }
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetByFirstName: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving people data by first name", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetByFirstName: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return people;
        }

        public IEnumerable<IPersonModel> GetByLastName(string lastName)
        {
            var people = new List<IPersonModel>();

            try
            {
                string query = @"SELECT * FROM People 
                         WHERE LastName LIKE @LastName";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@LastName",lastName+"%");

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    people.Add(MapPerson(reader));
                }
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetByLastName: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving people data by last name", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetByLastName: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return people;
        }

        public IEnumerable<IPersonModel> GetByNationalNo(string nationalNo)
        {
            var people = new List<IPersonModel>();

            try
            {
                string query = @"SELECT * FROM People 
                 WHERE NationalNo LIKE @NationalNo";



                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NationalNo", nationalNo + "%");

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    people.Add(MapPerson(reader));
                }
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetByNationalNo: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving people data by national number", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetByNationalNo: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return people;
        }

    }
}










