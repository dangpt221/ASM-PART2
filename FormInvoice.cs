using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTCar
{
    public partial class FormInvoice : Form
    {
        public bool isExit = true;
        public FormInvoice()
        {
            InitializeComponent();
        }
        public event EventHandler Logout;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void FormInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muont thoat khoi chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices;


            }
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices;

            }
        }



        private void btnivad_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {

                var invoice = new Invoice
                {
                    Invoicedate = DateTime.Now,
                    Name = txtivname.Text,
                    TotalAmount = decimal.Parse(txtivtotalamount.Text),
                    PaymentMethod = txtivpaymentmehtod.Text,
                    ListofProducts = txtivlistproduct.Text,

                };
                context.invoices.Add(invoice);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();

            }
        }

        private void btnivupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices.Select(p => new
                {
                    p.InvoiceID,
                    p.Name,
                    TotalAmount = (float)p.TotalAmount,
                    p.PaymentMethod,
                    p.ListofProducts,

                }).ToList(); ; dgvinvoice.DataSource = invoice;
            }
        }

        private void btnivsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices.Where(p => p.InvoiceID == int.Parse(txtivid.Text)).ToList();
                dgvinvoice.DataSource = invoice;
            }

        }

        private void btnivdelete_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices.FirstOrDefault(p => p.InvoiceID == int.Parse(txtivid.Text));
                if (invoice != null)
                {
                    context.invoices.Remove(invoice);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnivupload.PerformClick();
                    }
                }

            }
        }

        private void btnivupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var invoice = context.invoices.FirstOrDefault(p => p.InvoiceID == int.Parse(txtivid.Text));
                if (invoice != null)
                {
                    invoice.Invoicedate = DateTime.Now;
                    invoice.Name = txtivname.Text;
                    invoice.TotalAmount = decimal.Parse(txtivtotalamount.Text);
                    invoice.ListofProducts = txtivlistproduct.Text;
                    invoice.PaymentMethod = txtivpaymentmehtod.Text;
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnivupload.PerformClick();
                    }
                }
            }
        }

        private void btnivexportbill_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            f.Show();
            this.Hide();
            string bill = "HÓA ĐƠN\n";
            bill += "----------------------------------\n";
            bill += $"Name: {txtivname.Text}\n";
            bill += $"Paymentmehtod: {txtivpaymentmehtod.Text}\n";
            bill += $"Datetime: {dtivdate}\n";
            bill += $"ListProduct: {txtivlistproduct}\n";
            bill += $"Product: {txtpdname}\n";
            bill += $"Quantity: {txtpdquantity}\n";
          
            bill += "----------------------------------\n";
            bill += $"Sản phẩm:{txtpdname}\"tSố lượng:{txtpdquantity}\"tĐơn giá:{txtpdprice}\"tThành tiền\n:{txtivpayment}";

            foreach (DataGridViewRow row in dgvinvoice.Rows)
            {
                if (row.Cells["name"].Value != null)
                {
                    bill += $"{row.Cells["ProductName"].Value}\t";
                    bill += $"{row.Cells["Quantity"].Value}\t";
                    bill += $"{row.Cells["Price"].Value:C}\t";
                    bill += $"{row.Cells["Total"].Value:C}\n";
                }
            }

            bill += "----------------------------------\n";
            bill += labtotalamount.Text;

            // Hiển thị hóa đơn
            MessageBox.Show(bill);

            // (Tùy chọn) Ghi hóa đơn ra file
            System.IO.File.WriteAllText("Bill.txt", bill);
        }
    }
    
}
