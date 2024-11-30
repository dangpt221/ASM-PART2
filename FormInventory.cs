using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class FormInventory : Form
    {
        public bool isExit = true;
        public FormInventory()
        {
            InitializeComponent();
            this.Load += FormInventory_Load;
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

        private void FormInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            LoadData();
            

        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var inventory = context.inventories;
                    
                    
                
            }

        }
        

        private void btnitadd_Click(object sender, EventArgs e)
        {
            using(var context = new ASMDBContext())
            {
                
                var inventory = new Inventory
                {
                    Warehouselocation = txtitwarehouselocation.Text,
                    StockQuantity = int.Parse(txtitstockquantity.Text),
                    StoredProducts = txtitstoredproducts.Text,
                };
                context.inventories.Add(inventory);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnitupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var inventory = context.inventories.Select(p => new
                {
                    p.InventoryID,
                    p.StockQuantity,
                    p.StoredProducts,
                    p.Warehouselocation,
                }).ToList(); dgvinventory.DataSource = inventory;
            }

        }

        private void btnitsearch_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var inventory = context.inventories.Where(p => p.Warehouselocation.Contains(txtitwarehouselocation.Text)).ToList();
                dgvinventory.DataSource = inventory;
            }
        }

        private void btnitdelete_Click(object sender, EventArgs e)
        {
            using(var context = new ASMDBContext())
            {
                var inventory = context.inventories.FirstOrDefault(p => p.InventoryID == int.Parse(txtitid.Text));
                if (inventory != null)
                {
                    context.inventories.Remove(inventory);
                    int ret = context.SaveChanges();
                    if(ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu  thanh cong");
                        btnitupload.PerformClick();
                            
                    }
                }
            }
        }

        private void btnitupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var inventory = context.inventories.FirstOrDefault(p => p.InventoryID == int.Parse(txtitid.Text));
                if(inventory != null)
                {
                    inventory.StockQuantity = int.Parse( txtitstockquantity.Text);
                    inventory.StoredProducts = txtitstoredproducts.Text;
                    inventory.Warehouselocation = txtitwarehouselocation.Text;
                    int ret = context.SaveChanges();
                    if(ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnitupload.PerformClick();
                    }
                } 
            }
        }
    }
}
