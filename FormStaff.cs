using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTCar
{
    public partial class FormStaff : Form
    {
        public bool isExit = true;
        public FormStaff()
        {
            InitializeComponent();
            this.Load += FormStaff_Load;
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

        private void FormStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat khoi chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            using (var context = new ASMDBContext())
            {
                var staff = context.Staffs;

            }
        }

        private void btnstadd_Click(object sender, EventArgs e)
        {
            using(var context = new ASMDBContext())
            {

                var staff = new Staff
                {
                    Name = txtstname.Text,
                    Email = txtstemail.Text,
                    PhoneNumber = txtstphonenumber.Text,
                    Position = txtstposition.Text,  
                    WorkingDay =DateTime.Now,


                };
                context.Staffs.Add(staff);
                context.SaveChanges();
                MessageBox.Show("Them moi du lieu thanh cong");
                LoadData();
            }
        }

        private void btnstupload_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var staff = context.Staffs.Select(p => new
                {
                    p.Name,
                    p.Email,
                    p.PhoneNumber,
                    p.Position,
                    p.WorkingDay,
                }).ToList();
            }
        }

        private void btnstsearch_Click(object sender, EventArgs e)
        {
            using(var context = new ASMDBContext())
            {
                var staff = context.Staffs.Where(p => p.Name.Contains(txtstname.Text)).ToList();
                dgvstaff.DataSource = staff;
            }
        }

        private void btnstdelete_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var staff = context.Staffs.FirstOrDefault(p => p.StaffID == int.Parse(txtstid.Text));
                if (staff != null)
                {
                    context.Staffs.Remove(staff);
                    int ret = context.SaveChanges();
                    if(ret != 0)
                    {
                        MessageBox.Show("Xoa du lieu thanh cong");
                        btnstupload.PerformClick();
                    }
                }
            }

        }

        private void btnstupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ASMDBContext())
            {
                var staff = context.Staffs.FirstOrDefault(p => p.StaffID == int.Parse(txtstid.Text));
                if(staff != null)
                {
                    staff.Name = txtstname.Text;
                    staff.Email = txtstemail.Text;
                    staff.Position = txtstposition.Text;
                    staff.PhoneNumber = txtstphonenumber.Text;
                    int ret = context.SaveChanges();    
                    if(ret != 0)
                    {
                        MessageBox.Show("Cap nhat du lieu thanh cong");
                        btnstupload.PerformClick();
                    }
                }
            }
        }
    }
}
