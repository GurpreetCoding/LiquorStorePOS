
using System.Linq.Expressions;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
        double orderSubtotal;
        double orderTax;
        public Form1()
        {
            InitializeComponent();

            panel5.Hide();

            textBox1.KeyPress += textBox1_KeyPress;
            button1.Click += button1_Click;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //This button loads the orders table
            OrdersDAO ordersDAO = new OrdersDAO();

            ords = ordersDAO.getAllOrders();

            ordersBindingSource.DataSource = ords;

            //dataGridView1.DataSource = ordersBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            ItemsDAO itemsDAO = new ItemsDAO();

            itms = itemsDAO.getAllItems();

            itemsBindingSource.DataSource = itms;

            //dataGridView2.DataSource = itemsBindingSource;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrdersDAO ordersDAO = new OrdersDAO();

            List<int> ordsItems = new List<int>();


            //gets item primary keys {2,2,3}
            ordsItems = ordersDAO.getAllitems();

            foreach (int item in ordsItems)
            {
                //MessageBox.Show(item.ToString());
            }

            List<double> itemstotprice = new List<double>();
            List<double> itemstotcost = new List<double>();

            ItemsDAO itemsDAO = new ItemsDAO();

            foreach (int i in ordsItems)
            {
                //MessageBox.Show(i.ToString());  
                itemstotprice.Add(itemsDAO.getItemPrice(i));
                itemstotcost.Add(itemsDAO.getItemCost(i));
            }

            foreach (double d in itemstotcost)
            {
                //MessageBox.Show(d.ToString());
            }

            double marginPercent = (1 - (itemstotcost.Sum() / itemstotprice.Sum())) * 100;



            MessageBox.Show(marginPercent.ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            CategoryDAO categoryDAO = new CategoryDAO();

            categories = categoryDAO.getAllItems();

            categoryBindingSource.DataSource = categories;

            //dataGridView3.DataSource = categoryBindingSource;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this button loads the items table
            SizeDAO sizeDAO = new SizeDAO();

            sizes = sizeDAO.getAllItems();

            sizeBindingSource.DataSource = sizes;

            //dataGridView4.DataSource = sizeBindingSource;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
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
            */

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //listBox1.Items.Add(textBox1.Text);
                //textBox1.Clear();

                //This line gets the SKU from the textbox
                String SKU = textBox1.Text;

                //This line creates the items/sizes Database access object 
                ItemsDAO itemsDAO = new ItemsDAO();
                SizeDAO sizeDAO = new SizeDAO();
                CategoryDAO catDAO = new CategoryDAO();
                //This line gets the item associated with the SKU
                Item theItem = itemsDAO.getItemBySKU(SKU);

                //listBox1.Items.Add(theItem.item_name.ToString());

                Panel p = new Panel();
                p.Name = "Item Panel";
                p.Size = new System.Drawing.Size(475, 100);
                p.BackColor = System.Drawing.Color.Lavender;

                Label UPC = new Label();
                Label Name = new Label();
                Label Price = new Label();
                Label Tax = new Label();
                Label Size = new Label();
                Label TotalPrice = new Label();
                Button Remove = new Button();
                Remove.Click += Remove_Click;
                Remove.Size = new System.Drawing.Size(50, 25);

                UPC.Location = new Point(10, 10);
                Name.Location = new Point(10, 50);
                Size.Location = new Point(300, 50);
                Price.Location = new Point(10, 70);
                Tax.Location = new Point(200, 70);
                Remove.Location = new Point(400, 10);
                TotalPrice.Location = new Point(400, 70);

                UPC.Text = theItem.item_sku.ToString();
                UPC.Name = "UPC";

                string sizeName = sizeDAO.getSizeName(theItem.size_id);
                //MessageBox.Show(FullName);
                Name.Text = theItem.item_name;
                Name.AutoSize = false;

                double taxPercent = catDAO.GetTax(theItem.cat_id);
                double itemTax = Math.Round((theItem.item_price * taxPercent), 2);
                Tax.Text = "Tax: " + (itemTax).ToString();

                Size.Text = sizeName;


                Price.Text = "Price: " + theItem.item_price.ToString("F2");
                Remove.Text = "Delete";

                TotalPrice.Text = "Total: " + (Math.Round((itemTax + theItem.item_price), 2)).ToString();

                p.Controls.Add(UPC);
                p.Controls.Add(Name);
                p.Controls.Add(Price);
                p.Controls.Add(Size);
                p.Controls.Add(Tax);
                p.Controls.Add(Remove);
                p.Controls.Add(TotalPrice);


                TextBox quantityBox = new TextBox();

                quantityBox.ReadOnly = true;

                quantityBox.Location = new Point(150, 50);

                quantityBox.Name = "Quantity";

                quantityBox.Text = "1";

                p.Controls.Add(quantityBox);
                
                if(flowLayoutPanel1.HasChildren)
                {
                    int i = 0;
                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        
                        foreach (Control child in control.Controls)
                        {
                            
                            if (child is Label && child.Name == "UPC")
                            {
                                Label l = (Label)child;
                                if(UPC.Text == l.Text)
                                {
                                    String quantityNum = control.Controls["Quantity"].Text;
                                    control.Controls["Quantity"].Text = (int.Parse(quantityNum) + 1).ToString();
                                    i++;
                                }
                                
                               
                            }
                            

                        }
                     
                    }
                    if (i == 0)
                    {
                        flowLayoutPanel1.Controls.Add(p);

                    }
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(p);
                }

                


                Label subtotal = new Label();

                orderSubtotal += (theItem.item_price);

                subtotal.Text = "Subtotal: " + orderSubtotal.ToString("F2");

                panel4.Controls.Clear();

                panel4.Controls.Add(subtotal);



                Label taxTotal = new Label();

                orderTax += itemTax;

                taxTotal.Text = "Tax: " + orderTax.ToString("F2");

                panel2.Controls.Clear();

                panel2.Controls.Add(taxTotal);



                Label fullTotal = new Label();

                double addedTotal = orderSubtotal + orderTax;

                fullTotal.Text = "Total: " + addedTotal.ToString("F2");

                panel3.Controls.Clear();

                panel3.Controls.Add(fullTotal);

                textBox1.Clear();



            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");

            Button delete = (Button)sender;
            Control parentControl = delete.Parent;
            if (parentControl != null)
            {
                MessageBox.Show(parentControl.Name);
                ItemsDAO itemDAO = new ItemsDAO();
                Item i = itemDAO.getItemBySKU(parentControl.Controls["UPC"].Text);
                MessageBox.Show(i.item_name);
                String quant = parentControl.Controls["Quantity"].Text;
                MessageBox.Show(quant);
                if(int.Parse(quant) > 1)
                {
                    MessageBox.Show("Inside: " + quant);
                    TextBox quantityTextBox = parentControl.Controls["Quantity"] as TextBox;
                    quantityTextBox.Clear();
                    quantityTextBox.Text = (int.Parse(quant) - 1).ToString();

                    Label subtotal = new Label();

                    orderSubtotal -= i.item_price;

                    subtotal.Text = "Subtotal: " + orderSubtotal.ToString("F2");

                    panel4.Controls.Clear();

                    panel4.Controls.Add(subtotal);


                    Label taxTotal = new Label();

                    CategoryDAO catDAO = new CategoryDAO(); 

                    double taxPercent = catDAO.GetTax(i.cat_id);
                    double itemTax = Math.Round((i.item_price * taxPercent), 2);

                    orderTax -= itemTax;

                    taxTotal.Text = "Tax: " + orderTax.ToString("F2");

                    panel2.Controls.Clear();

                    panel2.Controls.Add(taxTotal);


                    Label fullTotal = new Label();

                    double addedTotal = orderSubtotal + orderTax;

                    fullTotal.Text = "Total: " + addedTotal.ToString("F2");

                    panel3.Controls.Clear();

                    panel3.Controls.Add(fullTotal);


                }
                if(int.Parse(quant) == 1)
                {
                    TextBox quantityTextBox = parentControl.Controls["Quantity"] as TextBox;

                    Label subtotal = new Label();

                    orderSubtotal -= i.item_price;

                    subtotal.Text = "Subtotal: " + orderSubtotal.ToString("F2");

                    panel4.Controls.Clear();

                    panel4.Controls.Add(subtotal);


                    Label taxTotal = new Label();

                    CategoryDAO catDAO = new CategoryDAO();

                    double taxPercent = catDAO.GetTax(i.cat_id);
                    double itemTax = Math.Round((i.item_price * taxPercent), 2);

                    orderTax -= itemTax;

                    taxTotal.Text = "Tax: " + orderTax.ToString("F2");

                    panel2.Controls.Clear();

                    panel2.Controls.Add(taxTotal);


                    Label fullTotal = new Label();

                    double addedTotal = orderSubtotal + orderTax;

                    fullTotal.Text = "Total: " + addedTotal.ToString("F2");

                    panel3.Controls.Clear();

                    panel3.Controls.Add(fullTotal);

                    parentControl.Parent.Controls.Remove(parentControl);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Complete Order Button
            OrdersDAO ords = new OrdersDAO();
            string ordsID = ords.getOrderID();
            ordsID = ordsID.Replace("ORD_", "");

            int ordsIDInt = int.Parse(ordsID);


            if (flowLayoutPanel1.HasChildren)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    int quant = -100;
                    int item_id = -100;
                    foreach (Control child in control.Controls)
                    {
                        if (child is TextBox && child.Name == "Quantity")
                        {
                            TextBox t = (TextBox)child;
                            quant = int.Parse(t.Text);
                            
                        }
                        if (child is Label && child.Name == "UPC")
                        {
                            ItemsDAO searchItms = new ItemsDAO();
                            Label l = (Label)child;
                            String SKU = l.Text;
                            item_id = searchItms.getItemID(SKU);

                        }

                    }

                    string newOrdID = "ORD_" + ((ordsIDInt + 1).ToString());

                    int result = ords.insertOrder(newOrdID, DateTime.Now, quant, item_id);
                    MessageBox.Show(result.ToString());
                    
                    

                }

            }

            flowLayoutPanel1.Controls.Clear();
            panel4.Controls.Clear();
            panel3.Controls.Clear();
            panel2.Controls.Clear();
            orderSubtotal = 0;
            orderTax = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Displays the Analytics of All orders such as total Sales, average Margin and total profit made. 

            OrdersDAO ordersDAO = new OrdersDAO();
            List<Orders> orderList = ordersDAO.getAllOrders();

            double totalSales = 0;
            double totalCost = 0;

            foreach (Orders o in orderList) 
            {
                int quantity = o.quantity;
                ItemsDAO itemsDAO = new ItemsDAO();
                double item_price = itemsDAO.getItemPrice(o.item_id);
                double item_cost = itemsDAO.getItemCost(o.item_id);

                totalSales += quantity * item_price;
                totalCost += quantity * item_cost;
            }

            Label totalSalesLabel = new Label();

            totalSalesLabel.ForeColor = Color.Black;

            totalSalesLabel.Text = "Total Sales: " + totalSales.ToString("F2");

            totalSalesPanel.Controls.Clear();

            totalSalesPanel.Controls.Add(totalSalesLabel);



            Label avgMarginLabel = new Label();

            avgMarginLabel.ForeColor = Color.Black;

            avgMarginLabel.AutoSize = true;

            avgMarginLabel.Text = "Average Margin: " + ((1 - (totalCost / totalSales))*100).ToString("F2") + "%";

            avgMarginPanel.Controls.Clear();   

            avgMarginPanel.Controls.Add(avgMarginLabel);


            Label totalProfitLabel = new Label();

            totalProfitLabel.ForeColor = Color.White;

            totalProfitLabel.AutoSize = true;

            totalProfitLabel.Text = "Total Profit: " + (totalSales - totalCost).ToString("F2");

            totalProfitPanel.Controls.Clear(); 

            totalProfitPanel.Controls.Add(totalProfitLabel);    








        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This method hides the POS Screen
            flowLayoutPanel1.Hide();
            textBox1.Hide();
            panel1.Hide();
            button1.Hide();

            panel5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This method shows the POS Screen
            flowLayoutPanel1.Show();
            textBox1.Show();
            panel1.Show();
            button1.Show();

            panel5.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //This method shows the analytics menu
            flowLayoutPanel1.Hide();
            textBox1.Hide();
            panel1.Hide();
            button1.Hide();

            panel5.Show();

        }

        /**
public void quantityBox_KeyDown(object sender, KeyPressEventArgs e)
{
   
   if (e.KeyChar == (char)Keys.Enter)
   {
       MessageBox.Show("Hi");
       TextBox quantityBox = (TextBox)sender;
       previousText = quantityBox.Text;
       MessageBox.Show(previousText + quantityBox.Text);
       Control parentControl = quantityBox.Parent;
       if (parentControl != null)
       {
           MessageBox.Show(parentControl.Name);
           ItemsDAO itemDAO = new ItemsDAO();
           Item i = itemDAO.getItemBySKU(parentControl.Controls["UPC"].Text);
           MessageBox.Show(i.item_name);
           orderSubtotal -= (i.item_price * (int.Parse(quantityBox.Text)));


       }
       
   }
   */



    }






    /*
private void button2_Click(object sender, EventArgs e)
{
Panel p = new Panel();
Label UPC = new Label();
Label Name = new Label();
Label Price = new Label();
UPC.Text = "078742051451";
Name.Text = "Member's Mark Purified Water";
Price.Text = "1.00";
p.Size = new System.Drawing.Size(250, 100);
p.BackColor = System.Drawing.Color.Orange;
UPC.Location = new Point(10, 10);
Name.Location = new Point(10, 30);
Price.Location = new Point(200, 30);
p.Controls.Add(UPC);
p.Controls.Add(Name);
p.Controls.Add(Price);

flowLayoutPanel1.Controls.Add(p);
}
*/
}
