namespace PTCar
{
    partial class FormProduct
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
            components = new System.ComponentModel.Container();
            btnlogout = new Button();
            btnexit = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtpdsearch = new TextBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            txtpddescription = new TextBox();
            txtpdprice = new TextBox();
            txtpdname = new TextBox();
            txtpdquantity = new TextBox();
            txtpdid = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnpdsearch = new Button();
            btnpdadd = new Button();
            btnpdupdate = new Button();
            btnpddelete = new Button();
            btnpdupload = new Button();
            dgvproduct = new DataGridView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_nen_xanh_duong_0929102131;
            btnlogout.Location = new Point(0, 591);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(96, 36);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log  Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnexit.ForeColor = Color.FromArgb(255, 128, 128);
            btnexit.Image = Properties.Resources.hinh_nen_xanh_duong_0929102133;
            btnexit.Location = new Point(119, 591);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(96, 36);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.hinh_nen_xanh_duong_092910213;
            label2.Location = new Point(573, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 50);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtpdsearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 123);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox2.Location = new Point(1089, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.Product;
            pictureBox1.Location = new Point(573, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtpdsearch
            // 
            txtpdsearch.Location = new Point(111, 64);
            txtpdsearch.Name = "txtpdsearch";
            txtpdsearch.Size = new Size(225, 23);
            txtpdsearch.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hinh_nen_xanh_duong_0929102132;
            pictureBox3.Location = new Point(3, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1222, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtpddescription);
            groupBox1.Controls.Add(txtpdprice);
            groupBox1.Controls.Add(txtpdname);
            groupBox1.Controls.Add(txtpdquantity);
            groupBox1.Controls.Add(txtpdid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(434, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 221);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Information";
            // 
            // txtpddescription
            // 
            txtpddescription.Location = new Point(139, 171);
            txtpddescription.Name = "txtpddescription";
            txtpddescription.Size = new Size(229, 29);
            txtpddescription.TabIndex = 1;
            // 
            // txtpdprice
            // 
            txtpdprice.Location = new Point(512, 98);
            txtpdprice.Name = "txtpdprice";
            txtpdprice.Size = new Size(229, 29);
            txtpdprice.TabIndex = 1;
            // 
            // txtpdname
            // 
            txtpdname.Location = new Point(139, 98);
            txtpdname.Name = "txtpdname";
            txtpdname.Size = new Size(229, 29);
            txtpdname.TabIndex = 1;
            // 
            // txtpdquantity
            // 
            txtpdquantity.Location = new Point(512, 30);
            txtpdquantity.Name = "txtpdquantity";
            txtpdquantity.Size = new Size(229, 29);
            txtpdquantity.TabIndex = 1;
            // 
            // txtpdid
            // 
            txtpdid.Location = new Point(139, 38);
            txtpdid.Name = "txtpdid";
            txtpdid.Size = new Size(229, 29);
            txtpdid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 179);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 0;
            label5.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 106);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 0;
            label7.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 106);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 38);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 0;
            label6.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // btnpdsearch
            // 
            btnpdsearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnpdsearch.Location = new Point(434, 370);
            btnpdsearch.Name = "btnpdsearch";
            btnpdsearch.Size = new Size(75, 41);
            btnpdsearch.TabIndex = 5;
            btnpdsearch.Text = "Search";
            btnpdsearch.UseVisualStyleBackColor = true;
            btnpdsearch.Click += btnpdsearch_Click;
            // 
            // btnpdadd
            // 
            btnpdadd.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnpdadd.Location = new Point(608, 370);
            btnpdadd.Name = "btnpdadd";
            btnpdadd.Size = new Size(75, 41);
            btnpdadd.TabIndex = 5;
            btnpdadd.Text = "Add";
            btnpdadd.UseVisualStyleBackColor = true;
            btnpdadd.Click += btnpdadd_Click;
            // 
            // btnpdupdate
            // 
            btnpdupdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnpdupdate.Location = new Point(789, 370);
            btnpdupdate.Name = "btnpdupdate";
            btnpdupdate.Size = new Size(75, 41);
            btnpdupdate.TabIndex = 5;
            btnpdupdate.Text = "Update";
            btnpdupdate.UseVisualStyleBackColor = true;
            btnpdupdate.Click += btnpdupdate_Click;
            // 
            // btnpddelete
            // 
            btnpddelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnpddelete.Location = new Point(972, 370);
            btnpddelete.Name = "btnpddelete";
            btnpddelete.Size = new Size(75, 41);
            btnpddelete.TabIndex = 5;
            btnpddelete.Text = "Delete";
            btnpddelete.UseVisualStyleBackColor = true;
            btnpddelete.Click += btnpddelete_Click;
            // 
            // btnpdupload
            // 
            btnpdupload.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnpdupload.Location = new Point(1150, 370);
            btnpdupload.Name = "btnpdupload";
            btnpdupload.Size = new Size(75, 41);
            btnpdupload.TabIndex = 5;
            btnpdupload.Text = "UpLoad";
            btnpdupload.UseVisualStyleBackColor = true;
            btnpdupload.Click += btnpdupload_Click;
            // 
            // dgvproduct
            // 
            dgvproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproduct.Location = new Point(221, 417);
            dgvproduct.Name = "dgvproduct";
            dgvproduct.Size = new Size(1002, 210);
            dgvproduct.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hinh_nen_xanh_duong_0929102133;
            pictureBox4.Location = new Point(0, 123);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1225, 504);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Den_ba_do_xoc_sau_Trailblazer_52117538_52048954_52117539_1__1_;
            pictureBox5.Location = new Point(119, 141);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(190, 146);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 627);
            Controls.Add(pictureBox5);
            Controls.Add(dgvproduct);
            Controls.Add(btnpdupload);
            Controls.Add(btnpdupdate);
            Controls.Add(btnpddelete);
            Controls.Add(btnpdadd);
            Controls.Add(btnpdsearch);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnexit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox4);
            Name = "FormProduct";
            Text = "FormProduct";
            FormClosing += FormProduct_FormClosing;
            Load += FormProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnexit;
        private ImageList imageList1;
        private ImageList imageList2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Button btnpdsearch;
        private Button btnpdadd;
        private Button btnpdupdate;
        private Button btnpddelete;
        private Button btnpdupload;
        private DataGridView dgvproduct;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtpdsearch;
        private TextBox txtpddescription;
        private TextBox txtpdprice;
        private TextBox txtpdname;
        private TextBox txtpdquantity;
        private TextBox txtpdid;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}