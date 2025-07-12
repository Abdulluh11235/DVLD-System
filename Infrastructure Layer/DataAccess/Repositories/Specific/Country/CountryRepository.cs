using Common_Components;
using Domain_Layer;
using Domain_Layer.Models.Country;
using Microsoft.Data.SqlClient;
using Service_Layer.Interfaces.Country;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.DataAccess.Repositories.Specific.Country
{
    public class CountryRepository :ICountryRepository
    {
        private string _connectionString { get; set; }


        public CountryRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }
        public CountryModel? GetCountryById(int id)
        {
            string query = "SELECT * FROM Countries WHERE CountryID=@CountryID";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryID", id);
            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return MapCountry(reader); }

                return null;
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetCountryById: {sqlEx.Message}");
                throw new DataAccessException($"Error retrieving Country with ID {id}", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetCountryById: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

        }
        public  async Task< IEnumerable<CountryModel> >GetAllCountries()
        {
            var countries = new List<CountryModel>();

            try
            {
                string query = "SELECT * FROM Countries";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);

                await conn.OpenAsync();
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    countries.Add(MapCountry(reader));
                }
            }
            catch (SqlException sqlEx)
            {
                Debug.WriteLine($"SQL Error in GetAllCountries: {sqlEx.Message}");
                throw new DataAccessException("Error retrieving Countries data", sqlEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetAllCountries: {ex.Message}");
                throw new DataAccessException("An unexpected error occurred", ex);
            }

            return countries;
        }

        private CountryModel MapCountry(SqlDataReader reader)
        {
            return new CountryModel
            {
                Id = reader.GetInt32(reader.GetOrdinal("CountryID")),
                Name = reader.GetString(reader.GetOrdinal("CountryName"))

            };
        }

    }
}
