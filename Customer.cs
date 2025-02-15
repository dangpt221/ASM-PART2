﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCar
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PurchaseHistory { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
