namespace PTCar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnlogout = new Button();
            btnexit = new Button();
            btnorder = new Button();
            labautopartsstore = new Label();
            labhome = new Label();
            panel1 = new Panel();
            pictureBox14 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnstaff = new Button();
            btninvoice = new Button();
            btnproduct = new Button();
            btncustomer = new Button();
            btninventory = new Button();
            btnsupplier = new Button();
            pictureBox7 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(255, 255, 192);
            btnlogout.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(964, 600);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(119, 40);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(255, 128, 128);
            btnexit.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(1106, 600);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(119, 40);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnorder
            // 
            btnorder.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnorder.ImageAlign = ContentAlignment.TopRight;
            btnorder.Location = new Point(3, 188);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(135, 69);
            btnorder.TabIndex = 1;
            btnorder.Text = "Order";
            btnorder.TextAlign = ContentAlignment.MiddleLeft;
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // labautopartsstore
            // 
            labautopartsstore.AutoSize = true;
            labautopartsstore.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labautopartsstore.ForeColor = Color.Red;
            labautopartsstore.Image = (Image)resources.GetObject("labautopartsstore.Image");
            labautopartsstore.Location = new Point(297, 27);
            labautopartsstore.Name = "labautopartsstore";
            labautopartsstore.Size = new Size(527, 86);
            labautopartsstore.TabIndex = 2;
            labautopartsstore.Text = "Auto Parts Store";
            // 
            // labhome
            // 
            labhome.AutoSize = true;
            labhome.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labhome.ForeColor = Color.DeepSkyBlue;
            labhome.Location = new Point(623, 12);
            labhome.Name = "labhome";
            labhome.Size = new Size(125, 44);
            labhome.TabIndex = 3;
            labhome.Text = "HOME";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox14);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labhome);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 101);
            panel1.TabIndex = 4;
            // 
            // pictureBox14
            // 
            pictureBox14.BorderStyle = BorderStyle.FixedSingle;
            pictureBox14.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox14.Location = new Point(1079, 0);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(137, 101);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 8;
            pictureBox14.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_sitting_in_front_of_the_computer_troubled_man_png_image_3230127;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(132, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 136);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(132, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1084, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(labautopartsstore);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(144, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 144);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1084, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.phu_tung_o_to;
            pictureBox4.Location = new Point(144, 263);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1084, 377);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            pictureBox5.Location = new Point(3, 113);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(135, 527);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.pngtree_office_worker_sven_boy_cute_cartoon_boy_with_a_briefcase_png_image_38483632;
            pictureBox6.Location = new Point(3, 119);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // btnstaff
            // 
            btnstaff.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstaff.ImageAlign = ContentAlignment.TopRight;
            btnstaff.Location = new Point(3, 113);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(135, 69);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Staff";
            btnstaff.TextAlign = ContentAlignment.MiddleLeft;
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // btninvoice
            // 
            btninvoice.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btninvoice.ImageAlign = ContentAlignment.TopRight;
            btninvoice.Location = new Point(3, 263);
            btninvoice.Name = "btninvoice";
            btninvoice.Size = new Size(135, 69);
            btninvoice.TabIndex = 1;
            btninvoice.Text = "Invoice";
            btninvoice.TextAlign = ContentAlignment.MiddleLeft;
            btninvoice.UseVisualStyleBackColor = true;
            btninvoice.Click += btninvoice_Click;
            // 
            // btnproduct
            // 
            btnproduct.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnproduct.ImageAlign = ContentAlignment.TopRight;
            btnproduct.Location = new Point(3, 338);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(135, 69);
            btnproduct.TabIndex = 1;
            btnproduct.Text = "Product";
            btnproduct.TextAlign = ContentAlignment.MiddleLeft;
            btnproduct.UseVisualStyleBackColor = true;
            btnproduct.Click += btncustomer_Click;
            // 
            // btncustomer
            // 
            btncustomer.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btncustomer.ImageAlign = ContentAlignment.TopRight;
            btncustomer.Location = new Point(3, 413);
            btncustomer.Name = "btncustomer";
            btncustomer.Size = new Size(135, 69);
            btncustomer.TabIndex = 1;
            btncustomer.Text = "Customer";
            btncustomer.TextAlign = ContentAlignment.MiddleLeft;
            btncustomer.UseVisualStyleBackColor = true;
            btncustomer.Click += button3_Click;
            // 
            // btninventory
            // 
            btninventory.Font = new Font("Broadway", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btninventory.ImageAlign = ContentAlignment.TopRight;
            btninventory.Location = new Point(3, 488);
            btninventory.Name = "btninventory";
            btninventory.Size = new Size(135, 69);
            btninventory.TabIndex = 1;
            btninventory.Text = "Inventory";
            btninventory.TextAlign = ContentAlignment.MiddleLeft;
            btninventory.UseVisualStyleBackColor = true;
            btninventory.Click += btninventory_Click;
            // 
            // btnsupplier
            // 
            btnsupplier.Font = new Font("Broadway", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsupplier.ImageAlign = ContentAlignment.TopRight;
            btnsupplier.Location = new Point(3, 563);
            btnsupplier.Name = "btnsupplier";
            btnsupplier.Size = new Size(135, 69);
            btnsupplier.TabIndex = 1;
            btnsupplier.Text = "Supplier";
            btnsupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnsupplier.UseVisualStyleBackColor = true;
            btnsupplier.Click += btnsupplier_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(86, 188);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 69);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.Image = Properties.Resources.pngtree_office_worker_sven_boy_cute_cartoon_boy_with_a_briefcase_png_image_38483633;
            pictureBox10.Location = new Point(86, 116);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(52, 66);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox8_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(86, 263);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(52, 66);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(86, 338);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(52, 66);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox8_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(86, 416);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(52, 66);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 9;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox8_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(86, 566);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(52, 66);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 9;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox8_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(86, 488);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(52, 66);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 9;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox8_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 644);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox7);
            Controls.Add(btnstaff);
            Controls.Add(btnsupplier);
            Controls.Add(btninventory);
            Controls.Add(btncustomer);
            Controls.Add(btnproduct);
            Controls.Add(btninvoice);
            Controls.Add(btnorder);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnexit);
            Controls.Add(btnlogout);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Name = "Main";
            Text = "Main";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
        private Button btnexit;
        private Button btnorder;
        private Label labautopartsstore;
        private Label labhome;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnstaff;
        private Button btninvoice;
        private Button btnproduct;
        private Button btncustomer;
        private Button btninventory;
        private Button btnsupplier;
        private PictureBox pictureBox7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
    }
}