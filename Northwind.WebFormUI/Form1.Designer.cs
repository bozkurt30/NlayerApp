namespace Northwind.WebFormUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategoryName = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblBirimAdedi = new System.Windows.Forms.Label();
            this.tbxProductAddName = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.cbxCategoryAddId = new System.Windows.Forms.ComboBox();
            this.btnAdded = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUpdateQuailty = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateStock = new System.Windows.Forms.TextBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategoryName.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 223);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.Size = new System.Drawing.Size(887, 161);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategoryName
            // 
            this.gbxCategoryName.Controls.Add(this.cbxCategory);
            this.gbxCategoryName.Controls.Add(this.lblCategory);
            this.gbxCategoryName.Location = new System.Drawing.Point(12, 12);
            this.gbxCategoryName.Name = "gbxCategoryName";
            this.gbxCategoryName.Size = new System.Drawing.Size(887, 86);
            this.gbxCategoryName.TabIndex = 3;
            this.gbxCategoryName.TabStop = false;
            this.gbxCategoryName.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(90, 27);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(273, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(15, 118);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(884, 86);
            this.gbxProductName.TabIndex = 4;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(87, 29);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(273, 22);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxQuantity);
            this.groupBox1.Controls.Add(this.btnAdded);
            this.groupBox1.Controls.Add(this.cbxCategoryAddId);
            this.groupBox1.Controls.Add(this.tbxStock);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.tbxProductAddName);
            this.groupBox1.Controls.Add(this.lblBirimAdedi);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblCateg);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Location = new System.Drawing.Point(15, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(27, 48);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(63, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(26, 89);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(61, 17);
            this.lblCateg.TabIndex = 1;
            this.lblCateg.Text = "Kategori";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(29, 126);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(354, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(76, 17);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            // 
            // lblBirimAdedi
            // 
            this.lblBirimAdedi.AutoSize = true;
            this.lblBirimAdedi.Location = new System.Drawing.Point(357, 83);
            this.lblBirimAdedi.Name = "lblBirimAdedi";
            this.lblBirimAdedi.Size = new System.Drawing.Size(79, 17);
            this.lblBirimAdedi.TabIndex = 4;
            this.lblBirimAdedi.Text = "Birim Adedi";
            // 
            // tbxProductAddName
            // 
            this.tbxProductAddName.Location = new System.Drawing.Point(101, 48);
            this.tbxProductAddName.Name = "tbxProductAddName";
            this.tbxProductAddName.Size = new System.Drawing.Size(231, 22);
            this.tbxProductAddName.TabIndex = 5;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(101, 121);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(231, 22);
            this.tbxPrice.TabIndex = 7;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(446, 43);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(231, 22);
            this.tbxStock.TabIndex = 8;
            // 
            // cbxCategoryAddId
            // 
            this.cbxCategoryAddId.FormattingEnabled = true;
            this.cbxCategoryAddId.Location = new System.Drawing.Point(101, 83);
            this.cbxCategoryAddId.Name = "cbxCategoryAddId";
            this.cbxCategoryAddId.Size = new System.Drawing.Size(231, 24);
            this.cbxCategoryAddId.TabIndex = 6;
            // 
            // btnAdded
            // 
            this.btnAdded.Location = new System.Drawing.Point(446, 115);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(231, 28);
            this.btnAdded.TabIndex = 10;
            this.btnAdded.Text = "Ekle";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(446, 80);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(231, 22);
            this.tbxQuantity.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxUpdateQuailty);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cbxUpdateCategory);
            this.groupBox2.Controls.Add(this.tbxUpdateStock);
            this.groupBox2.Controls.Add(this.tbxUpdatePrice);
            this.groupBox2.Controls.Add(this.tbxUpdateProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 646);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 175);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün Ekle";
            // 
            // tbxUpdateQuailty
            // 
            this.tbxUpdateQuailty.Location = new System.Drawing.Point(446, 80);
            this.tbxUpdateQuailty.Name = "tbxUpdateQuailty";
            this.tbxUpdateQuailty.Size = new System.Drawing.Size(231, 22);
            this.tbxUpdateQuailty.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(446, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(101, 83);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(231, 24);
            this.cbxUpdateCategory.TabIndex = 6;
            // 
            // tbxUpdateStock
            // 
            this.tbxUpdateStock.Location = new System.Drawing.Point(446, 43);
            this.tbxUpdateStock.Name = "tbxUpdateStock";
            this.tbxUpdateStock.Size = new System.Drawing.Size(231, 22);
            this.tbxUpdateStock.TabIndex = 8;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(101, 121);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(231, 22);
            this.tbxUpdatePrice.TabIndex = 7;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(101, 48);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(231, 22);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 26);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 836);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategoryName);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategoryName.ResumeLayout(false);
            this.gbxCategoryName.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategoryName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.ComboBox cbxCategoryAddId;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxProductAddName;
        private System.Windows.Forms.Label lblBirimAdedi;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxUpdateQuailty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.TextBox tbxUpdateStock;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

