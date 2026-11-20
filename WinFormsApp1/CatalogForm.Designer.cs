namespace WinFormsApp1
{
    partial class CatalogForm
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
            btnOrderList = new Button();
            btnBack = new Button();
            btnOrder = new Button();
            lblCatalogTitle = new Label();
            lblUserName = new Label();
            flpProduct = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCategoryFilter = new Label();
            cboCategory = new ComboBox();
            lblPriceSort = new Label();
            cboPriceSort = new ComboBox();
            SuspendLayout();
            // 
            // btnOrderList
            // 
            btnOrderList.Enabled = false;
            btnOrderList.Location = new Point(265, 32);
            btnOrderList.Name = "btnOrderList";
            btnOrderList.Size = new Size(116, 23);
            btnOrderList.TabIndex = 0;
            btnOrderList.Text = "Список заказов ";
            btnOrderList.UseVisualStyleBackColor = true;
            btnOrderList.Click += btnOrderList_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(44, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnOrder
            // 
            btnOrder.Enabled = false;
            btnOrder.Location = new Point(158, 32);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(86, 23);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Заказ";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblCatalogTitle
            // 
            lblCatalogTitle.AutoSize = true;
            lblCatalogTitle.Location = new Point(23, 9);
            lblCatalogTitle.Name = "lblCatalogTitle";
            lblCatalogTitle.Size = new Size(89, 15);
            lblCatalogTitle.TabIndex = 3;
            lblCatalogTitle.Text = "Каталог обуви ";
            lblCatalogTitle.Click += lblCatalogTitle_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1031, 32);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(40, 15);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Гость ";
            // 
            // flpProduct
            // 
            flpProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpProduct.AutoScroll = true;
            flpProduct.FlowDirection = FlowDirection.TopDown;
            flpProduct.Location = new Point(12, 128);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(1229, 513);
            flpProduct.TabIndex = 5;
            flpProduct.WrapContents = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(23, 70);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(200, 15);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Поиск по названию или описанию";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(293, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += CatalogOptionsChanged;
            // 
            // lblCategoryFilter
            // 
            lblCategoryFilter.AutoSize = true;
            lblCategoryFilter.Location = new Point(362, 70);
            lblCategoryFilter.Name = "lblCategoryFilter";
            lblCategoryFilter.Size = new Size(66, 15);
            lblCategoryFilter.TabIndex = 8;
            lblCategoryFilter.Text = "Категория ";
            lblCategoryFilter.Click += lblCategoryFilter_Click;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(362, 88);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(205, 23);
            cboCategory.TabIndex = 9;
            cboCategory.SelectedIndexChanged += CatalogOptionsChanged;
            // 
            // lblPriceSort
            // 
            lblPriceSort.AutoSize = true;
            lblPriceSort.Location = new Point(606, 70);
            lblPriceSort.Name = "lblPriceSort";
            lblPriceSort.Size = new Size(122, 15);
            lblPriceSort.TabIndex = 10;
            lblPriceSort.Text = "Сортировка по цене ";
            // 
            // cboPriceSort
            // 
            cboPriceSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriceSort.FormattingEnabled = true;
            cboPriceSort.Items.AddRange(new object[] { "По умолчанию", "Сначала дешевле", "Сначала дороже" });
            cboPriceSort.Location = new Point(606, 88);
            cboPriceSort.Name = "cboPriceSort";
            cboPriceSort.Size = new Size(150, 23);
            cboPriceSort.TabIndex = 11;
            cboPriceSort.SelectedIndexChanged += CatalogOptionsChanged;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 617);
            Controls.Add(cboPriceSort);
            Controls.Add(lblPriceSort);
            Controls.Add(cboCategory);
            Controls.Add(lblCategoryFilter);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(flpProduct);
            Controls.Add(lblUserName);
            Controls.Add(lblCatalogTitle);
            Controls.Add(btnOrder);
            Controls.Add(btnBack);
            Controls.Add(btnOrderList);
            Name = "CatalogForm";
            Text = "CatalogForm";
            Load += CatalogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderList;
        private Button btnBack;
        private Button btnOrder;
        private Label lblCatalogTitle;
        private Label lblUserName;
        private FlowLayoutPanel flpProduct;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCategoryFilter;
        private ComboBox cboCategory;
        private Label lblPriceSort;
        private ComboBox cboPriceSort;
    }
}