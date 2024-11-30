namespace PTCar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnclear = new Button();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            label1.Location = new Point(533, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 55);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(266, 156);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao1;
            label3.Location = new Point(266, 269);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 0;
            label3.Text = "PassWord";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(409, 154);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(448, 23);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(409, 267);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(448, 23);
            txtpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(192, 255, 192);
            btnlogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.Lime;
            btnlogin.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            btnlogin.Location = new Point(409, 417);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 48);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(192, 255, 255);
            btnclear.Font = new Font("Broadway", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.Cyan;
            btnclear.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            btnclear.Location = new Point(601, 417);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 48);
            btnclear.TabIndex = 2;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(255, 128, 128);
            btnexit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.Red;
            btnexit.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            btnexit.Location = new Point(782, 417);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 48);
            btnexit.TabIndex = 2;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1233, 605);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackgroundImage = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.png_clipart_preventive_maintenance_car_toyota_service_car_transport_auto_mechanic1;
            pictureBox3.Location = new Point(889, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.hinh_anh_anime_phong_canh_huyen_ao;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.pngtree_lock_password_encryption_account_security_login_icon_icon_png_image_3422749;
            pictureBox4.Location = new Point(889, 254);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 606);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnclear;
        private Button btnexit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
