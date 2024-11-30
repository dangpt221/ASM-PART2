namespace PTCar
{
    partial class FormInventory
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtitsearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            cbproductid = new ComboBox();
            txtitstockquantity = new TextBox();
            txtitstoredproducts = new TextBox();
            txtitwarehouselocation = new TextBox();
            txtitid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            dgvinventory = new DataGridView();
            btnitsearch = new Button();
            btnitadd = new Button();
            btnitupdate = new Button();
            btnitdelete = new Button();
            btnitupload = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.Vai_trò_của_nước_và_những_ảnh_hưởng_đối_với_con_người_xã_hội_1_1024x763;
            btnlogout.Location = new Point(-1, 589);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(120, 37);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            btnexit.ForeColor = Color.Red;
            btnexit.Image = Properties.Resources.Vai_trò_của_nước_và_những_ảnh_hưởng_đối_với_con_người_xã_hội_1_1024x763;
            btnexit.Location = new Point(189, 589);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(120, 37);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtitsearch);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 132);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox2.Location = new Point(1082, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Inventory;
            pictureBox1.Location = new Point(531, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtitsearch
            // 
            txtitsearch.Location = new Point(131, 71);
            txtitsearch.Name = "txtitsearch";
            txtitsearch.Size = new Size(270, 23);
            txtitsearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.Vai_trò_của_nước_và_những_ảnh_hưởng_đối_với_con_người_xã_hội_1_1024x763;
            label2.Location = new Point(505, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 50);
            label2.TabIndex = 0;
            label2.Text = "Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Vai_trò_của_nước_và_những_ảnh_hưởng_đối_với_con_người_xã_hội_1_1024x763;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1227, 132);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbproductid);
            groupBox1.Controls.Add(txtitstockquantity);
            groupBox1.Controls.Add(txtitstoredproducts);
            groupBox1.Controls.Add(txtitwarehouselocation);
            groupBox1.Controls.Add(txtitid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(311, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(915, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbproductid
            // 
            cbproductid.FormattingEnabled = true;
            cbproductid.Location = new Point(653, 162);
            cbproductid.Name = "cbproductid";
            cbproductid.Size = new Size(251, 29);
            cbproductid.TabIndex = 2;
            // 
            // txtitstockquantity
            // 
            txtitstockquantity.Location = new Point(178, 212);
            txtitstockquantity.Name = "txtitstockquantity";
            txtitstockquantity.Size = new Size(289, 29);
            txtitstockquantity.TabIndex = 1;
            // 
            // txtitstoredproducts
            // 
            txtitstoredproducts.Location = new Point(653, 78);
            txtitstoredproducts.Name = "txtitstoredproducts";
            txtitstoredproducts.Size = new Size(251, 29);
            txtitstoredproducts.TabIndex = 1;
            // 
            // txtitwarehouselocation
            // 
            txtitwarehouselocation.Location = new Point(178, 127);
            txtitwarehouselocation.Name = "txtitwarehouselocation";
            txtitwarehouselocation.Size = new Size(289, 29);
            txtitwarehouselocation.TabIndex = 1;
            // 
            // txtitid
            // 
            txtitid.Location = new Point(178, 49);
            txtitid.Name = "txtitid";
            txtitid.Size = new Size(289, 29);
            txtitid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 215);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 0;
            label5.Text = "Stock Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 0;
            label4.Text = "Ware House Location";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, 170);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 0;
            label7.Text = "ProductID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 86);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 0;
            label6.Text = "    Stored Products ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 52);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // dgvinventory
            // 
            dgvinventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinventory.Location = new Point(311, 451);
            dgvinventory.Name = "dgvinventory";
            dgvinventory.Size = new Size(915, 175);
            dgvinventory.TabIndex = 3;
            // 
            // btnitsearch
            // 
            btnitsearch.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnitsearch.Location = new Point(311, 405);
            btnitsearch.Name = "btnitsearch";
            btnitsearch.Size = new Size(75, 40);
            btnitsearch.TabIndex = 4;
            btnitsearch.Text = "Search";
            btnitsearch.UseVisualStyleBackColor = true;
            btnitsearch.Click += btnitsearch_Click;
            // 
            // btnitadd
            // 
            btnitadd.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnitadd.Location = new Point(517, 405);
            btnitadd.Name = "btnitadd";
            btnitadd.Size = new Size(75, 40);
            btnitadd.TabIndex = 4;
            btnitadd.Text = "Add";
            btnitadd.UseVisualStyleBackColor = true;
            btnitadd.Click += btnitadd_Click;
            // 
            // btnitupdate
            // 
            btnitupdate.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnitupdate.Location = new Point(732, 405);
            btnitupdate.Name = "btnitupdate";
            btnitupdate.Size = new Size(75, 40);
            btnitupdate.TabIndex = 4;
            btnitupdate.Text = "Update";
            btnitupdate.UseVisualStyleBackColor = true;
            btnitupdate.Click += btnitupdate_Click;
            // 
            // btnitdelete
            // 
            btnitdelete.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnitdelete.Location = new Point(928, 405);
            btnitdelete.Name = "btnitdelete";
            btnitdelete.Size = new Size(75, 40);
            btnitdelete.TabIndex = 4;
            btnitdelete.Text = "Delete";
            btnitdelete.UseVisualStyleBackColor = true;
            btnitdelete.Click += btnitdelete_Click;
            // 
            // btnitupload
            // 
            btnitupload.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnitupload.Location = new Point(1151, 405);
            btnitupload.Name = "btnitupload";
            btnitupload.Size = new Size(75, 40);
            btnitupload.TabIndex = 4;
            btnitupload.Text = "UpLoad";
            btnitupload.UseVisualStyleBackColor = true;
            btnitupload.Click += btnitupload_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Vai_trò_của_nước_và_những_ảnh_hưởng_đối_với_con_người_xã_hội_1_1024x763;
            pictureBox4.Location = new Point(2, 139);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1224, 487);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 628);
            Controls.Add(btnitupload);
            Controls.Add(btnitdelete);
            Controls.Add(btnitupdate);
            Controls.Add(btnitadd);
            Controls.Add(btnitsearch);
            Controls.Add(dgvinventory);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnexit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox4);
            Name = "FormInventory";
            Text = "FormInventory";
            FormClosing += FormInventory_FormClosing;
            Load += FormInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnexit;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox txtitsearch;
        private ComboBox cbproductid;
        private TextBox txtitstockquantity;
        private TextBox txtitstoredproducts;
        private TextBox txtitwarehouselocation;
        private TextBox txtitid;
        private DataGridView dgvinventory;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnitsearch;
        private Button btnitadd;
        private Button btnitupdate;
        private Button btnitdelete;
        private Button btnitupload;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}