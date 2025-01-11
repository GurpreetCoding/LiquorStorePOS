using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStorePOS
{
    internal class SizeDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;database=liquordb;";

        public List<Size> getAllItems()
        {
            List<Size> allSizes = new List<Size>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * FROM Size", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Size s = new Size
                    {
                        size_id= reader.GetInt32(0),
                        size_name = reader.GetString(1)

                    };

                    allSizes.Add(s);

                }
            }

            connection.Close();
            return allSizes;

        }

        public String getSizeName(int size_id)
        {
            String sizeName = "";

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select size_name FROM Size WHERE size_id = @size_id", connection);

            command.Parameters.AddWithValue("@size_id", size_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    sizeName = reader.GetString(0);

                }
            }

            connection.Close();
            return sizeName;
        }

        public int getID(string size_name)
        {
            int sizeID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select size_id FROM Size WHERE size_name = @size_name", connection);

            command.Parameters.AddWithValue("@size_name", size_name);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    sizeID = reader.GetInt32(0);

                }
            }

            connection.Close();
            return sizeID;
        }

        public int insertSize(string size_name)
        {
            MessageBox.Show("hi" + " " + size_name +  " ");
            try
            {
                /* insert order information into database */

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO `size`(`size_name`) " +
                    "VALUES (@size_name)", connection);

                command.Parameters.AddWithValue("@size_name", size_name);


                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return -1;
            }


        }
    }
}
