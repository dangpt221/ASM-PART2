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
    public partial class FormSupplier : Form
    {
        public bool isExit = true;
        public FormSupplier()
        {
            InitializeComponent();
            this.Load += FormSupplier_Load;
        }
        public event EventHandler Logout;

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void FormSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinf", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var supplier = context.Suppliers;
                
                
                    
            }
        }

        private void btnsladd_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var supplier = new Supplier
                {
                    SupplierName = txtspname.Text,
                    PhoneNumber = txtspphonenumbers.Text,
                    Email = txtspemail.Text,
                    Address = txtspaddress.Text,
                };
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnslupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var supplier = context.Suppliers.Select(p => new
                {
                    p.SupplierName,
                    p.PhoneNumber,
                    p.Email,
                    p.Address,
                }).ToList();dgvsupplier.DataSource = supplier;
            }

        }

        private void btnslsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var supplier = context.Suppliers .Where( p => p.SupplierName.Contains(txtspname.Text)).ToList();
                dgvsupplier.DataSource = supplier;
            }
        }

        private void btnsldelete_Click(object sender, EventArgs e)
        {
            using(var context = new ASMDBContext())
            {
                var supplier = context.Suppliers.FirstOrDefault(p => p.SupplierID == int.Parse(txtspid.Text));
                if(supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnspupload.PerformClick();
                    }
                }    
            }
        }

        private void btnslupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var supplier = context.Suppliers.FirstOrDefault(p => p.SupplierID == int.Parse(txtspid.Text));
                if(supplier != null)
                {
                    supplier.SupplierName = txtspname.Text;
                    supplier.PhoneNumber = txtspphonenumbers.Text;  
                    supplier.Email = txtspemail.Text;
                    supplier.Address = txtspaddress.Text;
                    int ret = context.SaveChanges();
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnspupload.PerformClick();
                    }
                }
            }
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }
    }
}
