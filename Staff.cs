using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCar
{
    internal class Staff
    {
        public int StaffID { get; set; } // Unique ID for the employee
        public string Name { get; set; } // Full name of the employee
        public string Position { get; set; } // Position of the employee
        public string PhoneNumber { get; set; } // Contact number
        public string Email { get; set; } // Personal email
        public DateTime WorkingDay { get; set; } // Starting date of employment
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
