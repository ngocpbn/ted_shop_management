namespace Windows_Form_Final___Tedshop_System
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            btnResetFilter = new Guna.UI2.WinForms.Guna2Button();
            comboBoxSize = new ComboBox();
            comboBoxCategory = new ComboBox();
            panel3 = new Panel();
            btnAdd = new PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Product_ID = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(94, 148, 255);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 13);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResetFilter);
            panel2.Controls.Add(comboBoxSize);
            panel2.Controls.Add(comboBoxCategory);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 55);
            panel2.TabIndex = 1;
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
            btnResetFilter.Location = new Point(901, 16);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnResetFilter.Size = new Size(60, 25);
            btnResetFilter.TabIndex = 30;
            btnResetFilter.Text = "Reset";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // comboBoxSize
            // 
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(800, 16);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(86, 25);
            comboBoxSize.TabIndex = 29;
            comboBoxSize.Text = "Size (All)";
            comboBoxSize.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(671, 16);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(113, 25);
            comboBoxCategory.TabIndex = 28;
            comboBoxCategory.Text = "Category (All)";
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(3, 172, 220);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 270);
            panel3.TabIndex = 27;
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(29, 7);
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
            txtSearch.Location = new Point(445, 9);
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
            // dataGridProducts
            // 
            dataGridProducts.AllowUserToAddRows = false;
            dataGridProducts.BackgroundColor = SystemColors.Control;
            dataGridProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProducts.ColumnHeadersHeight = 30;
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Product_ID, Column3, Column4, Column5, Column6, Column2, Column8, Column7, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProducts.EnableHeadersVisualStyles = false;
            dataGridProducts.GridColor = SystemColors.ControlDark;
            dataGridProducts.Location = new Point(10, 67);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.RowHeadersVisible = false;
            dataGridProducts.RowTemplate.Height = 25;
            dataGridProducts.Size = new Size(974, 211);
            dataGridProducts.TabIndex = 5;
            dataGridProducts.CellContentClick += dataGridProducts_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Product_ID
            // 
            Product_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Product_ID.HeaderText = "Product ID";
            Product_ID.Name = "Product_ID";
            Product_ID.Width = 110;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.Width = 69;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Stock";
            Column6.Name = "Column6";
            Column6.Width = 72;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Size";
            Column2.Name = "Column2";
            Column2.Width = 58;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Category";
            Column8.Name = "Column8";
            Column8.Width = 102;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Supplier ID";
            Column7.Name = "Column7";
            Column7.Width = 109;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 172, 220);
            panel4.Location = new Point(0, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 270);
            panel4.TabIndex = 28;
            // 
            // ProductForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(984, 279);
            Controls.Add(panel4);
            Controls.Add(dataGridProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private PictureBox btnAdd;
        private DataGridView dataGridProducts;
        private Panel panel3;
        private Panel panel4;
        private ComboBox comboBoxSize;
        private ComboBox comboBoxCategory;
        private Guna.UI2.WinForms.Guna2Button btnResetFilter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}