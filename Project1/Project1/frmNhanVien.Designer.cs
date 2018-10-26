namespace Project1
{
    partial class frmNhanVien
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
            this.btnCMND = new System.Windows.Forms.Button();
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.cbGTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCuaHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblCuaHang = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.gbNhanVien = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCMND
            // 
            this.btnCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCMND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMND.ForeColor = System.Drawing.Color.Blue;
            this.btnCMND.Location = new System.Drawing.Point(483, 55);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(73, 22);
            this.btnCMND.TabIndex = 50;
            this.btnCMND.Text = "CMND";
            this.btnCMND.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCMND.UseVisualStyleBackColor = false;
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNV.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiNV.FormattingEnabled = true;
            this.cbLoaiNV.Items.AddRange(new object[] {
            "Hành động",
            "Kinh dị",
            "Tình cảm",
            "Tâm lý",
            "Hài Hước",
            "Khoa Học Viễn Tưởng",
            "Hoạt hình"});
            this.cbLoaiNV.Location = new System.Drawing.Point(562, 87);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(84, 24);
            this.cbLoaiNV.TabIndex = 45;
            // 
            // cbGTinh
            // 
            this.cbGTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGTinh.ForeColor = System.Drawing.Color.Black;
            this.cbGTinh.FormattingEnabled = true;
            this.cbGTinh.Items.AddRange(new object[] {
            "60 phút",
            "120 phút",
            "150 phút"});
            this.cbGTinh.Location = new System.Drawing.Point(85, 120);
            this.cbGTinh.Name = "cbGTinh";
            this.cbGTinh.Size = new System.Drawing.Size(105, 24);
            this.cbGTinh.TabIndex = 44;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(296, 55);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(167, 22);
            this.txtDiaChi.TabIndex = 39;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Blue;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 120);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(73, 22);
            this.lblGioiTinh.TabIndex = 36;
            this.lblGioiTinh.Text = "GTính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Image = global::Project1.Properties.Resources.Clear_icon;
            this.btnReset.Location = new System.Drawing.Point(667, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 64);
            this.btnReset.TabIndex = 64;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCuaHang
            // 
            this.txtCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuaHang.ForeColor = System.Drawing.Color.Black;
            this.txtCuaHang.Location = new System.Drawing.Point(85, 55);
            this.txtCuaHang.Name = "txtCuaHang";
            this.txtCuaHang.Size = new System.Drawing.Size(105, 22);
            this.txtCuaHang.TabIndex = 41;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(562, 22);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(84, 22);
            this.txtSDT.TabIndex = 42;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lblDiaChi.Location = new System.Drawing.Point(210, 55);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(80, 22);
            this.lblDiaChi.TabIndex = 34;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Blue;
            this.lblSDT.Location = new System.Drawing.Point(483, 22);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 22);
            this.lblSDT.TabIndex = 32;
            this.lblSDT.Text = "SĐT";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Image = global::Project1.Properties.Resources.Text_Edit_icon;
            this.btnSua.Location = new System.Drawing.Point(737, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 64);
            this.btnSua.TabIndex = 63;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblCuaHang
            // 
            this.lblCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCuaHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuaHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuaHang.ForeColor = System.Drawing.Color.Blue;
            this.lblCuaHang.Location = new System.Drawing.Point(6, 55);
            this.lblCuaHang.Name = "lblCuaHang";
            this.lblCuaHang.Size = new System.Drawing.Size(73, 22);
            this.lblCuaHang.TabIndex = 33;
            this.lblCuaHang.Text = "Cửa Hàng";
            this.lblCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Image = global::Project1.Properties.Resources.Plus_icon__1_;
            this.btnThem.Location = new System.Drawing.Point(667, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 64);
            this.btnThem.TabIndex = 61;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.Location = new System.Drawing.Point(296, 22);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(167, 22);
            this.txtTenNV.TabIndex = 43;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTenNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNV.Location = new System.Drawing.Point(210, 22);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(80, 22);
            this.lblTenNV.TabIndex = 31;
            this.lblTenNV.Text = "Tên NV";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(85, 22);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(105, 22);
            this.txtMaNV.TabIndex = 40;
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Blue;
            this.lblMaNV.Location = new System.Drawing.Point(6, 22);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(73, 22);
            this.lblMaNV.TabIndex = 37;
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNhanVien
            // 
            this.gbNhanVien.Controls.Add(this.txtCMND);
            this.gbNhanVien.Controls.Add(this.button1);
            this.gbNhanVien.Controls.Add(this.txtTK);
            this.gbNhanVien.Controls.Add(this.lblTK);
            this.gbNhanVien.Controls.Add(this.btnCMND);
            this.gbNhanVien.Controls.Add(this.cbLoaiNV);
            this.gbNhanVien.Controls.Add(this.cbGTinh);
            this.gbNhanVien.Controls.Add(this.txtDiaChi);
            this.gbNhanVien.Controls.Add(this.lblGioiTinh);
            this.gbNhanVien.Controls.Add(this.txtCuaHang);
            this.gbNhanVien.Controls.Add(this.txtSDT);
            this.gbNhanVien.Controls.Add(this.lblDiaChi);
            this.gbNhanVien.Controls.Add(this.lblCuaHang);
            this.gbNhanVien.Controls.Add(this.lblSDT);
            this.gbNhanVien.Controls.Add(this.txtTenNV);
            this.gbNhanVien.Controls.Add(this.lblTenNV);
            this.gbNhanVien.Controls.Add(this.txtMaNV);
            this.gbNhanVien.Controls.Add(this.lblMaNV);
            this.gbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNhanVien.ForeColor = System.Drawing.Color.Black;
            this.gbNhanVien.Location = new System.Drawing.Point(2, 0);
            this.gbNhanVien.Name = "gbNhanVien";
            this.gbNhanVien.Size = new System.Drawing.Size(652, 151);
            this.gbNhanVien.TabIndex = 65;
            this.gbNhanVien.TabStop = false;
            this.gbNhanVien.Text = "Nhân Viên";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(562, 55);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(84, 22);
            this.txtCMND.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(483, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 53;
            this.button1.Text = "Loại NV";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.Color.Black;
            this.txtTK.Location = new System.Drawing.Point(85, 87);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(105, 22);
            this.txtTK.TabIndex = 52;
            // 
            // lblTK
            // 
            this.lblTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.Blue;
            this.lblTK.Location = new System.Drawing.Point(6, 87);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(73, 22);
            this.lblTK.TabIndex = 51;
            this.lblTK.Text = "Mã TK";
            this.lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::Project1.Properties.Resources.delete_file_icon;
            this.btnXoa.Location = new System.Drawing.Point(737, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 64);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.CMND,
            this.LoaiNV,
            this.CuaHang,
            this.MaTK});
            this.dgvNhanVien.Location = new System.Drawing.Point(8, 157);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(793, 152);
            this.dgvNhanVien.TabIndex = 60;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.Frozen = true;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 80;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 153;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Width = 95;
            // 
            // LoaiNV
            // 
            this.LoaiNV.DataPropertyName = "LoaiNV";
            this.LoaiNV.HeaderText = "Loại NV";
            this.LoaiNV.Name = "LoaiNV";
            // 
            // CuaHang
            // 
            this.CuaHang.DataPropertyName = "CuaHang";
            this.CuaHang.HeaderText = "Cửa Hàng";
            this.CuaHang.Name = "CuaHang";
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.Name = "MaTK";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.gbNhanVien.ResumeLayout(false);
            this.gbNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCMND;
        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.ComboBox cbGTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCuaHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblCuaHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox gbNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
    }
}