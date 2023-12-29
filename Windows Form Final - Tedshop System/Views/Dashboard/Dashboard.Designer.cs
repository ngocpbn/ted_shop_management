namespace Windows_Form_Final___Tedshop_System.Views.Dashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            label3 = new Label();
            BtnClose = new PictureBox();
            panel3 = new Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnHelp = new Guna.UI2.WinForms.Guna2Button();
            btnSuplier = new Guna.UI2.WinForms.Guna2Button();
            btnProducts = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BtnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1190, 59);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSkyBlue;
            label3.Location = new Point(292, 9);
            label3.Name = "label3";
            label3.Size = new Size(611, 38);
            label3.TabIndex = 3;
            label3.Text = "Welcome to Teddy Shop Management";
            label3.UseWaitCursor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(1157, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(33, 32);
            BtnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnClose.TabIndex = 25;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnHelp);
            panel3.Controls.Add(btnSuplier);
            panel3.Controls.Add(btnProducts);
            panel3.Controls.Add(btnDashboard);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 621);
            panel3.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BorderRadius = 10;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.Logout_301px;
            btnLogout.Location = new Point(12, 546);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log Out";
            // 
            // btnHelp
            // 
            btnHelp.BorderRadius = 10;
            btnHelp.CustomizableEdges = customizableEdges3;
            btnHelp.DisabledState.BorderColor = Color.DarkGray;
            btnHelp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHelp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHelp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHelp.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.White;
            btnHelp.Image = Properties.Resources.customer_301px;
            btnHelp.Location = new Point(12, 410);
            btnHelp.Name = "btnHelp";
            btnHelp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHelp.Size = new Size(180, 45);
            btnHelp.TabIndex = 7;
            btnHelp.Text = "Help";
            // 
            // btnSuplier
            // 
            btnSuplier.BorderRadius = 10;
            btnSuplier.CustomizableEdges = customizableEdges5;
            btnSuplier.DisabledState.BorderColor = Color.DarkGray;
            btnSuplier.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuplier.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuplier.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuplier.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuplier.ForeColor = Color.White;
            btnSuplier.Image = Properties.Resources.group_301px;
            btnSuplier.Location = new Point(12, 341);
            btnSuplier.Name = "btnSuplier";
            btnSuplier.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSuplier.Size = new Size(180, 45);
            btnSuplier.TabIndex = 6;
            btnSuplier.Text = "Suplier";
            btnSuplier.Click += btnSuplier_Click;
            // 
            // btnProducts
            // 
            btnProducts.BorderRadius = 10;
            btnProducts.CustomizableEdges = customizableEdges7;
            btnProducts.DisabledState.BorderColor = Color.DarkGray;
            btnProducts.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProducts.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProducts.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProducts.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = Properties.Resources.us_dollar_301px;
            btnProducts.Location = new Point(12, 275);
            btnProducts.Name = "btnProducts";
            btnProducts.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnProducts.Size = new Size(180, 45);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Products";
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BorderRadius = 10;
            btnDashboard.CustomizableEdges = customizableEdges9;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(12, 209);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDashboard.Size = new Size(180, 45);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 189);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO2;
            pictureBox1.Location = new Point(32, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Role :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 3;
            label1.Text = "UserName: ";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2TaskBarProgress1
            // 
            guna2TaskBarProgress1.TargetForm = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(94, 148, 255);
            label4.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(256, 152);
            label4.Name = "label4";
            label4.Size = new Size(632, 46);
            label4.TabIndex = 9;
            label4.Text = "For every bear that ever there was";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(94, 148, 255);
            label5.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(256, 89);
            label5.Name = "label5";
            label5.Size = new Size(404, 46);
            label5.TabIndex = 10;
            label5.Text = "THE TEDDY BEAR SHOP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(94, 148, 255);
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(256, 229);
            label6.Name = "label6";
            label6.Size = new Size(831, 30);
            label6.TabIndex = 11;
            label6.Text = "A Fluffy friend that will always make you SMILE everytime, everywhere ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.istockphoto_1400388586_612x612;
            pictureBox2.Location = new Point(911, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.CustomizableEdges = customizableEdges11;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(227, 65);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox1.Size = new Size(929, 234);
            guna2TextBox1.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(94, 148, 255);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(206, 318);
            panel4.Name = "panel4";
            panel4.Size = new Size(990, 8);
            panel4.TabIndex = 9;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1190, 680);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(guna2TextBox1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnSuplier;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private PictureBox BtnClose;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
    }
}