namespace CSharpEducation301.Presentation
{
    partial class FormProduct
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
            btnGetById = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnList = new Button();
            txtProductId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudStock = new NumericUpDown();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            txtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.MistyRose;
            btnGetById.Location = new Point(148, 476);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(194, 45);
            btnGetById.TabIndex = 25;
            btnGetById.Text = "Id'ye Göre Getir";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.Location = new Point(148, 425);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(194, 45);
            btnRemove.TabIndex = 24;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Location = new Point(148, 374);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 45);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.Location = new Point(148, 323);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 45);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(73, 79);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(49, 23);
            label3.TabIndex = 19;
            label3.Text = "Stok:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(148, 42);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(194, 27);
            txtProductName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(40, 45);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(82, 23);
            label2.TabIndex = 17;
            label2.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(818, 509);
            dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.ActiveCaption;
            btnList.Location = new Point(148, 272);
            btnList.Name = "btnList";
            btnList.Size = new Size(194, 45);
            btnList.TabIndex = 15;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(148, 9);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(194, 27);
            txtProductId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(50, 12);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(72, 23);
            label1.TabIndex = 13;
            label1.Text = "Ürün Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(71, 111);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(51, 23);
            label4.TabIndex = 26;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(39, 182);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(83, 23);
            label5.TabIndex = 27;
            label5.Text = "Açıklama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(44, 150);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(78, 23);
            label6.TabIndex = 28;
            label6.Text = "Kategori:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(148, 79);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(194, 27);
            nudStock.TabIndex = 29;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(148, 112);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(194, 27);
            txtPrice.TabIndex = 30;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(148, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(194, 28);
            cmbCategory.TabIndex = 31;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 188);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 78);
            txtDescription.TabIndex = 32;
            txtDescription.Text = "";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1178, 538);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(nudStock);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnGetById);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürünler";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetById;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnList;
        private TextBox txtProductId;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudStock;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private RichTextBox txtDescription;
    }
}