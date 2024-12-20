
namespace LiquorStorePOS
{
    public partial class Form1 : Form
    {
        BindingSource ordersBindingSource = new BindingSource();
        BindingSource itemsBindingSource = new BindingSource();
        BindingSource categoryBindingSource = new BindingSource();
        BindingSource sizeBindingSource = new BindingSource();

        List<Orders> ords = new List<Orders>();
        List<Item> itms = new List<Item>();
        List<Category> categories = new List<Category>();  
        List<Size> sizes = new List<Size>();


        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //This button loads the orders table
            OrdersDAO ordersDAO = new OrdersDAO();

            ords = ordersDAO.getAllOrders();

            ordersBindingSource.DataSource= ords;

            dataGridView1.DataSource = ordersBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            ItemsDAO itemsDAO = new ItemsDAO();

            itms = itemsDAO.getAllItems();

            itemsBindingSource.DataSource = itms;

            dataGridView2.DataSource = itemsBindingSource;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrdersDAO ordersDAO = new OrdersDAO();

            List<int> ordsItems = new List<int>();


            //gets item primary keys {2,2,3}
            ordsItems = ordersDAO.getAllitems();

            foreach(int item in ordsItems)
            {
                //MessageBox.Show(item.ToString());
            }

            List<double> itemstotprice = new List<double>();
            List<double> itemstotcost = new List<double>();

            ItemsDAO itemsDAO = new ItemsDAO();

            foreach(int i in ordsItems)
            {
                //MessageBox.Show(i.ToString());  
                itemstotprice.Add(itemsDAO.getItemPrice(i) );
                itemstotcost.Add(itemsDAO.getItemCost(i)) ;
            }

            foreach(double d in itemstotcost)
            {
                //MessageBox.Show(d.ToString());
            }

            double marginPercent = (1 - (itemstotcost.Sum() / itemstotprice.Sum())) * 100 ;



            MessageBox.Show (marginPercent.ToString()); 
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            CategoryDAO categoryDAO = new CategoryDAO();

            categories = categoryDAO.getAllItems();

            categoryBindingSource.DataSource = categories;

            dataGridView3.DataSource = categoryBindingSource;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            SizeDAO sizeDAO = new SizeDAO();

            sizes = sizeDAO.getAllItems();

            sizeBindingSource.DataSource = sizes;

            dataGridView4.DataSource = sizeBindingSource;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled= true;
                //listBox1.Items.Add(textBox1.Text);
                //textBox1.Clear();

                String SKU = textBox1.Text;

                ItemsDAO itemsDAO = new ItemsDAO();

                Item theItem = itemsDAO.getItemBySKU(SKU);

                listBox1.Items.Add(theItem.item_name.ToString());

                //double itemPrice = theItem.item_price;

                //string formatPrice = itemPrice.ToString("F2");
                
                listBox2.Items.Add(theItem.item_price.ToString("F2"));

                textBox1.Clear();

                //adding the total price of items into label1

                //MessageBox.Show(listBox2.Items[0].ToString());

                double orderTotal = 0;

                for(int x = 0; x < listBox2.Items.Count; x++)
                {
                    orderTotal += Convert.ToDouble(listBox2.Items[x].ToString());
                }

                //MessageBox.Show(orderTotal.ToString());

                label1.Text = orderTotal.ToString("F2");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this button deletes an item
            int index = listBox1.SelectedIndex;
            int index2 = listBox2.SelectedIndex;
            if (index == index2)
            {
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);

                double orderTotal = 0;

                for (int x = 0; x < listBox2.Items.Count; x++)
                {
                    orderTotal += Convert.ToDouble(listBox2.Items[x].ToString());
                }

                //MessageBox.Show(orderTotal.ToString());

                label1.Text = orderTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Must select the same row for name and price to delete");
            }
            
        }
    }
}