using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTCar
{
    public partial class FormOrder : Form
    {
        public bool isExit = true;
        public FormOrder()
        {
            InitializeComponent();
            this.Load += FormOrder_Load;

        }
        public event EventHandler Logout;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadData();
           

        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders;
                
                
                
            }
           

        }
        
        

        private void btnodadd_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                
                var order = new Order
                {
                    OrderDate = DateTime.Now,
                    OrderName = txtodname.Text,
                    ProdcutList = txtodproductlist.Text,

                };
                context.orders.Add(order);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnodupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders.Select(p => new
                {
                    p.OrderID,
                    p.OrderName,
                    p.OrderDate,
                    p.ProdcutList,
                }).ToList(); dgvorder.DataSource = order;
            }
        }

        private void btnodupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders.FirstOrDefault(p => p.OrderID == int.Parse(txtodid.Text));
                if (order != null)
                {
                    order.OrderDate = DateTime.Now;
                    order.OrderName = txtodname.Text;
                    order.OrderID = int.Parse(txtodid.Text);
                    order.ProdcutList = txtodproductlist.Text;
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu  thanh cong");
                        btnodupload.PerformClick();
                    }
                }
            }
        }

        private void btnoddelete_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders.FirstOrDefault(p => p.OrderID == int.Parse(txtodid.Text));
                if (order != null)
                {
                    context.orders.Remove(order);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnodupload.PerformClick();
                    }
                }
            }
        }

        private void btnodsave_Click(object sender, EventArgs e)
        {

        }

        private void btnodsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var order = context.orders.Where(P => P.OrderName.Contains(txtodsearch.Text)).ToList();
                dgvorder.DataSource = order;
            }
        }
    }
}
