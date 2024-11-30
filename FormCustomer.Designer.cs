namespace PTCar
{
    partial class FormCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            btnlogout = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtctsearch = new TextBox();
            pictureBox1 = new PictureBox();
            dgvcustomer = new DataGridView();
            groupBox1 = new GroupBox();
            txtctaddress = new TextBox();
            txtctname = new TextBox();
            txtctpurchasehistory = new TextBox();
            txtctphonenumber = new TextBox();
            txtctemail = new TextBox();
            txtctid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnctsearch = new Button();
            btncdadd = new Button();
            btnctupdate = new Button();
            btnctdelete = new Button();
            btnctupload = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_nen_may_tinh_4k_15;
            btnlogout.Location = new Point(4, 587);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 39);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(255, 128, 128);
            btnExit.Image = Properties.Resources.hinh_nen_may_tinh_4k_15;
            btnExit.Location = new Point(235, 587);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 39);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtctsearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 133);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox3.Location = new Point(1057, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.moi_quan_he_giua_customer_va_consumer;
            pictureBox2.Location = new Point(577, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(549, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 50);
            label2.TabIndex = 0;
            label2.Text = "Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Image = Properties.Resources.hinh_nen_may_tinh_4k_15;
            label1.Location = new Point(104, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // txtctsearch
            // 
            txtctsearch.Location = new Point(173, 63);
            txtctsearch.Name = "txtctsearch";
            txtctsearch.Size = new Size(200, 23);
            txtctsearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1248, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvcustomer
            // 
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Location = new Point(347, 464);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.Size = new Size(874, 162);
            dgvcustomer.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtctaddress);
            groupBox1.Controls.Add(txtctname);
            groupBox1.Controls.Add(txtctpurchasehistory);
            groupBox1.Controls.Add(txtctphonenumber);
            groupBox1.Controls.Add(txtctemail);
            groupBox1.Controls.Add(txtctid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(347, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(874, 234);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // txtctaddress
            // 
            txtctaddress.Location = new Point(127, 194);
            txtctaddress.Name = "txtctaddress";
            txtctaddress.Size = new Size(200, 29);
            txtctaddress.TabIndex = 1;
            // 
            // txtctname
            // 
            txtctname.Location = new Point(127, 115);
            txtctname.Name = "txtctname";
            txtctname.Size = new Size(200, 29);
            txtctname.TabIndex = 1;
            // 
            // txtctpurchasehistory
            // 
            txtctpurchasehistory.Location = new Point(650, 194);
            txtctpurchasehistory.Name = "txtctpurchasehistory";
            txtctpurchasehistory.Size = new Size(200, 29);
            txtctpurchasehistory.TabIndex = 1;
            // 
            // txtctphonenumber
            // 
            txtctphonenumber.Location = new Point(650, 115);
            txtctphonenumber.Name = "txtctphonenumber";
            txtctphonenumber.Size = new Size(200, 29);
            txtctphonenumber.TabIndex = 1;
            // 
            // txtctemail
            // 
            txtctemail.Location = new Point(650, 40);
            txtctemail.Name = "txtctemail";
            txtctemail.Size = new Size(200, 29);
            txtctemail.TabIndex = 1;
            // 
            // txtctid
            // 
            txtctid.Location = new Point(127, 42);
            txtctid.Name = "txtctid";
            txtctid.Size = new Size(200, 29);
            txtctid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 202);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 123);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(413, 202);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 0;
            label8.Text = "Purchase History";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(413, 123);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 0;
            label7.Text = "Phonenumbers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(413, 43);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 43);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // btnctsearch
            // 
            btnctsearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnctsearch.Location = new Point(347, 394);
            btnctsearch.Name = "btnctsearch";
            btnctsearch.Size = new Size(75, 43);
            btnctsearch.TabIndex = 4;
            btnctsearch.Text = "Search";
            btnctsearch.UseVisualStyleBackColor = true;
            btnctsearch.Click += btnctsearch_Click;
            // 
            // btncdadd
            // 
            btncdadd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btncdadd.Location = new Point(535, 394);
            btncdadd.Name = "btncdadd";
            btncdadd.Size = new Size(75, 43);
            btncdadd.TabIndex = 4;
            btncdadd.Text = "Add";
            btncdadd.UseVisualStyleBackColor = true;
            btncdadd.Click += button2_Click;
            // 
            // btnctupdate
            // 
            btnctupdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnctupdate.Location = new Point(760, 394);
            btnctupdate.Name = "btnctupdate";
            btnctupdate.Size = new Size(75, 43);
            btnctupdate.TabIndex = 4;
            btnctupdate.Text = "Update";
            btnctupdate.UseVisualStyleBackColor = true;
            btnctupdate.Click += btnctupdate_Click;
            // 
            // btnctdelete
            // 
            btnctdelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnctdelete.Location = new Point(984, 394);
            btnctdelete.Name = "btnctdelete";
            btnctdelete.Size = new Size(75, 43);
            btnctdelete.TabIndex = 4;
            btnctdelete.Text = "Delete";
            btnctdelete.UseVisualStyleBackColor = true;
            btnctdelete.Click += btnctdelete_Click;
            // 
            // btnctupload
            // 
            btnctupload.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnctupload.Location = new Point(1146, 394);
            btnctupload.Name = "btnctupload";
            btnctupload.Size = new Size(75, 43);
            btnctupload.TabIndex = 4;
            btnctupload.Text = "UpLoad";
            btnctupload.UseVisualStyleBackColor = true;
            btnctupload.Click += btnctupload_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1223, 625);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 631);
            Controls.Add(btnctupload);
            Controls.Add(btnctdelete);
            Controls.Add(btnctupdate);
            Controls.Add(btncdadd);
            Controls.Add(btnctsearch);
            Controls.Add(groupBox1);
            Controls.Add(dgvcustomer);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox4);
            Name = "FormCustomer";
            Text = "FormCustomer";
            FormClosing += FormCustomer_FormClosing;
            Load += FormCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnExit;
        private Panel panel1;
        private DataGridView dgvcustomer;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtctaddress;
        private TextBox txtctname;
        private TextBox txtctphonenumber;
        private TextBox txtctemail;
        private TextBox txtctid;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox txtctsearch;
        private Button btnctsearch;
        private Button btncdadd;
        private Button btnctupdate;
        private Button btnctdelete;
        private Button btnctupload;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox txtctpurchasehistory;
    }
}