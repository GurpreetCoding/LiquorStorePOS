using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStorePOS
{
    internal class Item
    {
        public int item_id { get; set; }
        public String item_sku { get; set; }
        public String item_name { get; set;}
        public int cat_id { get; set; }
        public double item_price { get; set; }
        public double item_cost { get; set;}
        public int size_id { get; set; }
    }
}
