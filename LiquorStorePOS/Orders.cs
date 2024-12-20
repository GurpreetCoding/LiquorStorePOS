using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStorePOS
{
    internal class Orders
    {
        public int row_id { get; set; }
        public String order_id { get; set; }
        public DateTime date_created { get; set; }
        public int quantity { get; set; }
        public int item_id { get; set; }

    }
}
