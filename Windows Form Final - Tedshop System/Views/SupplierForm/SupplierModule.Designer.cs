namespace Windows_Form_Final___Tedshop_System.Views.SupplierForm
{
    partial class SupplierModule
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierModule));
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 13);
            panel1.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(273, 42);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 2;
            label1.Text = "Manage Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 114);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 188);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 255);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 319);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Address :";
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 115);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter name";
            txtName.Size = new Size(559, 23);
            txtName.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(210, 185);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter Phone number";
            txtPhoneNumber.Size = new Size(559, 23);
            txtPhoneNumber.TabIndex = 8;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(210, 256);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(559, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(210, 316);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Enter Address";
            txtAddress.Size = new Size(559, 23);
            txtAddress.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 15;
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(69, 371);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(180, 45);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 15;
            btnUpdate.CustomizableEdges = customizableEdges3;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.DarkOrange;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(313, 371);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(180, 45);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 15;
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.DarkGray;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(555, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(180, 45);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(770, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 25);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 26;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // SupplierModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierModule";
            Load += SupplierModule_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private PictureBox btnClose;
    }
}