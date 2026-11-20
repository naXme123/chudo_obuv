namespace WinFormsApp1
{
    partial class ProductCardControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            picProduct = new PictureBox();
            lblProductTitle = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblMaterial = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(12, 12);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(128, 110);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // lblProductTitle
            // 
            lblProductTitle.Location = new Point(156, 12);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(455, 38);
            lblProductTitle.TabIndex = 1;
            lblProductTitle.Text = "Производство | Наименование";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(156, 53);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Категория";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(156, 74);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Количество ";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(156, 96);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(45, 15);
            lblMaterial.TabIndex = 4;
            lblMaterial.Text = "Состав";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPrice.Location = new Point(645, 47);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 21);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Цена";
            // 
            // ProductCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(lblMaterial);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblProductTitle);
            Controls.Add(picProduct);
            DoubleBuffered = true;
            Name = "ProductCardControl";
            Size = new Size(798, 183);
            Load += ProductCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProduct;
        private Label lblProductTitle;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblMaterial;
        private Label lblPrice;
    }
}
