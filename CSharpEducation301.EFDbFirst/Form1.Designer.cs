namespace CSharpEducation301.EFDbFirst
{
    partial class Form1
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
            txtId = new TextBox();
            btnGetList = new Button();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
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
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Rehber Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            // 
            // btnGetList
            // 
            btnGetList.BackColor = Color.Gainsboro;
            btnGetList.Location = new Point(144, 147);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(190, 42);
            btnGetList.TabIndex = 2;
            btnGetList.Text = "Listele";
            btnGetList.UseVisualStyleBackColor = false;
            btnGetList.Click += btnGetList_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(634, 346);
            dataGridView1.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(36, 71);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 4;
            label2.Text = "Rehber Adı:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(144, 101);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(190, 27);
            txtSurname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(10, 104);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 6;
            label3.Text = "Rehber Soyadı:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Location = new Point(144, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Location = new Point(144, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Tomato;
            btnRemove.Location = new Point(144, 291);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(190, 42);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.PeachPuff;
            btnGetById.Location = new Point(144, 339);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(190, 42);
            btnGetById.TabIndex = 11;
            btnGetById.Text = "Getir";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1090, 416);
            Controls.Add(btnGetById);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetList);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnGetList;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnGetById;
    }
}
