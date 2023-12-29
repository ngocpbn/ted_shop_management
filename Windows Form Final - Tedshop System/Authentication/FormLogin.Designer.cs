namespace Windows_Form_Final___Tedshop_System
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            Button_Login_Submit = new Button();
            checkbxShowPassword = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnCloseLogin = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCloseLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(675, 496);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 21;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Button_Login_Submit
            // 
            Button_Login_Submit.BackColor = Color.FromArgb(116, 86, 174);
            Button_Login_Submit.Cursor = Cursors.Hand;
            Button_Login_Submit.FlatAppearance.BorderSize = 0;
            Button_Login_Submit.FlatStyle = FlatStyle.Flat;
            Button_Login_Submit.ForeColor = Color.White;
            Button_Login_Submit.Location = new Point(675, 431);
            Button_Login_Submit.Name = "Button_Login_Submit";
            Button_Login_Submit.Size = new Size(216, 35);
            Button_Login_Submit.TabIndex = 20;
            Button_Login_Submit.Text = "LOGIN";
            Button_Login_Submit.UseVisualStyleBackColor = false;
            Button_Login_Submit.Click += Button_Login_Submit_Click;
            // 
            // checkbxShowPassword
            // 
            checkbxShowPassword.AutoSize = true;
            checkbxShowPassword.Cursor = Cursors.Hand;
            checkbxShowPassword.FlatStyle = FlatStyle.Flat;
            checkbxShowPassword.Location = new Point(675, 384);
            checkbxShowPassword.Name = "checkbxShowPassword";
            checkbxShowPassword.Size = new Size(119, 21);
            checkbxShowPassword.TabIndex = 19;
            checkbxShowPassword.Text = "Show Password";
            checkbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(675, 336);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 307);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.Hand;
            txtUsername.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(675, 247);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 218);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(648, 120);
            label1.Name = "label1";
            label1.Size = new Size(271, 48);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // BtnCloseLogin
            // 
            BtnCloseLogin.Image = (Image)resources.GetObject("BtnCloseLogin.Image");
            BtnCloseLogin.Location = new Point(988, -2);
            BtnCloseLogin.Name = "BtnCloseLogin";
            BtnCloseLogin.Size = new Size(33, 32);
            BtnCloseLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnCloseLogin.TabIndex = 24;
            BtnCloseLogin.TabStop = false;
            BtnCloseLogin.Click += Btn_close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(539, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 750);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg_image3;
            ClientSize = new Size(1020, 662);
            Controls.Add(BtnCloseLogin);
            Controls.Add(button2);
            Controls.Add(Button_Login_Submit);
            Controls.Add(checkbxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCloseLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button button2;
        private Button Button_Login_Submit;
        private CheckBox checkbxShowPassword;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox BtnCloseLogin;
        private PictureBox pictureBox1;
    }
}