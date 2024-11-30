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
    public partial class FormProduct : Form
    {
        public bool isExit = true;
        public FormProduct()
        {
            InitializeComponent();
            this.Load += FormProduct_Load;
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

        private void FormProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong tring", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var product = context.products;
              
               
            }
        }
       
        
        private void btnpdadd_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                
                var product = new Product
                {
                    
                    ProductName = txtpdname.Text,
                    Description = txtpddescription.Text,
                    Quantity = int.Parse(txtpdquantity.Text),
                    Price = decimal.Parse(txtpdprice.Text),
                    
                };
                context.products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnpdupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var product = context.products.Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.Description,
                    p.Quantity,
                    Price = (float)p.Price,
                }).ToList(); dgvproduct.DataSource = product;
            }

        }

        private void btnpdsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var product = context.products.Where(p => p.ProductName.Contains(txtpdname.Text)).ToList();
                dgvproduct.DataSource = product;
            }
        }

        private void btnpddelete_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var product = context.products.FirstOrDefault(p => p.ProductID == int.Parse(txtpdid.Text));
                if (product != null)
                {
                    context.products.Remove(product);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnpdupload.PerformClick();
                    }
                }
            }
        }

        private void btnpdupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var product = context.products.FirstOrDefault(p => p.ProductID == int.Parse(txtpdid.Text));
                if (product != null)
                {
                    product.ProductName = txtpdname.Text;
                    product.Description = txtpddescription.Text;
                    product.Quantity = int.Parse(txtpdquantity.Text);
                    product.Price = int.Parse(txtpdprice.Text);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnpdupload.PerformClick();
                    }
                }
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadData();
           
        }
    }
}
