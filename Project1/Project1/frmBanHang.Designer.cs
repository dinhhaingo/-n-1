namespace Project1
{
    partial class frmBanHang
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblSoLuong1 = new System.Windows.Forms.Label();
            this.lblGia1 = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblMaSP1 = new System.Windows.Forms.Label();
            this.lblLoaiSP1 = new System.Windows.Forms.Label();
            this.lblTenSP1 = new System.Windows.Forms.Label();
            this.lblNCC1 = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtKH);
            this.gbThongTin.Controls.Add(this.btnGo);
            this.gbThongTin.Controls.Add(this.lblKH);
            this.gbThongTin.Controls.Add(this.lblSL);
            this.gbThongTin.Controls.Add(this.txtSL);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.cbSize);
            this.gbThongTin.Controls.Add(this.lblSoLuong1);
            this.gbThongTin.Controls.Add(this.lblGia1);
            this.gbThongTin.Controls.Add(this.picHinh);
            this.gbThongTin.Controls.Add(this.lblGia);
            this.gbThongTin.Controls.Add(this.lblSize);
            this.gbThongTin.Controls.Add(this.lblSoLuong);
            this.gbThongTin.Controls.Add(this.lblTenSP);
            this.gbThongTin.Controls.Add(this.lblLoaiSP);
            this.gbThongTin.Controls.Add(this.lblNCC);
            this.gbThongTin.Controls.Add(this.lblMaSP1);
            this.gbThongTin.Controls.Add(this.lblLoaiSP1);
            this.gbThongTin.Controls.Add(this.lblTenSP1);
            this.gbThongTin.Controls.Add(this.lblNCC1);
            this.gbThongTin.Controls.Add(this.lblMaSP);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Black;
            this.gbThongTin.Location = new System.Drawing.Point(413, 2);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(385, 312);
            this.gbThongTin.TabIndex = 80;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sản phẩm";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(286, 241);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(93, 26);
            this.txtKH.TabIndex = 65;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGo.ForeColor = System.Drawing.Color.Red;
            this.btnGo.Image = global::Project1.Properties.Resources.Button_Next_icon;
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGo.Location = new System.Drawing.Point(203, 273);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(176, 33);
            this.btnGo.TabIndex = 64;
            this.btnGo.Text = "Đi tới giỏ hàng";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblKH
            // 
            this.lblKH.ForeColor = System.Drawing.Color.Blue;
            this.lblKH.Location = new System.Drawing.Point(195, 245);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(95, 21);
            this.lblKH.TabIndex = 63;
            this.lblKH.Text = "Khách Hàng";
            // 
            // lblSL
            // 
            this.lblSL.ForeColor = System.Drawing.Color.Blue;
            this.lblSL.Location = new System.Drawing.Point(11, 245);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(80, 21);
            this.lblSL.TabIndex = 62;
            this.lblSL.Text = "Số Lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(91, 240);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(93, 26);
            this.txtSL.TabIndex = 61;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Image = global::Project1.Properties.Resources.Add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(15, 273);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(176, 33);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm vào giỏ hàng";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L ",
            "XL"});
            this.cbSize.Location = new System.Drawing.Point(141, 180);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 27);
            this.cbSize.TabIndex = 59;
            this.cbSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSize_MouseClick);
            // 
            // lblSoLuong1
            // 
            this.lblSoLuong1.AutoSize = true;
            this.lblSoLuong1.Location = new System.Drawing.Point(141, 211);
            this.lblSoLuong1.Name = "lblSoLuong1";
            this.lblSoLuong1.Size = new System.Drawing.Size(0, 19);
            this.lblSoLuong1.TabIndex = 58;
            // 
            // lblGia1
            // 
            this.lblGia1.AutoSize = true;
            this.lblGia1.Location = new System.Drawing.Point(141, 149);
            this.lblGia1.Name = "lblGia1";
            this.lblGia1.Size = new System.Drawing.Size(49, 19);
            this.lblGia1.TabIndex = 56;
            this.lblGia1.Text = "label3";
            // 
            // picHinh
            // 
            this.picHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHinh.Location = new System.Drawing.Point(295, 19);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(84, 87);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinh.TabIndex = 55;
            this.picHinh.TabStop = false;
            this.picHinh.Click += new System.EventHandler(this.picHinh_Click);
            // 
            // lblGia
            // 
            this.lblGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGia.Location = new System.Drawing.Point(15, 149);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(116, 21);
            this.lblGia.TabIndex = 10;
            this.lblGia.Text = "Giá:";
            // 
            // lblSize
            // 
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSize.Location = new System.Drawing.Point(15, 180);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(116, 21);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 211);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(116, 21);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Kho:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSP.Location = new System.Drawing.Point(15, 56);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(116, 21);
            this.lblTenSP.TabIndex = 7;
            this.lblTenSP.Text = "Tên Sản Phẩm:";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoaiSP.Location = new System.Drawing.Point(15, 87);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(116, 21);
            this.lblLoaiSP.TabIndex = 6;
            this.lblLoaiSP.Text = "Loại Sản Phẩm:";
            // 
            // lblNCC
            // 
            this.lblNCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNCC.Location = new System.Drawing.Point(15, 118);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(116, 21);
            this.lblNCC.TabIndex = 5;
            this.lblNCC.Text = "Nhà Cung Cấp:";
            // 
            // lblMaSP1
            // 
            this.lblMaSP1.AutoSize = true;
            this.lblMaSP1.Location = new System.Drawing.Point(141, 25);
            this.lblMaSP1.Name = "lblMaSP1";
            this.lblMaSP1.Size = new System.Drawing.Size(49, 19);
            this.lblMaSP1.TabIndex = 4;
            this.lblMaSP1.Text = "label6";
            // 
            // lblLoaiSP1
            // 
            this.lblLoaiSP1.AutoSize = true;
            this.lblLoaiSP1.Location = new System.Drawing.Point(141, 87);
            this.lblLoaiSP1.Name = "lblLoaiSP1";
            this.lblLoaiSP1.Size = new System.Drawing.Size(49, 19);
            this.lblLoaiSP1.TabIndex = 3;
            this.lblLoaiSP1.Text = "label5";
            // 
            // lblTenSP1
            // 
            this.lblTenSP1.AutoSize = true;
            this.lblTenSP1.Location = new System.Drawing.Point(141, 56);
            this.lblTenSP1.Name = "lblTenSP1";
            this.lblTenSP1.Size = new System.Drawing.Size(49, 19);
            this.lblTenSP1.TabIndex = 2;
            this.lblTenSP1.Text = "label4";
            // 
            // lblNCC1
            // 
            this.lblNCC1.AutoSize = true;
            this.lblNCC1.Location = new System.Drawing.Point(141, 118);
            this.lblNCC1.Name = "lblNCC1";
            this.lblNCC1.Size = new System.Drawing.Size(49, 19);
            this.lblNCC1.TabIndex = 1;
            this.lblNCC1.Text = "label3";
            // 
            // lblMaSP
            // 
            this.lblMaSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaSP.Location = new System.Drawing.Point(15, 25);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(116, 21);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.NCC,
            this.Gia,
            this.Photo});
            this.dgvBanHang.Location = new System.Drawing.Point(6, 12);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanHang.Size = new System.Drawing.Size(401, 295);
            this.dgvBanHang.TabIndex = 79;
            this.dgvBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_CellClick);
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
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại SP";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 80;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.Name = "NCC";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.Name = "Photo";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvBanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblMaSP1;
        private System.Windows.Forms.Label lblLoaiSP1;
        private System.Windows.Forms.Label lblTenSP1;
        private System.Windows.Forms.Label lblNCC1;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblSoLuong1;
        private System.Windows.Forms.Label lblGia1;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
    }
}