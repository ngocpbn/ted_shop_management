namespace Windows_Form_Final___Tedshop_System.Views.Dashboard
{
    partial class DashboardUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUI));
            panel5 = new Panel();
            numberProduct = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            panel7 = new Panel();
            numberSupplier = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            panel6 = new Panel();
            numberUser = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Controls.Add(numberProduct);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(56, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 120);
            panel5.TabIndex = 1;
            // 
            // numberProduct
            // 
            numberProduct.AutoSize = true;
            numberProduct.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberProduct.ForeColor = Color.White;
            numberProduct.Location = new Point(19, 59);
            numberProduct.Name = "numberProduct";
            numberProduct.Size = new Size(0, 28);
            numberProduct.TabIndex = 3;
            numberProduct.Click += numberProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 50);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(136, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 70);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 15);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 0;
            label7.Text = "Product";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(46, 204, 113);
            panel7.Controls.Add(numberSupplier);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(367, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 120);
            panel7.TabIndex = 2;
            // 
            // numberSupplier
            // 
            numberSupplier.AutoSize = true;
            numberSupplier.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberSupplier.ForeColor = Color.White;
            numberSupplier.Location = new Point(23, 59);
            numberSupplier.Name = "numberSupplier";
            numberSupplier.Size = new Size(0, 28);
            numberSupplier.TabIndex = 4;
            numberSupplier.Click += numberSupplier_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(136, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 70);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 15);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 0;
            label8.Text = "Supplier";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(243, 156, 18);
            panel6.Controls.Add(numberUser);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(667, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(243, 120);
            panel6.TabIndex = 3;
            // 
            // numberUser
            // 
            numberUser.AutoSize = true;
            numberUser.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberUser.ForeColor = Color.White;
            numberUser.Location = new Point(33, 59);
            numberUser.Name = "numberUser";
            numberUser.Size = new Size(0, 28);
            numberUser.TabIndex = 5;
            numberUser.Click += numberUser_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(136, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(116, 70);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(33, 15);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 0;
            label9.Text = "User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 8);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 172, 220);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 202);
            panel2.TabIndex = 5;
            // 
            // DashboardUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 210);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardUI";
            Text = "DashboardUI";
            TopMost = true;
            Load += DashboardUI_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label numberProduct;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label7;
        private Panel panel7;
        private Label numberSupplier;
        private PictureBox pictureBox4;
        private Label label8;
        private Panel panel6;
        private Label numberUser;
        private PictureBox pictureBox5;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
    }
}