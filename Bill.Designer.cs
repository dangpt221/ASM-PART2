namespace PTCar
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            labproduct = new Label();
            label2 = new Label();
            labQuantity = new Label();
            labprice = new Label();
            labdatatime = new Label();
            labpayment = new Label();
            labmoneygiven = new Label();
            labmoneyleft = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labproduct
            // 
            labproduct.AutoSize = true;
            labproduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labproduct.Location = new Point(187, 154);
            labproduct.Name = "labproduct";
            labproduct.Size = new Size(71, 21);
            labproduct.TabIndex = 1;
            labproduct.Text = "Product:";
            labproduct.Click += labproduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(588, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 50);
            label2.TabIndex = 1;
            label2.Text = "Bill";
            // 
            // labQuantity
            // 
            labQuantity.AutoSize = true;
            labQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labQuantity.Location = new Point(187, 225);
            labQuantity.Name = "labQuantity";
            labQuantity.Size = new Size(81, 21);
            labQuantity.TabIndex = 1;
            labQuantity.Text = "Quantity:";
            // 
            // labprice
            // 
            labprice.AutoSize = true;
            labprice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labprice.Location = new Point(187, 310);
            labprice.Name = "labprice";
            labprice.Size = new Size(50, 21);
            labprice.TabIndex = 1;
            labprice.Text = "Price:";
            // 
            // labdatatime
            // 
            labdatatime.AutoSize = true;
            labdatatime.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labdatatime.Location = new Point(187, 381);
            labdatatime.Name = "labdatatime";
            labdatatime.Size = new Size(90, 21);
            labdatatime.TabIndex = 1;
            labdatatime.Text = "Date Time:";
            // 
            // labpayment
            // 
            labpayment.AutoSize = true;
            labpayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labpayment.Location = new Point(187, 460);
            labpayment.Name = "labpayment";
            labpayment.Size = new Size(81, 21);
            labpayment.TabIndex = 1;
            labpayment.Text = "Payment:";
            // 
            // labmoneygiven
            // 
            labmoneygiven.AutoSize = true;
            labmoneygiven.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labmoneygiven.Location = new Point(869, 139);
            labmoneygiven.Name = "labmoneygiven";
            labmoneygiven.Size = new Size(109, 21);
            labmoneygiven.TabIndex = 2;
            labmoneygiven.Text = "Money given:";
            // 
            // labmoneyleft
            // 
            labmoneyleft.AutoSize = true;
            labmoneyleft.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labmoneyleft.Location = new Point(869, 225);
            labmoneyleft.Name = "labmoneyleft";
            labmoneyleft.Size = new Size(96, 21);
            labmoneyleft.TabIndex = 3;
            labmoneyleft.Text = "Money Left:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_FPT_BTEC;
            pictureBox1.Location = new Point(1050, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1244, 594);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 586);
            Controls.Add(pictureBox1);
            Controls.Add(labmoneyleft);
            Controls.Add(labmoneygiven);
            Controls.Add(label2);
            Controls.Add(labpayment);
            Controls.Add(labdatatime);
            Controls.Add(labprice);
            Controls.Add(labQuantity);
            Controls.Add(labproduct);
            Controls.Add(pictureBox2);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labproduct;
        private Label label2;
        private Label labQuantity;
        private Label labprice;
        private Label labdatatime;
        private Label labpayment;
        private Label labmoneygiven;
        private Label labmoneyleft;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}