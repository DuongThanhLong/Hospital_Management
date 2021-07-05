namespace Hospital_Management
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuuY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDrug = new System.Windows.Forms.Button();
            this.txtLuuY_Update = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaThuoc_Update = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(763, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(359, 51);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.RowTemplate.Height = 28;
            this.dgvMedicine.Size = new System.Drawing.Size(435, 459);
            this.dgvMedicine.TabIndex = 62;
            // 
            // btnThuoc
            // 
            this.btnThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnThuoc.FlatAppearance.BorderSize = 0;
            this.btnThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuoc.Location = new System.Drawing.Point(181, 3);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(172, 56);
            this.btnThuoc.TabIndex = 65;
            this.btnThuoc.Text = "Thuốc";
            this.btnThuoc.UseVisualStyleBackColor = false;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(3, 3);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(172, 56);
            this.btnInformation.TabIndex = 66;
            this.btnInformation.Text = "Thông tin";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddDrug);
            this.groupBox4.Controls.Add(this.txtDonGia);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtLuuY);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTenthuoc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtDVTinh);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtMathuoc);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(3, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 193);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add a drug:";
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnAddDrug.FlatAppearance.BorderSize = 2;
            this.btnAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrug.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrug.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddDrug.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDrug.Image")));
            this.btnAddDrug.Location = new System.Drawing.Point(236, 146);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(51, 37);
            this.btnAddDrug.TabIndex = 87;
            this.btnAddDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDrug.UseVisualStyleBackColor = false;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(107, 116);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(111, 37);
            this.txtDonGia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don gia:";
            // 
            // txtLuuY
            // 
            this.txtLuuY.Location = new System.Drawing.Point(107, 146);
            this.txtLuuY.Name = "txtLuuY";
            this.txtLuuY.Size = new System.Drawing.Size(111, 37);
            this.txtLuuY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Luu y:";
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(107, 56);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(111, 37);
            this.txtTenthuoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten thuoc:";
            // 
            // txtDVTinh
            // 
            this.txtDVTinh.Location = new System.Drawing.Point(107, 86);
            this.txtDVTinh.Name = "txtDVTinh";
            this.txtDVTinh.Size = new System.Drawing.Size(111, 37);
            this.txtDVTinh.TabIndex = 3;
            this.txtDVTinh.TextChanged += new System.EventHandler(this.txtKetLuan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Don vi tinh:";
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Location = new System.Drawing.Point(149, 26);
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(69, 37);
            this.txtMathuoc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ma thuoc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateDrug);
            this.groupBox1.Controls.Add(this.txtLuuY_Update);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaThuoc_Update);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(3, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 106);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a drug:";
            // 
            // btnUpdateDrug
            // 
            this.btnUpdateDrug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnUpdateDrug.FlatAppearance.BorderSize = 2;
            this.btnUpdateDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDrug.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDrug.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateDrug.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDrug.Image")));
            this.btnUpdateDrug.Location = new System.Drawing.Point(236, 52);
            this.btnUpdateDrug.Name = "btnUpdateDrug";
            this.btnUpdateDrug.Size = new System.Drawing.Size(51, 37);
            this.btnUpdateDrug.TabIndex = 87;
            this.btnUpdateDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDrug.UseVisualStyleBackColor = false;
            this.btnUpdateDrug.Click += new System.EventHandler(this.btnUpdateDrug_Click);
            // 
            // txtLuuY_Update
            // 
            this.txtLuuY_Update.Location = new System.Drawing.Point(107, 56);
            this.txtLuuY_Update.Name = "txtLuuY_Update";
            this.txtLuuY_Update.Size = new System.Drawing.Size(111, 37);
            this.txtLuuY_Update.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Luu y:";
            // 
            // txtMaThuoc_Update
            // 
            this.txtMaThuoc_Update.Location = new System.Drawing.Point(149, 26);
            this.txtMaThuoc_Update.Name = "txtMaThuoc_Update";
            this.txtMaThuoc_Update.Size = new System.Drawing.Size(69, 37);
            this.txtMaThuoc_Update.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ma thuoc:";
            // 
            // MedicineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnThuoc);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDVTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLuuY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateDrug;
        private System.Windows.Forms.TextBox txtLuuY_Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaThuoc_Update;
        private System.Windows.Forms.Label label10;
    }
}