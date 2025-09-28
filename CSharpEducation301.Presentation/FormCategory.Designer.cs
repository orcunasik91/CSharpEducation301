namespace CSharpEducation301.Presentation
{
    partial class FormCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCategoryId = new TextBox();
            btnList = new Button();
            dataGridView1 = new DataGridView();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rdbActive = new RadioButton();
            rdbPassive = new RadioButton();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnGetById = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(54, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Kategori Id:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(152, 16);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(194, 27);
            txtCategoryId.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.ActiveCaption;
            btnList.Location = new Point(152, 115);
            btnList.Name = "btnList";
            btnList.Size = new Size(194, 45);
            btnList.TabIndex = 2;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 338);
            dataGridView1.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(152, 49);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(194, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(44, 52);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(108, 23);
            label2.TabIndex = 4;
            label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(146, 23);
            label3.TabIndex = 6;
            label3.Text = "Kategori Durumu:";
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.Location = new Point(152, 85);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(61, 24);
            rdbActive.TabIndex = 7;
            rdbActive.TabStop = true;
            rdbActive.Text = "Aktif";
            rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            rdbPassive.AutoSize = true;
            rdbPassive.Location = new Point(219, 85);
            rdbPassive.Name = "rdbPassive";
            rdbPassive.Size = new Size(60, 24);
            rdbPassive.TabIndex = 8;
            rdbPassive.TabStop = true;
            rdbPassive.Text = "Pasif";
            rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.Location = new Point(152, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 45);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGoldenrodYellow;
            btnUpdate.Location = new Point(152, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 45);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.Location = new Point(152, 268);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(194, 45);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.MistyRose;
            btnGetById.Location = new Point(152, 319);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(194, 45);
            btnGetById.TabIndex = 12;
            btnGetById.Text = "Id'ye Göre Getir";
            btnGetById.UseVisualStyleBackColor = false;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(941, 380);
            Controls.Add(btnGetById);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(rdbPassive);
            Controls.Add(rdbActive);
            Controls.Add(label3);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Name = "FormCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryId;
        private Button btnList;
        private DataGridView dataGridView1;
        private TextBox txtCategoryName;
        private Label label2;
        private Label label3;
        private RadioButton rdbActive;
        private RadioButton rdbPassive;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnGetById;
    }
}
