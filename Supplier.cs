using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCar
{
    internal class Supplier
    {
        public int SupplierID { get; set; } // Unique identification code for the supplier
        public string SupplierName { get; set; } // Name of the supplier
        public string Address { get; set; } // Headquarters or warehouse address
        public string PhoneNumber { get; set; } // Contact number
        public string Email { get; set; } // Email address
        public ICollection<Product> Products { get; set; }
    }
}
