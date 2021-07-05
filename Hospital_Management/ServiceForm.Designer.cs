namespace Hospital_Management
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnCTDV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.txtKetluan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtKey_Decode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnKeys = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(761, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(2, 1);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowTemplate.Height = 28;
            this.dgvService.Size = new System.Drawing.Size(493, 451);
            this.dgvService.TabIndex = 63;
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(502, 1);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(172, 56);
            this.btnInformation.TabIndex = 67;
            this.btnInformation.Text = "Thông tin";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnCTDV
            // 
            this.btnCTDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnCTDV.FlatAppearance.BorderSize = 0;
            this.btnCTDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTDV.ForeColor = System.Drawing.Color.White;
            this.btnCTDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTDV.Location = new System.Drawing.Point(501, 63);
            this.btnCTDV.Name = "btnCTDV";
            this.btnCTDV.Size = new System.Drawing.Size(172, 56);
            this.btnCTDV.TabIndex = 68;
            this.btnCTDV.Text = "Chi tiết dịch vụ";
            this.btnCTDV.UseVisualStyleBackColor = false;
            this.btnCTDV.Click += new System.EventHandler(this.btnCTDV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdateService);
            this.groupBox1.Controls.Add(this.txtKetluan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaKhamBenh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(502, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 127);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write outcome:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(107, 86);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(111, 37);
            this.txtKey.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 88;
            this.label1.Text = "Key:";
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnUpdateService.FlatAppearance.BorderSize = 2;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateService.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateService.Image")));
            this.btnUpdateService.Location = new System.Drawing.Point(224, 90);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(45, 33);
            this.btnUpdateService.TabIndex = 87;
            this.btnUpdateService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // txtKetluan
            // 
            this.txtKetluan.Location = new System.Drawing.Point(107, 56);
            this.txtKetluan.Name = "txtKetluan";
            this.txtKetluan.Size = new System.Drawing.Size(111, 37);
            this.txtKetluan.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ket luan:";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.Location = new System.Drawing.Point(149, 26);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(69, 37);
            this.txtMaKhamBenh.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ma kham benh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDecode);
            this.groupBox2.Controls.Add(this.txtKey_Decode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaKB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(502, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 107);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode:";
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnDecode.FlatAppearance.BorderSize = 2;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecode.Image = ((System.Drawing.Image)(resources.GetObject("btnDecode.Image")));
            this.btnDecode.Location = new System.Drawing.Point(224, 60);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(45, 33);
            this.btnDecode.TabIndex = 87;
            this.btnDecode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtKey_Decode
            // 
            this.txtKey_Decode.Location = new System.Drawing.Point(107, 56);
            this.txtKey_Decode.Name = "txtKey_Decode";
            this.txtKey_Decode.Size = new System.Drawing.Size(111, 37);
            this.txtKey_Decode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key:";
            // 
            // txtMaKB
            // 
            this.txtMaKB.Location = new System.Drawing.Point(149, 26);
            this.txtMaKB.Name = "txtMaKB";
            this.txtMaKB.Size = new System.Drawing.Size(69, 37);
            this.txtMaKB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ma kham benh:";
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(501, 125);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(172, 56);
            this.btnDichVu.TabIndex = 77;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnKeys
            // 
            this.btnKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnKeys.FlatAppearance.BorderSize = 0;
            this.btnKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeys.ForeColor = System.Drawing.Color.White;
            this.btnKeys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeys.Location = new System.Drawing.Point(679, 63);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(110, 56);
            this.btnKeys.TabIndex = 78;
            this.btnKeys.Text = "See Key";
            this.btnKeys.UseVisualStyleBackColor = false;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 454);
            this.Controls.Add(this.btnKeys);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCTDV);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnCTDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.TextBox txtKetluan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKhamBenh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtKey_Decode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnKeys;
    }
}