using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStorePOS
{
    internal class OrdersDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;database=liquordb;";

        public List<Orders> getAllOrders()
        {
            List<Orders> allOrders = new List<Orders>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * FROM ORDERS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Orders orders = new Orders
                    {
                        row_id = reader.GetInt32(0),
                        order_id = reader.GetString(1),
                        date_created = reader.GetDateTime(2),
                        quantity = reader.GetInt32(3),
                        item_id = reader.GetInt32(4)
                    };

                    allOrders.Add(orders);

                }
            }

            connection.Close();
            return allOrders;  

        }

        public List<int> getAllitems()
        {
            List<int> allOrdItems = new List<int>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select item_id FROM ORDERS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    allOrdItems.Add(reader.GetInt32(0));

                }
            }

            connection.Close();
            return allOrdItems;

        }

    }
}
