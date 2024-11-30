namespace PTCar
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            btnlogout = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            txtodsearch = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            dtoddate = new DateTimePicker();
            txtodname = new TextBox();
            txtodid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnodsearch = new Button();
            btnodadd = new Button();
            btnodupdate = new Button();
            btnodupload = new Button();
            dgvorder = new DataGridView();
            pictureBox3 = new PictureBox();
            btnoddelete = new Button();
            txtodproductlist = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_nen_may_tinh_4k_50;
            btnlogout.Location = new Point(0, 594);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(90, 35);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(255, 128, 128);
            btnExit.Image = Properties.Resources.hinh_nen_may_tinh_4k_50;
            btnExit.Location = new Point(138, 594);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 35);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtodsearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 107);
            panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox4.Location = new Point(1072, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // txtodsearch
            // 
            txtodsearch.Location = new Point(109, 64);
            txtodsearch.Name = "txtodsearch";
            txtodsearch.Size = new Size(235, 23);
            txtodsearch.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Order;
            pictureBox1.Location = new Point(561, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(551, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 50);
            label2.TabIndex = 0;
            label2.Text = "Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 64);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1215, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtoddate);
            groupBox1.Controls.Add(txtodproductlist);
            groupBox1.Controls.Add(txtodname);
            groupBox1.Controls.Add(txtodid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(395, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 274);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Information";
            // 
            // dtoddate
            // 
            dtoddate.Location = new Point(542, 48);
            dtoddate.Name = "dtoddate";
            dtoddate.Size = new Size(239, 29);
            dtoddate.TabIndex = 2;
            // 
            // txtodname
            // 
            txtodname.Location = new Point(166, 168);
            txtodname.Name = "txtodname";
            txtodname.Size = new Size(210, 29);
            txtodname.TabIndex = 1;
            // 
            // txtodid
            // 
            txtodid.Location = new Point(166, 53);
            txtodid.Name = "txtodid";
            txtodid.Size = new Size(210, 29);
            txtodid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 176);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 0;
            label5.Text = "Product List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 168);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 53);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 0;
            label6.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 54);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // btnodsearch
            // 
            btnodsearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnodsearch.Location = new Point(395, 407);
            btnodsearch.Name = "btnodsearch";
            btnodsearch.Size = new Size(75, 39);
            btnodsearch.TabIndex = 3;
            btnodsearch.Text = "Search";
            btnodsearch.UseVisualStyleBackColor = true;
            btnodsearch.Click += btnodsearch_Click;
            // 
            // btnodadd
            // 
            btnodadd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnodadd.Location = new Point(586, 407);
            btnodadd.Name = "btnodadd";
            btnodadd.Size = new Size(75, 39);
            btnodadd.TabIndex = 3;
            btnodadd.Text = "Add";
            btnodadd.UseVisualStyleBackColor = true;
            btnodadd.Click += btnodadd_Click;
            // 
            // btnodupdate
            // 
            btnodupdate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnodupdate.Location = new Point(768, 407);
            btnodupdate.Name = "btnodupdate";
            btnodupdate.Size = new Size(85, 39);
            btnodupdate.TabIndex = 3;
            btnodupdate.Text = "Update";
            btnodupdate.UseVisualStyleBackColor = true;
            btnodupdate.Click += btnodupdate_Click;
            // 
            // btnodupload
            // 
            btnodupload.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnodupload.Location = new Point(1135, 407);
            btnodupload.Name = "btnodupload";
            btnodupload.Size = new Size(83, 39);
            btnodupload.TabIndex = 3;
            btnodupload.Text = "UpLoad";
            btnodupload.UseVisualStyleBackColor = true;
            btnodupload.Click += btnodupload_Click;
            // 
            // dgvorder
            // 
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Location = new Point(234, 452);
            dgvorder.Name = "dgvorder";
            dgvorder.Size = new Size(984, 177);
            dgvorder.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1218, 517);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btnoddelete
            // 
            btnoddelete.AutoEllipsis = true;
            btnoddelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnoddelete.Location = new Point(961, 407);
            btnoddelete.Name = "btnoddelete";
            btnoddelete.Size = new Size(75, 39);
            btnoddelete.TabIndex = 3;
            btnoddelete.Text = "Delete";
            btnoddelete.UseVisualStyleBackColor = true;
            btnoddelete.Click += btnoddelete_Click;
            // 
            // txtodproductlist
            // 
            txtodproductlist.Location = new Point(542, 165);
            txtodproductlist.Name = "txtodproductlist";
            txtodproductlist.Size = new Size(239, 29);
            txtodproductlist.TabIndex = 1;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 629);
            Controls.Add(dgvorder);
            Controls.Add(btnodupload);
            Controls.Add(btnoddelete);
            Controls.Add(btnodupdate);
            Controls.Add(btnodadd);
            Controls.Add(btnodsearch);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox3);
            Name = "FormOrder";
            Text = "FormOrder";
            FormClosing += FormOrder_FormClosing;
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnExit;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Button btnodsearch;
        private Button btnodadd;
        private Button btnodupdate;
        private Button btnodupload;
        private PictureBox pictureBox1;
        private TextBox txtodsearch;
        private TextBox txtodid;
        private TextBox txtodname;
        private DateTimePicker dtoddate;
        private DataGridView dgvorder;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnoddelete;
        private TextBox txtodproductlist;
    }
}