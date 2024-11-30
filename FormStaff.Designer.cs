namespace PTCar
{
    partial class FormStaff
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
            btnlogout = new Button();
            btnexit = new Button();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtstid = new TextBox();
            txtstname = new TextBox();
            txtstphonenumber = new TextBox();
            txtstemail = new TextBox();
            dtstworkingday = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtstposition = new TextBox();
            Picture = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnstsearch = new Button();
            btnstupdate = new Button();
            btnstadd = new Button();
            btnstdelete = new Button();
            btnstupload = new Button();
            dgvstaff = new DataGridView();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvstaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            btnlogout.Location = new Point(12, 590);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(82, 37);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.FromArgb(255, 128, 128);
            btnexit.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            btnexit.Location = new Point(226, 590);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(82, 37);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1220, 129);
            panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox6.Location = new Point(1064, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(153, 70);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_office_worker_sven_boy_cute_cartoon_boy_with_a_briefcase_png_image_38483635;
            pictureBox1.Location = new Point(554, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(569, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 0;
            label2.Text = "Staff";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 81);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao2;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1214, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 48);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 126);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 213);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 2;
            label5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(497, 48);
            label6.Name = "label6";
            label6.Size = new Size(136, 21);
            label6.TabIndex = 2;
            label6.Text = "Phone Numbers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(497, 131);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 2;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(497, 213);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 2;
            label8.Text = "Workingday";
            // 
            // txtstid
            // 
            txtstid.Location = new Point(159, 45);
            txtstid.Name = "txtstid";
            txtstid.Size = new Size(163, 29);
            txtstid.TabIndex = 3;
            // 
            // txtstname
            // 
            txtstname.Location = new Point(159, 124);
            txtstname.Name = "txtstname";
            txtstname.Size = new Size(163, 29);
            txtstname.TabIndex = 3;
            // 
            // txtstphonenumber
            // 
            txtstphonenumber.Location = new Point(672, 45);
            txtstphonenumber.Name = "txtstphonenumber";
            txtstphonenumber.Size = new Size(163, 29);
            txtstphonenumber.TabIndex = 3;
            // 
            // txtstemail
            // 
            txtstemail.Location = new Point(672, 124);
            txtstemail.Name = "txtstemail";
            txtstemail.Size = new Size(163, 29);
            txtstemail.TabIndex = 3;
            // 
            // dtstworkingday
            // 
            dtstworkingday.Location = new Point(672, 213);
            dtstworkingday.Name = "dtstworkingday";
            dtstworkingday.Size = new Size(200, 29);
            dtstworkingday.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtstid);
            groupBox1.Controls.Add(dtstworkingday);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtstposition);
            groupBox1.Controls.Add(txtstname);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtstemail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtstphonenumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 192, 192);
            groupBox1.Location = new Point(314, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(894, 257);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Information";
            // 
            // txtstposition
            // 
            txtstposition.Location = new Point(159, 205);
            txtstposition.Name = "txtstposition";
            txtstposition.Size = new Size(163, 29);
            txtstposition.TabIndex = 3;
            // 
            // Picture
            // 
            Picture.AutoSize = true;
            Picture.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Picture.Location = new Point(108, 132);
            Picture.Name = "Picture";
            Picture.Size = new Size(86, 30);
            Picture.TabIndex = 7;
            Picture.Text = "Picture";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(32, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 227);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.lovepik_yellow_up_arrow_png_image_401343788_wh1200;
            pictureBox4.Location = new Point(123, 397);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btnstsearch
            // 
            btnstsearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstsearch.Location = new Point(314, 397);
            btnstsearch.Name = "btnstsearch";
            btnstsearch.Size = new Size(75, 47);
            btnstsearch.TabIndex = 10;
            btnstsearch.Text = "Search";
            btnstsearch.UseVisualStyleBackColor = true;
            btnstsearch.Click += btnstsearch_Click;
            // 
            // btnstupdate
            // 
            btnstupdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstupdate.Location = new Point(525, 400);
            btnstupdate.Name = "btnstupdate";
            btnstupdate.Size = new Size(75, 47);
            btnstupdate.TabIndex = 10;
            btnstupdate.Text = "Update";
            btnstupdate.UseVisualStyleBackColor = true;
            btnstupdate.Click += btnstupdate_Click;
            // 
            // btnstadd
            // 
            btnstadd.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstadd.Location = new Point(720, 400);
            btnstadd.Name = "btnstadd";
            btnstadd.Size = new Size(75, 47);
            btnstadd.TabIndex = 10;
            btnstadd.Text = "Add";
            btnstadd.UseVisualStyleBackColor = true;
            btnstadd.Click += btnstadd_Click;
            // 
            // btnstdelete
            // 
            btnstdelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstdelete.Location = new Point(930, 400);
            btnstdelete.Name = "btnstdelete";
            btnstdelete.Size = new Size(75, 47);
            btnstdelete.TabIndex = 10;
            btnstdelete.Text = "Delete";
            btnstdelete.UseVisualStyleBackColor = true;
            btnstdelete.Click += btnstdelete_Click;
            // 
            // btnstupload
            // 
            btnstupload.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstupload.Location = new Point(1125, 400);
            btnstupload.Name = "btnstupload";
            btnstupload.Size = new Size(75, 47);
            btnstupload.TabIndex = 10;
            btnstupload.Text = "UpLoad";
            btnstupload.UseVisualStyleBackColor = true;
            btnstupload.Click += btnstupload_Click;
            // 
            // dgvstaff
            // 
            dgvstaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstaff.Location = new Point(314, 453);
            dgvstaff.Name = "dgvstaff";
            dgvstaff.Size = new Size(894, 188);
            dgvstaff.TabIndex = 11;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao2;
            pictureBox5.Location = new Point(2, 132);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1220, 495);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 629);
            Controls.Add(dgvstaff);
            Controls.Add(btnstupload);
            Controls.Add(btnstdelete);
            Controls.Add(btnstadd);
            Controls.Add(btnstupdate);
            Controls.Add(btnstsearch);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Picture);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnexit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox5);
            Name = "FormStaff";
            Text = "FormStaff";
            FormClosing += FormStaff_FormClosing;
            Load += FormStaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvstaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogout;
        private Button btnexit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtstid;
        private TextBox txtstname;
        private TextBox txtstphonenumber;
        private TextBox txtstemail;
        private DateTimePicker dtstworkingday;
        private GroupBox groupBox1;
        private Label Picture;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnstsearch;
        private Button btnstupdate;
        private Button btnstadd;
        private Button btnstdelete;
        private Button btnstupload;
        private DataGridView dgvstaff;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox txtstposition;
    }
}