namespace Project1
{
    partial class frmKho
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.lblMaCH = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.gbKho = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSP1 = new System.Windows.Forms.Label();
            this.lblNCC1 = new System.Windows.Forms.Label();
            this.lblLoaiSP1 = new System.Windows.Forms.Label();
            this.lblGia1 = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.gbKho.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::Project1.Properties.Resources.delete_file_icon;
            this.btnXoa.Location = new System.Drawing.Point(280, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 64);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Image = global::Project1.Properties.Resources.Text_Edit_icon;
            this.btnSua.Location = new System.Drawing.Point(350, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 64);
            this.btnSua.TabIndex = 75;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaCH,
            this.Size,
            this.SoLuong});
            this.dgvKho.Location = new System.Drawing.Point(6, 133);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKho.Size = new System.Drawing.Size(430, 181);
            this.dgvKho.TabIndex = 72;
            this.dgvKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.Frozen = true;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã CH";
            this.MaCH.Name = "MaCH";
            this.MaCH.Width = 80;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.Width = 50;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.Black;
            this.txtSize.Location = new System.Drawing.Point(85, 87);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(105, 22);
            this.txtSize.TabIndex = 52;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Image = global::Project1.Properties.Resources.Plus_icon__1_;
            this.btnThem.Location = new System.Drawing.Point(210, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 64);
            this.btnThem.TabIndex = 73;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.ForeColor = System.Drawing.Color.Black;
            this.txtMaCH.Location = new System.Drawing.Point(85, 55);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(105, 22);
            this.txtMaCH.TabIndex = 41;
            // 
            // lblMaCH
            // 
            this.lblMaCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCH.ForeColor = System.Drawing.Color.Blue;
            this.lblMaCH.Location = new System.Drawing.Point(6, 55);
            this.lblMaCH.Name = "lblMaCH";
            this.lblMaCH.Size = new System.Drawing.Size(73, 22);
            this.lblMaCH.TabIndex = 33;
            this.lblMaCH.Text = "Mã CH";
            this.lblMaCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(296, 22);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(118, 22);
            this.txtSoLuong.TabIndex = 43;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.lblSoLuong.Location = new System.Drawing.Point(210, 22);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 22);
            this.lblSoLuong.TabIndex = 31;
            this.lblSoLuong.Text = "Số Lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbKho
            // 
            this.gbKho.Controls.Add(this.btnSua);
            this.gbKho.Controls.Add(this.btnXoa);
            this.gbKho.Controls.Add(this.txtSize);
            this.gbKho.Controls.Add(this.lblSize);
            this.gbKho.Controls.Add(this.txtMaCH);
            this.gbKho.Controls.Add(this.lblMaCH);
            this.gbKho.Controls.Add(this.btnThem);
            this.gbKho.Controls.Add(this.txtSoLuong);
            this.gbKho.Controls.Add(this.lblSoLuong);
            this.gbKho.Controls.Add(this.txtMaSP);
            this.gbKho.Controls.Add(this.lblMaSP);
            this.gbKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKho.ForeColor = System.Drawing.Color.Black;
            this.gbKho.Location = new System.Drawing.Point(6, 5);
            this.gbKho.Name = "gbKho";
            this.gbKho.Size = new System.Drawing.Size(430, 122);
            this.gbKho.TabIndex = 77;
            this.gbKho.TabStop = false;
            this.gbKho.Text = "Kho";
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Location = new System.Drawing.Point(6, 87);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 22);
            this.lblSize.TabIndex = 51;
            this.lblSize.Text = "Size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(85, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(105, 22);
            this.txtMaSP.TabIndex = 40;
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.Blue;
            this.lblMaSP.Location = new System.Drawing.Point(6, 22);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(73, 22);
            this.lblMaSP.TabIndex = 37;
            this.lblMaSP.Text = "Mã SP";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lblLoaiSP);
            this.gbThongTin.Controls.Add(this.lblNCC);
            this.gbThongTin.Controls.Add(this.lblGia);
            this.gbThongTin.Controls.Add(this.lblTenSP1);
            this.gbThongTin.Controls.Add(this.lblNCC1);
            this.gbThongTin.Controls.Add(this.lblLoaiSP1);
            this.gbThongTin.Controls.Add(this.lblGia1);
            this.gbThongTin.Controls.Add(this.lblTenSP);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Black;
            this.gbThongTin.Location = new System.Drawing.Point(442, 82);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(356, 232);
            this.gbThongTin.TabIndex = 78;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sản phẩm";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoaiSP.Location = new System.Drawing.Point(36, 67);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(116, 21);
            this.lblLoaiSP.TabIndex = 7;
            this.lblLoaiSP.Text = "Loại Sản Phẩm:";
            // 
            // lblNCC
            // 
            this.lblNCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCC.Location = new System.Drawing.Point(36, 98);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(116, 21);
            this.lblNCC.TabIndex = 6;
            this.lblNCC.Text = "Nhà Cung Cấp:";
            // 
            // lblGia
            // 
            this.lblGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGia.Location = new System.Drawing.Point(36, 129);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(116, 21);
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Gía:";
            // 
            // lblTenSP1
            // 
            this.lblTenSP1.AutoSize = true;
            this.lblTenSP1.Location = new System.Drawing.Point(162, 36);
            this.lblTenSP1.Name = "lblTenSP1";
            this.lblTenSP1.Size = new System.Drawing.Size(49, 19);
            this.lblTenSP1.TabIndex = 4;
            this.lblTenSP1.Text = "label6";
            // 
            // lblNCC1
            // 
            this.lblNCC1.AutoSize = true;
            this.lblNCC1.Location = new System.Drawing.Point(162, 98);
            this.lblNCC1.Name = "lblNCC1";
            this.lblNCC1.Size = new System.Drawing.Size(49, 19);
            this.lblNCC1.TabIndex = 3;
            this.lblNCC1.Text = "label5";
            // 
            // lblLoaiSP1
            // 
            this.lblLoaiSP1.AutoSize = true;
            this.lblLoaiSP1.Location = new System.Drawing.Point(162, 67);
            this.lblLoaiSP1.Name = "lblLoaiSP1";
            this.lblLoaiSP1.Size = new System.Drawing.Size(49, 19);
            this.lblLoaiSP1.TabIndex = 2;
            this.lblLoaiSP1.Text = "label4";
            // 
            // lblGia1
            // 
            this.lblGia1.AutoSize = true;
            this.lblGia1.Location = new System.Drawing.Point(162, 129);
            this.lblGia1.Name = "lblGia1";
            this.lblGia1.Size = new System.Drawing.Size(49, 19);
            this.lblGia1.TabIndex = 1;
            this.lblGia1.Text = "label3";
            // 
            // lblTenSP
            // 
            this.lblTenSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSP.Location = new System.Drawing.Point(36, 36);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(116, 21);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên Sản Phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(531, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(156, 20);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Red;
            this.lblTimKiem.Location = new System.Drawing.Point(442, 27);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(83, 22);
            this.lblTimKiem.TabIndex = 76;
            this.lblTimKiem.Text = "Tìm kiếm";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Image = global::Project1.Properties.Resources.Clear_icon;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(693, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 64);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.gbKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.gbKho.ResumeLayout(false);
            this.gbKho.PerformLayout();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label lblMaCH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.GroupBox gbKho;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSP1;
        private System.Windows.Forms.Label lblNCC1;
        private System.Windows.Forms.Label lblLoaiSP1;
        private System.Windows.Forms.Label lblGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}