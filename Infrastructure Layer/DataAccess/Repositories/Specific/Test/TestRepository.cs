using Common_Components;
using Domain_Layer.Models.Application;
using Domain_Layer.Models.Test;
using Microsoft.Data.SqlClient;
using Service_Layer.Interfaces.Test;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.DataAccess.Repositories.Specific.Test;

public class TestRepository : ITestRepository
{
    private readonly string _connectionString;

    public TestRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<TestTypeModel>> GetTestTypes()
    {
        var testTypes = new List<TestTypeModel>();

        try
        {
            string query = "SELECT * FROM TestTypes";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);

            await conn.OpenAsync();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                testTypes.Add(MapTestType(reader));
            }
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in GetTestTypes: {sqlEx.Message}");
            throw new DataAccessException("Error retrieving test data", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in GetTestTypes: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }

        return testTypes;

    }
    public async Task<TestTypeModel?> GetTestType(int id)
    {
        string query = "SELECT * FROM TestTypes WHERE TestTypeID=@TestTypeID";
        using SqlConnection conn = new SqlConnection(_connectionString);
        using SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@TestTypeID", id);
        try
        {
            await conn.OpenAsync();
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync()) { return MapTestType(reader); }

            return null;
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in GetTestType: {sqlEx.Message}");
            throw new DataAccessException($"Error retrieving TestType with ID {id}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in GetTestType: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }

    }

    public async Task<bool> UpdateTestType(TestTypeModel? testType)
    {
        if (testType is null)
            throw new ArgumentNullException(nameof(testType));

        try
        {
            string query = @"UPDATE TestTypes SET 
                        TestTypeName = @TestTypeName,TestTypeDescription=@TestTypeDescription
                        ,TestTypeFees = @TestTypeFees
                        WHERE TestTypeID = @TestTypeID";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(GetUpdateParameters(testType));

            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync() > 0;
        }
        catch (SqlException sqlEx)
        {
            Debug.WriteLine($"SQL Error in UpdateTestType: {sqlEx.Message}");
            throw new DataAccessException($"Error updating TestType with ID {testType.Id}", sqlEx);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error in UpdateTestType: {ex.Message}");
            throw new DataAccessException("An unexpected error occurred", ex);
        }
    }
    private SqlParameter[] GetUpdateParameters(TestTypeModel testType) => new SqlParameter[]
{
    new("@TestTypeID", testType.Id),
    new("@TestTypeName", testType.Name),
    new("TestTypeDescription",testType.Description),
    new("@TestTypeFees", testType.Fees)
};

    private TestTypeModel MapTestType(SqlDataReader reader)
    {
        return new TestTypeModel
        {
            Id = reader.GetInt32(reader.GetOrdinal("TestTypeID")),
            Name = reader.GetString(reader.GetOrdinal("TestTypeName")),
            Description = reader.GetString(reader.GetOrdinal("TestTypeDescription")),
            Fees = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("TestTypeFees")))
        };
    }
}
