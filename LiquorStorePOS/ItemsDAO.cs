using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LiquorStorePOS
{
    internal class ItemsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;database=liquordb;";

        public int getItemID(string itemSKU)
        {
            int itemID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select item_id FROM ITEM WHERE item_sku = @item_sku", connection);

            command.Parameters.AddWithValue("@item_sku", itemSKU);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemID = reader.GetInt32(0);

                }
            }

            connection.Close();

            return itemID;
        }


        public double getItemCost(int item_id)
        {
            double itemsCost = 0.0;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select item_cost FROM ITEM WHERE item_id = @item_id", connection);

            command.Parameters.AddWithValue("@item_id", item_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemsCost = reader.GetDouble(0);

                }
            }

            connection.Close();
            return itemsCost;

        }
    

        public double getItemPrice(int item_id)
        {
            double itemsPrice = 0.00;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select item_price FROM ITEM WHERE item_id = @item_id", connection);

            command.Parameters.AddWithValue("@item_id", item_id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemsPrice = reader.GetDouble(0);

                }
            }

            connection.Close();
            return itemsPrice;
        }

        public List<Item> getAllItems()
        {
            List<Item> allItems = new List<Item>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * FROM ITEM", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Item i = new Item
                    {
                        item_id = reader.GetInt32(0),
                        item_sku = reader.GetString(1),
                        item_name = reader.GetString(2),
                        cat_id = reader.GetInt32(3),
                        item_price= reader.GetDouble(4),
                        item_cost= reader.GetDouble(5),
                        size_id= reader.GetInt32(6)
                      
                    };

                    allItems.Add(i);

                }
            }

            connection.Close();
            return allItems;

        }

        internal Item getItemBySKU(string sKU)
        {
            Item theItem = null;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("Select * FROM ITEM WHERE item_sku = @sku", connection);

            command.Parameters.AddWithValue("@sku", sKU);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if(reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Item i = new Item
                        {
                            item_id = reader.GetInt32(0),
                            item_sku = reader.GetString(1),
                            item_name = reader.GetString(2),
                            cat_id = reader.GetInt32(3),
                            item_price = reader.GetDouble(4),
                            item_cost = reader.GetDouble(5),
                            size_id = reader.GetInt32(6)

                        };

                        theItem = i;

                    }
                }
                
            }

            connection.Close();
            return theItem;

        }

        public int insertItem(string item_sku, string item_name, int cat_id, double item_price, double item_cost, int size_id)
        {
            MessageBox.Show("hi" + " " + item_sku + " " + item_name + " " + cat_id + " " + item_price + " " + item_cost + " " + size_id);
            try
            {
                /* insert order information into database */

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO `item`(`item_sku`, `item_name`, `cat_id`, `item_price`, `item_cost`, `size_id`) " +
                    "VALUES (@item_sku, @item_name, @cat_id ,@item_price, @item_cost, @size_id)", connection);

                command.Parameters.AddWithValue("@item_sku", item_sku);
                command.Parameters.AddWithValue("@item_name", item_name);
                command.Parameters.AddWithValue("@cat_id", cat_id);
                command.Parameters.AddWithValue("@item_price", item_price);
                command.Parameters.AddWithValue("@item_cost", item_cost);
                command.Parameters.AddWithValue("@size_id", size_id);




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
