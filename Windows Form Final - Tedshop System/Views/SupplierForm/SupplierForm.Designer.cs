namespace Windows_Form_Final___Tedshop_System.Views.SupplierForm
{
    partial class SupplierForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            btnResetFilter = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridSupplier = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Supplier_ID = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(94, 148, 255);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 13);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 172, 220);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 241);
            panel4.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResetFilter);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(11, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 55);
            panel2.TabIndex = 30;
            // 
            // btnResetFilter
            // 
            btnResetFilter.CustomizableEdges = customizableEdges1;
            btnResetFilter.DisabledState.BorderColor = Color.DarkGray;
            btnResetFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnResetFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnResetFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnResetFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(892, 16);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnResetFilter.Size = new Size(60, 25);
            btnResetFilter.TabIndex = 30;
            btnResetFilter.Text = "Reset";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(22, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(26, 25);
            btnAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAdd.TabIndex = 26;
            btnAdd.TabStop = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(655, 10);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(220, 38);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridSupplier
            // 
            dataGridSupplier.AllowUserToAddRows = false;
            dataGridSupplier.BackgroundColor = SystemColors.Control;
            dataGridSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridSupplier.ColumnHeadersHeight = 30;
            dataGridSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridSupplier.Columns.AddRange(new DataGridViewColumn[] { Column1, Supplier_ID, Column3, Column4, Column5, Column6, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridSupplier.Dock = DockStyle.Fill;
            dataGridSupplier.EnableHeadersVisualStyles = false;
            dataGridSupplier.GridColor = SystemColors.ControlDark;
            dataGridSupplier.Location = new Point(11, 68);
            dataGridSupplier.Name = "dataGridSupplier";
            dataGridSupplier.RowHeadersVisible = false;
            dataGridSupplier.RowTemplate.Height = 25;
            dataGridSupplier.Size = new Size(986, 186);
            dataGridSupplier.TabIndex = 31;
            dataGridSupplier.CellContentClick += dataGridSupplier_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Supplier_ID
            // 
            Supplier_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Supplier_ID.HeaderText = "Supplier ID";
            Supplier_ID.Name = "Supplier_ID";
            Supplier_ID.Width = 109;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Phone Number";
            Column4.Name = "Column4";
            Column4.Width = 141;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Address";
            Column6.Name = "Column6";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit_30px1;
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete_30px1;
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(997, 254);
            Controls.Add(dataGridSupplier);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnResetFilter;
        private PictureBox btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DataGridView dataGridSupplier;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Supplier_ID;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}