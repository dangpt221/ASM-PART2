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
    public partial class FormCustomer : Form
    {
        public bool isExit = true;
        public FormCustomer()
        {
            InitializeComponent();
        }
        public event EventHandler Logout;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban co muon quay lai form Main");
            Logout(this, new EventArgs());
            
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            getOrder();
        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var customer = context.customers
                    .Include(p => p.Orders).Select(p => new
                    {
                        p.CustomerID,
                        p.CustomerName,
                        p.PhoneNumber,
                        p.Email,
                        p.PurchaseHistory,


                    }).ToList();
                dgvcustomer.DataSource = customer;



            }


        }
        private void getOrder()
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders.ToList();

            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var customer = new Customer
                {
                   
                    CustomerName = txtctname.Text,
                    PhoneNumber = txtctphonenumber.Text,
                    Email = txtctemail.Text,
                    Address = txtctaddress.Text,
                    PurchaseHistory = txtctpurchasehistory.Text,
                };
                context.customers.Add(customer);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnctupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var customer = context.customers.Select(p => new
                {
                    p.CustomerID,
                    p.CustomerName,
                    p.PhoneNumber,
                    p.Email,
                    p.PurchaseHistory,
                }).ToList(); dgvcustomer.DataSource = customer;
                MessageBox.Show("Upload thanh cong");
            }
        }

        private void btnctsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var customer = context.customers.Where(p => p.CustomerName.Contains(txtctsearch.Text)).ToList();
                dgvcustomer.DataSource = customer;
            }
            MessageBox.Show("Tim kiem thanh cong");
        }

        private void btnctdelete_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var customer = context.customers.FirstOrDefault(p => p.CustomerID == int.Parse(txtctid.Text));
                if (customer != null)
                {
                    context.customers.Remove(customer);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnctupload.PerformClick();
                    }
                }
            }
        }

        private void btnctupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var customer = context.customers.FirstOrDefault(p => p.CustomerID == int.Parse(txtctid.Text));
                if(customer != null)
                {
                    customer.CustomerName = txtctname.Text;
                    customer.PhoneNumber = txtctphonenumber.Text;
                    customer.Email = txtctemail.Text;
                    customer.Address = txtctaddress.Text;
                    int ret = context.SaveChanges();
                    if(ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnctupload.PerformClick();
                    }
                }
            }
        }
    }
}
