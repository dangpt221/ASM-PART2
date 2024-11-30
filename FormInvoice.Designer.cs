namespace PTCar
{
    partial class FormInvoice
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
            btnExit = new Button();
            btnlogout = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtivsearch = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            dtivdate = new DateTimePicker();
            txtivtotalamount = new TextBox();
            txtivpaymentmehtod = new TextBox();
            txtivlistproduct = new TextBox();
            txtivname = new TextBox();
            txtivid = new TextBox();
            label7 = new Label();
            label2 = new Label();
            labtotalamount = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtpdtotalamount = new TextBox();
            txtpdquantity = new TextBox();
            txtpdname = new TextBox();
            txtpdid = new TextBox();
            txtpdprice = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label17 = new Label();
            label10 = new Label();
            dgvinvoice = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label12 = new Label();
            txtivpayment = new TextBox();
            txtivmoneygiven = new TextBox();
            txtivmoneyleft = new TextBox();
            label15 = new Label();
            label16 = new Label();
            btnivexportbill = new Button();
            pictureBox4 = new PictureBox();
            btnivadd = new Button();
            button9 = new Button();
            btnivupload = new Button();
            btnivupdate = new Button();
            btnivsearch = new Button();
            btnivad = new Button();
            btnivdelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnExit.ForeColor = Color.FromArgb(255, 128, 128);
            btnExit.Image = Properties.Resources.hinh_nen_powerpoint_mau_sang_sang_trong_1_0930193953;
            btnExit.Location = new Point(306, 593);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 32);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnlogout.ForeColor = Color.FromArgb(255, 255, 128);
            btnlogout.Image = Properties.Resources.hinh_nen_may_tinh_4k_152;
            btnlogout.Location = new Point(90, 593);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(92, 31);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtivsearch);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 127);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox2.Location = new Point(1064, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Invoice;
            pictureBox1.Location = new Point(582, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtivsearch
            // 
            txtivsearch.Location = new Point(114, 69);
            txtivsearch.Name = "txtivsearch";
            txtivsearch.Size = new Size(378, 23);
            txtivsearch.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 71);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 5;
            label9.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Image = Properties.Resources.hinh_nen_powerpoint_mau_sang_sang_trong_1_0930193954;
            label8.Location = new Point(560, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 45);
            label8.TabIndex = 4;
            label8.Text = "Invoice";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(797, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Invoice Information";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hinh_nen_powerpoint_mau_sang_sang_trong_1_093019395;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1221, 124);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtivdate);
            groupBox2.Controls.Add(txtivtotalamount);
            groupBox2.Controls.Add(txtivpaymentmehtod);
            groupBox2.Controls.Add(txtivlistproduct);
            groupBox2.Controls.Add(txtivname);
            groupBox2.Controls.Add(txtivid);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(labtotalamount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(597, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(628, 209);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Invoice Information";
            // 
            // dtivdate
            // 
            dtivdate.Location = new Point(58, 153);
            dtivdate.Name = "dtivdate";
            dtivdate.Size = new Size(224, 29);
            dtivdate.TabIndex = 2;
            // 
            // txtivtotalamount
            // 
            txtivtotalamount.Location = new Point(432, 145);
            txtivtotalamount.Name = "txtivtotalamount";
            txtivtotalamount.Size = new Size(190, 29);
            txtivtotalamount.TabIndex = 1;
            // 
            // txtivpaymentmehtod
            // 
            txtivpaymentmehtod.Location = new Point(435, 28);
            txtivpaymentmehtod.Name = "txtivpaymentmehtod";
            txtivpaymentmehtod.Size = new Size(190, 29);
            txtivpaymentmehtod.TabIndex = 1;
            // 
            // txtivlistproduct
            // 
            txtivlistproduct.Location = new Point(435, 87);
            txtivlistproduct.Name = "txtivlistproduct";
            txtivlistproduct.Size = new Size(190, 29);
            txtivlistproduct.TabIndex = 1;
            // 
            // txtivname
            // 
            txtivname.Location = new Point(92, 87);
            txtivname.Name = "txtivname";
            txtivname.Size = new Size(190, 29);
            txtivname.TabIndex = 1;
            // 
            // txtivid
            // 
            txtivid.Location = new Point(94, 29);
            txtivid.Name = "txtivid";
            txtivid.Size = new Size(190, 29);
            txtivid.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 159);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 0;
            label7.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // labtotalamount
            // 
            labtotalamount.AutoSize = true;
            labtotalamount.Location = new Point(288, 153);
            labtotalamount.Name = "labtotalamount";
            labtotalamount.Size = new Size(119, 21);
            labtotalamount.TabIndex = 0;
            labtotalamount.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 95);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 0;
            label5.Text = "List Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 36);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 0;
            label3.Text = "PaymentMethod";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 95);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtpdtotalamount);
            groupBox3.Controls.Add(txtpdquantity);
            groupBox3.Controls.Add(txtpdname);
            groupBox3.Controls.Add(txtpdid);
            groupBox3.Controls.Add(txtpdprice);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(4, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(573, 209);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product";
            // 
            // txtpdtotalamount
            // 
            txtpdtotalamount.Location = new Point(407, 122);
            txtpdtotalamount.Name = "txtpdtotalamount";
            txtpdtotalamount.Size = new Size(160, 29);
            txtpdtotalamount.TabIndex = 2;
            // 
            // txtpdquantity
            // 
            txtpdquantity.Location = new Point(86, 130);
            txtpdquantity.Name = "txtpdquantity";
            txtpdquantity.Size = new Size(145, 29);
            txtpdquantity.TabIndex = 2;
            // 
            // txtpdname
            // 
            txtpdname.Location = new Point(86, 87);
            txtpdname.Name = "txtpdname";
            txtpdname.Size = new Size(145, 29);
            txtpdname.TabIndex = 1;
            // 
            // txtpdid
            // 
            txtpdid.Location = new Point(86, 43);
            txtpdid.Name = "txtpdid";
            txtpdid.Size = new Size(145, 29);
            txtpdid.TabIndex = 1;
            // 
            // txtpdprice
            // 
            txtpdprice.Location = new Point(407, 39);
            txtpdprice.Name = "txtpdprice";
            txtpdprice.Size = new Size(160, 29);
            txtpdprice.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(295, 42);
            label14.Name = "label14";
            label14.Size = new Size(50, 21);
            label14.TabIndex = 0;
            label14.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(0, 138);
            label13.Name = "label13";
            label13.Size = new Size(80, 21);
            label13.TabIndex = 0;
            label13.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(286, 130);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 0;
            label11.Text = "TotalAmount";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 95);
            label17.Name = "label17";
            label17.Size = new Size(57, 21);
            label17.TabIndex = 0;
            label17.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 46);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 0;
            label10.Text = "ID";
            // 
            // dgvinvoice
            // 
            dgvinvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinvoice.Location = new Point(597, 399);
            dgvinvoice.Name = "dgvinvoice";
            dgvinvoice.Size = new Size(628, 236);
            dgvinvoice.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(32, 381);
            label12.Name = "label12";
            label12.Size = new Size(81, 21);
            label12.TabIndex = 0;
            label12.Text = "Payment";
            // 
            // txtivpayment
            // 
            txtivpayment.Location = new Point(163, 379);
            txtivpayment.Name = "txtivpayment";
            txtivpayment.Size = new Size(160, 23);
            txtivpayment.TabIndex = 2;
            // 
            // txtivmoneygiven
            // 
            txtivmoneygiven.Location = new Point(163, 431);
            txtivmoneygiven.Name = "txtivmoneygiven";
            txtivmoneygiven.Size = new Size(160, 23);
            txtivmoneygiven.TabIndex = 7;
            // 
            // txtivmoneyleft
            // 
            txtivmoneyleft.Location = new Point(163, 477);
            txtivmoneyleft.Name = "txtivmoneyleft";
            txtivmoneyleft.Size = new Size(160, 23);
            txtivmoneyleft.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(32, 431);
            label15.Name = "label15";
            label15.Size = new Size(113, 21);
            label15.TabIndex = 0;
            label15.Text = "Money Given";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(32, 479);
            label16.Name = "label16";
            label16.Size = new Size(100, 21);
            label16.TabIndex = 0;
            label16.Text = "Money Left";
            // 
            // btnivexportbill
            // 
            btnivexportbill.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivexportbill.Location = new Point(190, 525);
            btnivexportbill.Name = "btnivexportbill";
            btnivexportbill.Size = new Size(104, 32);
            btnivexportbill.TabIndex = 8;
            btnivexportbill.Text = "ExportBill";
            btnivexportbill.UseVisualStyleBackColor = true;
            btnivexportbill.Click += btnivexportbill_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hinh_nen_powerpoint_mau_sang_sang_trong_1_0930193951;
            pictureBox4.Location = new Point(4, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1221, 504);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btnivadd
            // 
            btnivadd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivadd.Location = new Point(691, 349);
            btnivadd.Name = "btnivadd";
            btnivadd.Size = new Size(75, 33);
            btnivadd.TabIndex = 10;
            btnivadd.Text = "Add";
            btnivadd.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button9.Location = new Point(806, 349);
            button9.Name = "button9";
            button9.Size = new Size(75, 33);
            button9.TabIndex = 10;
            button9.Text = "Update";
            button9.UseVisualStyleBackColor = true;
            // 
            // btnivupload
            // 
            btnivupload.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivupload.Location = new Point(1141, 358);
            btnivupload.Name = "btnivupload";
            btnivupload.Size = new Size(81, 33);
            btnivupload.TabIndex = 10;
            btnivupload.Text = "UpLoad";
            btnivupload.UseVisualStyleBackColor = true;
            btnivupload.Click += btnivupload_Click;
            // 
            // btnivupdate
            // 
            btnivupdate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivupdate.Location = new Point(725, 356);
            btnivupdate.Name = "btnivupdate";
            btnivupdate.Size = new Size(84, 37);
            btnivupdate.TabIndex = 11;
            btnivupdate.Text = "Update";
            btnivupdate.UseVisualStyleBackColor = true;
            btnivupdate.Click += btnivupdate_Click;
            // 
            // btnivsearch
            // 
            btnivsearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivsearch.Location = new Point(597, 356);
            btnivsearch.Name = "btnivsearch";
            btnivsearch.Size = new Size(75, 37);
            btnivsearch.TabIndex = 11;
            btnivsearch.Text = "Search";
            btnivsearch.UseVisualStyleBackColor = true;
            btnivsearch.Click += btnivsearch_Click;
            // 
            // btnivad
            // 
            btnivad.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivad.Location = new Point(868, 356);
            btnivad.Name = "btnivad";
            btnivad.Size = new Size(75, 37);
            btnivad.TabIndex = 12;
            btnivad.Text = "Add";
            btnivad.UseVisualStyleBackColor = true;
            btnivad.Click += btnivad_Click;
            // 
            // btnivdelete
            // 
            btnivdelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnivdelete.Location = new Point(1002, 356);
            btnivdelete.Name = "btnivdelete";
            btnivdelete.Size = new Size(75, 37);
            btnivdelete.TabIndex = 14;
            btnivdelete.Text = "Delete";
            btnivdelete.UseVisualStyleBackColor = true;
            btnivdelete.Click += btnivdelete_Click;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 628);
            Controls.Add(btnivdelete);
            Controls.Add(btnivad);
            Controls.Add(btnivsearch);
            Controls.Add(btnivupdate);
            Controls.Add(btnivupload);
            Controls.Add(btnivexportbill);
            Controls.Add(txtivmoneyleft);
            Controls.Add(txtivmoneygiven);
            Controls.Add(txtivpayment);
            Controls.Add(dgvinvoice);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(btnlogout);
            Controls.Add(btnExit);
            Controls.Add(pictureBox4);
            Name = "FormInvoice";
            Text = "FormInvoice";
            FormClosing += FormInvoice_FormClosing;
            Load += FormInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvinvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnlogout;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dgvinvoice;
        private Label label2;
        private Label labtotalamount;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtivsearch;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private DateTimePicker dtivdate;
        private TextBox textBox4;
        private TextBox txtivpaymentmehtod;
        private TextBox txtivname;
        private TextBox txtivid;
        private TextBox txtpdid;
        private TextBox txtpdtotalamount;
        private TextBox txtpdquantity;
        private TextBox txtpdprice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label12;
        private TextBox txtivpayment;
        private TextBox txtivmoneygiven;
        private TextBox txtivmoneyleft;
        private Label label15;
        private Label label16;
        private Label label5;
        private TextBox txtpdname;
        private Label label17;
        private Button btnivexportbill;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button7;
        private Button btnivadd;
        private Button button9;
        private Button btnivupload;
        private PictureBox pictureBox5;
        private Button button10;
        private Button btnivupdate;
        private Button btnivsearch;
        private Button btnivad;
        private Button btnivdelete;
        private TextBox txtivtotalamount;
        private TextBox txtivlistproduct;
    }
}