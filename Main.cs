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
    public partial class Main : Form
    {
        public bool isExit = true;
        public Main()
        {
            InitializeComponent();
        }
        public event EventHandler Logout;
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            FormStaff f = new FormStaff();
            f.Show();
            this.Hide();
            f.Logout += F_Logout1;
        }

        private void F_Logout1(object? sender, EventArgs e)
        {
            (sender as FormStaff).isExit = false;
            (sender as FormStaff).Close();
            this.Show();
        }

    

        private void btnorder_Click(object sender, EventArgs e)
        {
            FormOrder f = new FormOrder();  
            f.Show();
            this.Hide();
            f.Logout += F_Logout2;
        }
        private void F_Logout2(object? sender, EventArgs e)
        {
            (sender as FormOrder).isExit = false;
            (sender as FormOrder).Close();
            this.Show();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            FormInvoice f = new FormInvoice();
            f.Show();
            this.Hide();
            f.Logout += F_Logout3;
        }
        private void F_Logout3(object? sender, EventArgs e)
        {
            (sender as FormInvoice).isExit = false;
            (sender as FormInvoice).Close();
            this.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            FormProduct f = new FormProduct();
            f.Show();
            this.Hide();
            f.Logout += F_Logout4;
        }
        private void F_Logout4(object? sender, EventArgs e)
        {
            (sender as FormProduct).isExit = false;
            (sender as FormProduct).Close();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban chuyen sang thanh cong");
            FormCustomer f = new FormCustomer();
            f.Show();
            this.Hide();
            f.Logout += F_Logout5;
            

        }
        private void F_Logout5(object? sender, EventArgs e)
        {
            (sender as FormCustomer).isExit = false;
            (sender as FormCustomer).Close();
            this.Show();
        }
        private void btninventory_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Hide();
            f.Logout += F_Logout6;
        }
        private void F_Logout6(object? sender, EventArgs e)
        {
            (sender as FormInventory).isExit = false;
            (sender as FormInventory).Close();
            this.Show();
        }
        private void btnsupplier_Click(object sender, EventArgs e)
        {
            FormSupplier f = new FormSupplier();
            f.Show();
            this.Hide();
            f.Logout += F_Logout7;
        }
        private void F_Logout7(object? sender, EventArgs e)
        {
            (sender as FormSupplier).isExit = false;
            (sender as FormSupplier).Close();
            this.Show();
        }
    }
}
