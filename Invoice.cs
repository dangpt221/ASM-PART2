using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCar
{
    internal class Invoice
    {
        public int InvoiceID { get; set; }
        public string Name { get; set; }
        public DateTime Invoicedate { get; set; }
        public decimal TotalAmount { get; set; }
        public string ListofProducts { get; set; }
        public string PaymentMethod { get; set; }
        
    }
}
