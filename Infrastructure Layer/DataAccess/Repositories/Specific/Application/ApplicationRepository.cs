using Common_Components;
using Domain_Layer.Models.Application;
using Domain_Layer.Models.Country;
using Domain_Layer.Models.User;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.DataAccess.Repositories.Specific.Application
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly string _connectionString;

        public ApplicationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<ApplicationTypeModel>> GetApplicationTypes()
        {
            var ApplicationTypes = new List<ApplicationTypeModel>();

            try
            {
                string query = "SELECT * FROM ApplicationTypes";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                await conn.OpenAsync();
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    ApplicationTypes.Add(MapApplicationType(reader));
                }
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetApplicationTypes: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving Applications data", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetApplicationTypes: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return ApplicationTypes;

        }
        public async Task<ApplicationTypeModel?> GetApplicationType(int id)
        {
            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID=@ApplicationTypeID";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", id);
            try
            {
                await conn.OpenAsync();
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync()) { return MapApplicationType(reader); }

                return null;
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetApplicationType: {sqlEx.Message}");
                throw new DataAccessException($"Error retrieving ApplicationType with ID {id}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetApplicationType: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

        }

        public async Task<bool> UpdateApplicationType(ApplicationTypeModel? ApplicationType)
        {
            if (ApplicationType is null)
                throw new ArgumentNullException(nameof(ApplicationType));

            try
            {
                string query = @"UPDATE ApplicationTypes SET 
                        ApplicationTypeName = @ApplicationTypeName, ApplicationFees = @ApplicationFees
                        WHERE ApplicationTypeID = @ApplicationTypeID";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(GetUpdateParameters(ApplicationType));

                await conn.OpenAsync();
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in UpdateApplicationType: {sqlEx.Message}");
                throw new DataAccessException($"Error updating ApplicationType with ID {ApplicationType.Id}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in UpdateApplicationType: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }
        }
        private SqlParameter[] GetUpdateParameters(ApplicationTypeModel ApplicationType) => new SqlParameter[]
    {
        new("@ApplicationTypeID", ApplicationType.Id),
        new("@ApplicationTypeName", ApplicationType.Name),
        new("@ApplicationFees", ApplicationType.Fees)
    };

        private ApplicationTypeModel MapApplicationType(SqlDataReader reader)
        {
            return new ApplicationTypeModel
            {
                Id = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")),
                Name = reader.GetString(reader.GetOrdinal("ApplicationTypeName")),
                Fees =Convert.ToInt32( reader.GetDecimal(reader.GetOrdinal("ApplicationFees")) )
            };
        }

    }
}
