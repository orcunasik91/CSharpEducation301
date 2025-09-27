namespace CSharpEducation301.EFDbFirst
{
    partial class FormLocation
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
            txtCountry = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnGetList = new Button();
            txtId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtStatus = new TextBox();
            label7 = new Label();
            nudCapacity = new NumericUpDown();
            cmbGuide = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            SuspendLayout();
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.PeachPuff;
            btnGetById.Location = new Point(132, 507);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(190, 42);
            btnGetById.TabIndex = 23;
            btnGetById.Text = "Getir";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Tomato;
            btnRemove.Location = new Point(132, 459);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(190, 42);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Location = new Point(132, 411);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 42);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Location = new Point(132, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 42);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(132, 101);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(190, 27);
            txtCountry.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(68, 104);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 18;
            label3.Text = "Ülke:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(132, 68);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(190, 27);
            txtCity.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(62, 71);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 16;
            label2.Text = "Şehir:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(865, 514);
            dataGridView1.TabIndex = 15;
            // 
            // btnGetList
            // 
            btnGetList.BackColor = Color.Gainsboro;
            btnGetList.Location = new Point(132, 315);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(190, 42);
            btnGetList.TabIndex = 14;
            btnGetList.Text = "Listele";
            btnGetList.UseVisualStyleBackColor = false;
            btnGetList.Click += btnGetList_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(9, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 12;
            label1.Text = "Lokasyon Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(36, 136);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 24;
            label4.Text = "Kapasite:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(65, 170);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 25;
            label5.Text = "Fiyat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(48, 202);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 26;
            label6.Text = "Durum:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(132, 170);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 27);
            txtPrice.TabIndex = 28;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(132, 203);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(190, 27);
            txtStatus.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(48, 235);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 30;
            label7.Text = "Rehber:";
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(132, 137);
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(190, 27);
            nudCapacity.TabIndex = 32;
            // 
            // cmbGuide
            // 
            cmbGuide.FormattingEnabled = true;
            cmbGuide.Location = new Point(132, 236);
            cmbGuide.Name = "cmbGuide";
            cmbGuide.Size = new Size(190, 28);
            cmbGuide.TabIndex = 33;
            // 
            // FormLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1251, 625);
            Controls.Add(cmbGuide);
            Controls.Add(nudCapacity);
            Controls.Add(label7);
            Controls.Add(txtStatus);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnGetById);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetList);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lokasyon Bilgisi";
            Load += FormLocation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetById;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnGetList;
        private TextBox txtId;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtStatus;
        private Label label7;
        private NumericUpDown nudCapacity;
        private ComboBox cmbGuide;
    }
}