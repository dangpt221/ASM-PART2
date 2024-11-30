using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCar
{
    internal class Product
    {
        public int ProductID { get; set; } // Unique ID for the product
        public string ProductName { get; set; } // Name of the product
        public decimal Price { get; set; } // Price of the product
        public int Quantity { get; set; } // Quantity in stock
        public string Description { get; set; } // Description of the product
        
        public ICollection<Inventory> inventories { get; set; }
    }
}
