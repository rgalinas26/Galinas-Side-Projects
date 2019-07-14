using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PhotoWebsite.Models;

namespace PhotoWebsite.DAL
{
    public class PhotoSQLDAO : IPhotoDAO
    {
        //A connection string for the DAO
        private string connectionString;
        //Creates a new SQL DAO to retrieve photo info from DB.
        public PhotoSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Gets all photo information from the DB.
        public IList<Photo> GetAllPhotos()
        {
            List<Photo> products = new List<Photo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM photos", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        products.Add(MapRowToProduct(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"Exception occurred reading product data - ${ex}");
                throw;
            }

            return products;
        }
        //Gets a specific photo based on ID after the user selects a specific photo
        public Photo GetPhotoById(int id)
        {
            Photo photo = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM photos WHERE id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        photo = MapRowToProduct(reader);
                    }

                    return photo;
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"An error occurred reading product {id} - ${ex}");
                throw;
            }
        }
        //Maps the database columns to a C# object
        private Photo MapRowToProduct(SqlDataReader reader)
        {
            Photo photo = new Photo();
            photo.Id = Convert.ToInt32(reader["id"]);
            photo.Name = Convert.ToString(reader["name"]);
            photo.ImageName = Convert.ToString(reader["image_name"]);
            photo.Description = Convert.ToString(reader["description"]);
            photo.IsBird = Convert.ToBoolean(reader["isBird"]);
            photo.IsCVNP = Convert.ToBoolean(reader["isCVNP"]);
            photo.IsPlant = Convert.ToBoolean(reader["isFlower"]);
            return photo;
        }



    }
}
