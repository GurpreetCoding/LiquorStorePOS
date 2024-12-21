using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStorePOS
{
    internal class CategoryDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;database=liquordb;";

        public List<Category> getAllItems()
        {
            List<Category> allCats = new List<Category>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * FROM Category", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Category c = new Category
                    {
                        cat_id = reader.GetInt32(0),
                        cat_name= reader.GetString(1),
                        cat_tax = reader.GetDouble(2)

                    };

                    allCats.Add(c);

                }
            }

            connection.Close();
            return allCats;

        }

        public double GetTax(int id)
        {
            double taxPercent = 0.00;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select cat_tax FROM Category WHERE cat_id = @cat_id", connection);

            command.Parameters.AddWithValue("@cat_id", id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    taxPercent = reader.GetDouble(0);

                }
            }

            connection.Close();
            return taxPercent;
        }
    }
}
