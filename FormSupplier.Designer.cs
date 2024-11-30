namespace PTCar
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            btnlogout = new Button();
            btnexit = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtspsearch = new TextBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            txtspaddress = new TextBox();
            txtspphonenumbers = new TextBox();
            txtspemail = new TextBox();
            txtspname = new TextBox();
            txtspid = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            labid = new Label();
            pictureBox4 = new PictureBox();
            dgvsupplier = new DataGridView();
            pictureBox5 = new PictureBox();
            btnspsearch = new Button();
            btnspupdate = new Button();
            btnspadd = new Button();
            btnspsave = new Button();
            btnspdelete = new Button();
            btnspupload = new Button();
            btnslsearch = new Button();
            btnslupdate = new Button();
            btnsladd = new Button();
            btnsldelete = new Button();
            btnslupload = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_nen_ngon_lua_xanh_nghe_thuat_12;
            btnlogout.Location = new Point(1009, 575);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(92, 34);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "LogOut";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.FromArgb(255, 128, 128);
            btnexit.Image = Properties.Resources.hinh_nen_ngon_lua_xanh_nghe_thuat_13;
            btnexit.Location = new Point(1139, 575);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(92, 34);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtspsearch);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(-3, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1234, 106);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox2.Location = new Point(1107, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtspsearch
            // 
            txtspsearch.Location = new Point(152, 66);
            txtspsearch.Name = "txtspsearch";
            txtspsearch.Size = new Size(237, 23);
            txtspsearch.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supplier;
            pictureBox1.Location = new Point(597, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(561, 0);
            label10.Name = "label10";
            label10.Size = new Size(170, 50);
            label10.TabIndex = 0;
            label10.Text = "Supplier";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(78, 67);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 0;
            label9.Text = "Search";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1231, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtspaddress);
            groupBox1.Controls.Add(txtspphonenumbers);
            groupBox1.Controls.Add(txtspemail);
            groupBox1.Controls.Add(txtspname);
            groupBox1.Controls.Add(txtspid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labid);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(613, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 235);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier Information";
            // 
            // txtspaddress
            // 
            txtspaddress.Location = new Point(429, 166);
            txtspaddress.Name = "txtspaddress";
            txtspaddress.Size = new Size(183, 29);
            txtspaddress.TabIndex = 1;
            // 
            // txtspphonenumbers
            // 
            txtspphonenumbers.Location = new Point(429, 81);
            txtspphonenumbers.Name = "txtspphonenumbers";
            txtspphonenumbers.Size = new Size(183, 29);
            txtspphonenumbers.TabIndex = 1;
            // 
            // txtspemail
            // 
            txtspemail.Location = new Point(117, 200);
            txtspemail.Name = "txtspemail";
            txtspemail.Size = new Size(206, 29);
            txtspemail.TabIndex = 1;
            // 
            // txtspname
            // 
            txtspname.Location = new Point(117, 120);
            txtspname.Name = "txtspname";
            txtspname.Size = new Size(206, 29);
            txtspname.TabIndex = 1;
            // 
            // txtspid
            // 
            txtspid.Location = new Point(117, 44);
            txtspid.Name = "txtspid";
            txtspid.Size = new Size(206, 29);
            txtspid.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 211);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 128);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 44);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 0;
            label4.Text = "PhoneNumbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // labid
            // 
            labid.AutoSize = true;
            labid.Location = new Point(28, 52);
            labid.Name = "labid";
            labid.Size = new Size(33, 21);
            labid.TabIndex = 0;
            labid.Text = "ID";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(6, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(612, 204);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // dgvsupplier
            // 
            dgvsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsupplier.Location = new Point(12, 125);
            dgvsupplier.Name = "dgvsupplier";
            dgvsupplier.Size = new Size(595, 484);
            dgvsupplier.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-3, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1231, 613);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // btnspsearch
            // 
            btnspsearch.Location = new Point(0, 0);
            btnspsearch.Name = "btnspsearch";
            btnspsearch.Size = new Size(75, 23);
            btnspsearch.TabIndex = 0;
            // 
            // btnspupdate
            // 
            btnspupdate.Location = new Point(0, 0);
            btnspupdate.Name = "btnspupdate";
            btnspupdate.Size = new Size(75, 23);
            btnspupdate.TabIndex = 0;
            // 
            // btnspadd
            // 
            btnspadd.Location = new Point(0, 0);
            btnspadd.Name = "btnspadd";
            btnspadd.Size = new Size(75, 23);
            btnspadd.TabIndex = 0;
            // 
            // btnspsave
            // 
            btnspsave.Location = new Point(0, 0);
            btnspsave.Name = "btnspsave";
            btnspsave.Size = new Size(75, 23);
            btnspsave.TabIndex = 0;
            // 
            // btnspdelete
            // 
            btnspdelete.Location = new Point(0, 0);
            btnspdelete.Name = "btnspdelete";
            btnspdelete.Size = new Size(75, 23);
            btnspdelete.TabIndex = 0;
            // 
            // btnspupload
            // 
            btnspupload.Location = new Point(0, 0);
            btnspupload.Name = "btnspupload";
            btnspupload.Size = new Size(75, 23);
            btnspupload.TabIndex = 0;
            // 
            // btnslsearch
            // 
            btnslsearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnslsearch.Location = new Point(613, 375);
            btnslsearch.Name = "btnslsearch";
            btnslsearch.Size = new Size(75, 37);
            btnslsearch.TabIndex = 6;
            btnslsearch.Text = "Search";
            btnslsearch.UseVisualStyleBackColor = true;
            btnslsearch.Click += btnslsearch_Click;
            // 
            // btnslupdate
            // 
            btnslupdate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnslupdate.Location = new Point(739, 375);
            btnslupdate.Name = "btnslupdate";
            btnslupdate.Size = new Size(85, 37);
            btnslupdate.TabIndex = 6;
            btnslupdate.Text = "Update";
            btnslupdate.UseVisualStyleBackColor = true;
            btnslupdate.Click += btnslupdate_Click;
            // 
            // btnsladd
            // 
            btnsladd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsladd.Location = new Point(884, 375);
            btnsladd.Name = "btnsladd";
            btnsladd.Size = new Size(75, 37);
            btnsladd.TabIndex = 6;
            btnsladd.Text = "Add";
            btnsladd.UseVisualStyleBackColor = true;
            btnsladd.Click += btnsladd_Click;
            // 
            // btnsldelete
            // 
            btnsldelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsldelete.Location = new Point(1026, 375);
            btnsldelete.Name = "btnsldelete";
            btnsldelete.Size = new Size(75, 37);
            btnsldelete.TabIndex = 6;
            btnsldelete.Text = "Delete";
            btnsldelete.UseVisualStyleBackColor = true;
            btnsldelete.Click += btnsldelete_Click;
            // 
            // btnslupload
            // 
            btnslupload.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnslupload.Location = new Point(1139, 375);
            btnslupload.Name = "btnslupload";
            btnslupload.Size = new Size(86, 37);
            btnslupload.TabIndex = 6;
            btnslupload.Text = "UpLoad";
            btnslupload.UseVisualStyleBackColor = true;
            btnslupload.Click += btnslupload_Click;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 621);
            Controls.Add(btnslupload);
            Controls.Add(btnsldelete);
            Controls.Add(btnsladd);
            Controls.Add(btnslupdate);
            Controls.Add(btnslsearch);
            Controls.Add(dgvsupplier);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(btnexit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox5);
            Name = "FormSupplier";
            Text = "FormSupplier";
            FormClosing += FormSupplier_FormClosing;
            Load += FormSupplier_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnexit;
        private DataGridView dgvsupplier;
        private Button btnspupload;
        private Button btnspdelete;
        private Button btnspsave;
        private Button btnspadd;
        private Button btnspupdate;
      
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label Picture;
        private GroupBox groupBox1;
        private TextBox txtstid;
        private DateTimePicker dtstworkingday;
        private Label label3;
        private ComboBox cbstposition;
        private Label label6;
        private TextBox txtstname;
        private Label label7;
        private TextBox txtstemail;
        private Label label8;
        private TextBox txtstphonenumber;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private TextBox txtspsearch;
        private Label label2;
        private Label labid;
        private PictureBox pictureBox2;
        private Button btnspsearch;
     
        private PictureBox pictureBox5;
        private Panel panel2;
        private Label label10;
        private Label label9;
      
        private TextBox txtspaddress;
        private TextBox txtspphonenumbers;
        private TextBox txtspemail;
        private TextBox txtspname;
        private TextBox txtspid;
        private Button btnslsearch;
        private Button btnslupdate;
        private Button btnsladd;
        private Button btnsldelete;
        private Button btnslupload;
    }
}