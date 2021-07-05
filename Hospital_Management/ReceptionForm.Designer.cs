namespace Hospital_Management
{
    partial class ReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvReception = new System.Windows.Forms.DataGridView();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnViewHĐ = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(654, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvReception
            // 
            this.dgvReception.AllowUserToAddRows = false;
            this.dgvReception.AllowUserToDeleteRows = false;
            this.dgvReception.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReception.Location = new System.Drawing.Point(4, 78);
            this.dgvReception.Name = "dgvReception";
            this.dgvReception.ReadOnly = true;
            this.dgvReception.RowTemplate.Height = 28;
            this.dgvReception.Size = new System.Drawing.Size(681, 298);
            this.dgvReception.TabIndex = 61;
            this.dgvReception.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellContentClick);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(4, 2);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(193, 56);
            this.btnInformation.TabIndex = 62;
            this.btnInformation.Text = "Thông tin";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnViewHĐ
            // 
            this.btnViewHĐ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnViewHĐ.FlatAppearance.BorderSize = 0;
            this.btnViewHĐ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHĐ.ForeColor = System.Drawing.Color.White;
            this.btnViewHĐ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewHĐ.Location = new System.Drawing.Point(203, 2);
            this.btnViewHĐ.Name = "btnViewHĐ";
            this.btnViewHĐ.Size = new System.Drawing.Size(193, 56);
            this.btnViewHĐ.TabIndex = 63;
            this.btnViewHĐ.Text = "Hóa Đơn";
            this.btnViewHĐ.UseVisualStyleBackColor = false;
            this.btnViewHĐ.Click += new System.EventHandler(this.btnViewHĐ_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenhNhan.ForeColor = System.Drawing.Color.White;
            this.btnBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBenhNhan.Location = new System.Drawing.Point(402, 2);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(193, 56);
            this.btnBenhNhan.TabIndex = 64;
            this.btnBenhNhan.Text = "Bệnh Nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = false;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // ReceptionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 379);
            this.Controls.Add(this.btnBenhNhan);
            this.Controls.Add(this.btnViewHĐ);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.dgvReception);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvReception;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnViewHĐ;
        private System.Windows.Forms.Button btnBenhNhan;
    }
}