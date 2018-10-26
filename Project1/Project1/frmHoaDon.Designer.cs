namespace Project1
{
    partial class frmHoaDon
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtShipper = new System.Windows.Forms.TextBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.gbCTHD = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblShipper = new System.Windows.Forms.Label();
            this.gbHD = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.gbCTHD.SuspendLayout();
            this.gbHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Image = global::Project1.Properties.Resources.Clear_icon;
            this.btnReset.Location = new System.Drawing.Point(737, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 64);
            this.btnReset.TabIndex = 85;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtShipper
            // 
            this.txtShipper.Location = new System.Drawing.Point(296, 55);
            this.txtShipper.Name = "txtShipper";
            this.txtShipper.Size = new System.Drawing.Size(118, 26);
            this.txtShipper.TabIndex = 80;
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.Ngay,
            this.Shipper});
            this.dgvHD.Location = new System.Drawing.Point(9, 133);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(500, 181);
            this.dgvHD.TabIndex = 81;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // gbCTHD
            // 
            this.gbCTHD.Controls.Add(this.dgvCTHD);
            this.gbCTHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTHD.ForeColor = System.Drawing.Color.Black;
            this.gbCTHD.Location = new System.Drawing.Point(515, 82);
            this.gbCTHD.Name = "gbCTHD";
            this.gbCTHD.Size = new System.Drawing.Size(286, 232);
            this.gbCTHD.TabIndex = 84;
            this.gbCTHD.TabStop = false;
            this.gbCTHD.Text = "Chi Tiết Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.Location = new System.Drawing.Point(85, 22);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(105, 22);
            this.txtMaHD.TabIndex = 40;
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Blue;
            this.lblMaHD.Location = new System.Drawing.Point(6, 22);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(73, 22);
            this.lblMaHD.TabIndex = 37;
            this.lblMaHD.Text = "Mã HD";
            this.lblMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipper
            // 
            this.lblShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblShipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShipper.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipper.ForeColor = System.Drawing.Color.Blue;
            this.lblShipper.Location = new System.Drawing.Point(210, 55);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(80, 22);
            this.lblShipper.TabIndex = 82;
            this.lblShipper.Text = "Shipper";
            this.lblShipper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbHD
            // 
            this.gbHD.Controls.Add(this.dtpNgay);
            this.gbHD.Controls.Add(this.txtMaNV);
            this.gbHD.Controls.Add(this.txtShipper);
            this.gbHD.Controls.Add(this.lblMaNV);
            this.gbHD.Controls.Add(this.txtMaKH);
            this.gbHD.Controls.Add(this.lblMaKH);
            this.gbHD.Controls.Add(this.lblShipper);
            this.gbHD.Controls.Add(this.lblNgay);
            this.gbHD.Controls.Add(this.txtMaHD);
            this.gbHD.Controls.Add(this.lblMaHD);
            this.gbHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHD.ForeColor = System.Drawing.Color.Black;
            this.gbHD.Location = new System.Drawing.Point(9, 5);
            this.gbHD.Name = "gbHD";
            this.gbHD.Size = new System.Drawing.Size(500, 122);
            this.gbHD.TabIndex = 83;
            this.gbHD.TabStop = false;
            this.gbHD.Text = "Hóa Đơn";
            this.gbHD.Enter += new System.EventHandler(this.gbHD_Enter);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(296, 22);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(118, 26);
            this.dtpNgay.TabIndex = 83;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(85, 87);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(105, 22);
            this.txtMaNV.TabIndex = 52;
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Blue;
            this.lblMaNV.Location = new System.Drawing.Point(6, 87);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(73, 22);
            this.lblMaNV.TabIndex = 51;
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(85, 55);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(105, 22);
            this.txtMaKH.TabIndex = 41;
            // 
            // lblMaKH
            // 
            this.lblMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.Color.Blue;
            this.lblMaKH.Location = new System.Drawing.Point(6, 55);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(73, 22);
            this.lblMaKH.TabIndex = 33;
            this.lblMaKH.Text = "Mã KH";
            this.lblMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            this.lblNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNgay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.Blue;
            this.lblNgay.Location = new System.Drawing.Point(210, 22);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(80, 22);
            this.lblNgay.TabIndex = 31;
            this.lblNgay.Text = "Ngày";
            this.lblNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Image = global::Project1.Properties.Resources.Text_Edit_icon;
            this.btnSua.Location = new System.Drawing.Point(515, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 64);
            this.btnSua.TabIndex = 75;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::Project1.Properties.Resources.delete_file_icon;
            this.btnXoa.Location = new System.Drawing.Point(629, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 64);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong});
            this.dgvCTHD.Location = new System.Drawing.Point(6, 25);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(274, 200);
            this.dgvCTHD.TabIndex = 86;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.Frozen = true;
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 80;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 80;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // Shipper
            // 
            this.Shipper.DataPropertyName = "Shipper";
            this.Shipper.HeaderText = "Shipper";
            this.Shipper.Name = "Shipper";
            this.Shipper.Width = 50;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.Frozen = true;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 65;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.gbCTHD);
            this.Controls.Add(this.gbHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.gbCTHD.ResumeLayout(false);
            this.gbHD.ResumeLayout(false);
            this.gbHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtShipper;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.GroupBox gbCTHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.GroupBox gbHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}