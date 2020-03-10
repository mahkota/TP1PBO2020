using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
   
    
    class Items
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public string ItemType { get; set; }

        public Items (string ItemName, int ItemPrice, string ItemType)
        {
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            this.ItemType = ItemType;
        }

        public Items()
        {

        }
    }
}
