namespace Windows_Form_Final___Tedshop_System.Views.ProductForm
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnClose = new PictureBox();
            label6 = new Label();
            txtSupplier = new ComboBox();
            label7 = new Label();
            txtSize = new ComboBox();
            label8 = new Label();
            txtCategory = new ComboBox();
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
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(299, 33);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 1;
            label1.Text = "Manage Products";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 86);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 126);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 166);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 207);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Stock :";
            // 
            // txtName
            // 
            txtName.Location = new Point(195, 83);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter name";
            txtName.Size = new Size(578, 23);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(195, 123);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter Description";
            txtDescription.Size = new Size(578, 23);
            txtDescription.TabIndex = 7;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(195, 163);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter Price";
            txtPrice.Size = new Size(578, 23);
            txtPrice.TabIndex = 8;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(195, 204);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Enter Stock";
            txtStock.Size = new Size(578, 23);
            txtStock.TabIndex = 9;
            txtStock.TextChanged += txtStock_TextChanged;
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
            btnSave.Location = new Point(47, 381);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(180, 45);
            btnSave.TabIndex = 10;
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
            btnUpdate.Location = new Point(311, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(180, 45);
            btnUpdate.TabIndex = 11;
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
            btnCancel.Location = new Point(595, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(180, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(760, 32);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 25);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 25;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 251);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 26;
            label6.Text = "Supplier :";
            // 
            // txtSupplier
            // 
            txtSupplier.FormattingEnabled = true;
            txtSupplier.Location = new Point(195, 248);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(580, 23);
            txtSupplier.TabIndex = 27;
            txtSupplier.Text = "Select Supplier";
            txtSupplier.SelectedIndexChanged += txtSupplier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(47, 294);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 28;
            label7.Text = "Size  :";
            // 
            // txtSize
            // 
            txtSize.FormattingEnabled = true;
            txtSize.Location = new Point(195, 291);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(580, 23);
            txtSize.TabIndex = 29;
            txtSize.Text = "Select Size";
            txtSize.SelectedIndexChanged += txtSize_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(47, 330);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 30;
            label8.Text = "Category  :";
            // 
            // txtCategory
            // 
            txtCategory.FormattingEnabled = true;
            txtCategory.Location = new Point(195, 331);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(580, 23);
            txtCategory.TabIndex = 31;
            txtCategory.Text = "Select Category";
            txtCategory.SelectedIndexChanged += txtCategory_SelectedIndexChanged;
            // 
            // ProductModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCategory);
            Controls.Add(label8);
            Controls.Add(txtSize);
            Controls.Add(label7);
            Controls.Add(txtSupplier);
            Controls.Add(label6);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private PictureBox btnClose;
        private Label label6;
        private ComboBox txtSupplier;
        private ComboBox txtCategory;
        private Label label8;
        private ComboBox txtSize;
        private Label label7;
    }
}