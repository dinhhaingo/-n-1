namespace Project1
{
    partial class frmShipper
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
            this.lblCuaHang = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.gbShipper = new System.Windows.Forms.GroupBox();
            this.txtCuaHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenShipper = new System.Windows.Forms.TextBox();
            this.lblTenShipper = new System.Windows.Forms.Label();
            this.txtMaShipper = new System.Windows.Forms.TextBox();
            this.lblMaShipper = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvShipper = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblGTinh = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtGTinh = new System.Windows.Forms.TextBox();
            this.MaShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbShipper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuaHang
            // 
            this.lblCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCuaHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuaHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuaHang.ForeColor = System.Drawing.Color.Blue;
            this.lblCuaHang.Location = new System.Drawing.Point(6, 87);
            this.lblCuaHang.Name = "lblCuaHang";
            this.lblCuaHang.Size = new System.Drawing.Size(73, 22);
            this.lblCuaHang.TabIndex = 51;
            this.lblCuaHang.Text = "Cửa Hàng";
            this.lblCuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // gbShipper
            // 
            this.gbShipper.Controls.Add(this.txtGTinh);
            this.gbShipper.Controls.Add(this.txtCMND);
            this.gbShipper.Controls.Add(this.lblGTinh);
            this.gbShipper.Controls.Add(this.lblCMND);
            this.gbShipper.Controls.Add(this.txtCuaHang);
            this.gbShipper.Controls.Add(this.lblCuaHang);
            this.gbShipper.Controls.Add(this.txtDiaChi);
            this.gbShipper.Controls.Add(this.txtSDT);
            this.gbShipper.Controls.Add(this.lblDiaChi);
            this.gbShipper.Controls.Add(this.lblSDT);
            this.gbShipper.Controls.Add(this.txtTenShipper);
            this.gbShipper.Controls.Add(this.lblTenShipper);
            this.gbShipper.Controls.Add(this.txtMaShipper);
            this.gbShipper.Controls.Add(this.lblMaShipper);
            this.gbShipper.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShipper.ForeColor = System.Drawing.Color.Black;
            this.gbShipper.Location = new System.Drawing.Point(12, 5);
            this.gbShipper.Name = "gbShipper";
            this.gbShipper.Size = new System.Drawing.Size(682, 122);
            this.gbShipper.TabIndex = 83;
            this.gbShipper.TabStop = false;
            this.gbShipper.Text = "Shipper";
            // 
            // txtCuaHang
            // 
            this.txtCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuaHang.ForeColor = System.Drawing.Color.Black;
            this.txtCuaHang.Location = new System.Drawing.Point(85, 87);
            this.txtCuaHang.Name = "txtCuaHang";
            this.txtCuaHang.Size = new System.Drawing.Size(105, 22);
            this.txtCuaHang.TabIndex = 52;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(85, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(105, 22);
            this.txtSDT.TabIndex = 41;
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
            this.lblSDT.Location = new System.Drawing.Point(6, 55);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 22);
            this.lblSDT.TabIndex = 33;
            this.lblSDT.Text = "SĐT";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenShipper
            // 
            this.txtTenShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenShipper.ForeColor = System.Drawing.Color.Black;
            this.txtTenShipper.Location = new System.Drawing.Point(296, 22);
            this.txtTenShipper.Name = "txtTenShipper";
            this.txtTenShipper.Size = new System.Drawing.Size(167, 22);
            this.txtTenShipper.TabIndex = 43;
            // 
            // lblTenShipper
            // 
            this.lblTenShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTenShipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenShipper.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenShipper.ForeColor = System.Drawing.Color.Blue;
            this.lblTenShipper.Location = new System.Drawing.Point(210, 22);
            this.lblTenShipper.Name = "lblTenShipper";
            this.lblTenShipper.Size = new System.Drawing.Size(80, 22);
            this.lblTenShipper.TabIndex = 31;
            this.lblTenShipper.Text = "Shipper";
            this.lblTenShipper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaShipper
            // 
            this.txtMaShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaShipper.ForeColor = System.Drawing.Color.Black;
            this.txtMaShipper.Location = new System.Drawing.Point(85, 22);
            this.txtMaShipper.Name = "txtMaShipper";
            this.txtMaShipper.Size = new System.Drawing.Size(105, 22);
            this.txtMaShipper.TabIndex = 40;
            // 
            // lblMaShipper
            // 
            this.lblMaShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaShipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaShipper.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaShipper.ForeColor = System.Drawing.Color.Blue;
            this.lblMaShipper.Location = new System.Drawing.Point(6, 22);
            this.lblMaShipper.Name = "lblMaShipper";
            this.lblMaShipper.Size = new System.Drawing.Size(73, 22);
            this.lblMaShipper.TabIndex = 37;
            this.lblMaShipper.Text = "Mã ";
            this.lblMaShipper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::Project1.Properties.Resources.delete_file_icon;
            this.btnXoa.Location = new System.Drawing.Point(727, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 64);
            this.btnXoa.TabIndex = 80;
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
            this.btnSua.Location = new System.Drawing.Point(727, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 64);
            this.btnSua.TabIndex = 81;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Image = global::Project1.Properties.Resources.Clear_icon;
            this.btnReset.Location = new System.Drawing.Point(727, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 64);
            this.btnReset.TabIndex = 82;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvShipper
            // 
            this.dgvShipper.AllowUserToAddRows = false;
            this.dgvShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaShipper,
            this.TenShipper,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.CMND,
            this.CuaHang});
            this.dgvShipper.Location = new System.Drawing.Point(12, 133);
            this.dgvShipper.Name = "dgvShipper";
            this.dgvShipper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipper.Size = new System.Drawing.Size(682, 181);
            this.dgvShipper.TabIndex = 78;
            this.dgvShipper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipper_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Image = global::Project1.Properties.Resources.Plus_icon__1_;
            this.btnThem.Location = new System.Drawing.Point(727, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 64);
            this.btnThem.TabIndex = 79;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblCMND
            // 
            this.lblCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCMND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Blue;
            this.lblCMND.Location = new System.Drawing.Point(481, 55);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(80, 22);
            this.lblCMND.TabIndex = 53;
            this.lblCMND.Text = "CMND";
            this.lblCMND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGTinh
            // 
            this.lblGTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGTinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTinh.ForeColor = System.Drawing.Color.Blue;
            this.lblGTinh.Location = new System.Drawing.Point(481, 21);
            this.lblGTinh.Name = "lblGTinh";
            this.lblGTinh.Size = new System.Drawing.Size(80, 22);
            this.lblGTinh.TabIndex = 54;
            this.lblGTinh.Text = "Giới Tính";
            this.lblGTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(567, 56);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(105, 22);
            this.txtCMND.TabIndex = 55;
            // 
            // txtGTinh
            // 
            this.txtGTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTinh.ForeColor = System.Drawing.Color.Black;
            this.txtGTinh.Location = new System.Drawing.Point(567, 21);
            this.txtGTinh.Name = "txtGTinh";
            this.txtGTinh.Size = new System.Drawing.Size(105, 22);
            this.txtGTinh.TabIndex = 56;
            // 
            // MaShipper
            // 
            this.MaShipper.DataPropertyName = "MaShipper";
            this.MaShipper.Frozen = true;
            this.MaShipper.HeaderText = "Mã Shipper";
            this.MaShipper.Name = "MaShipper";
            this.MaShipper.Width = 80;
            // 
            // TenShipper
            // 
            this.TenShipper.DataPropertyName = "TenShipper";
            this.TenShipper.HeaderText = "Tên Shipper";
            this.TenShipper.Name = "TenShipper";
            this.TenShipper.Width = 153;
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
            this.SDT.HeaderText = "Số Điện Thoại";
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
            // CuaHang
            // 
            this.CuaHang.DataPropertyName = "CuaHang";
            this.CuaHang.HeaderText = "Cửa Hàng";
            this.CuaHang.Name = "CuaHang";
            // 
            // frmShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.gbShipper);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvShipper);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShipper";
            this.Text = "frmShipper";
            this.Load += new System.EventHandler(this.frmShipper_Load);
            this.gbShipper.ResumeLayout(false);
            this.gbShipper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCuaHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox gbShipper;
        private System.Windows.Forms.TextBox txtCuaHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenShipper;
        private System.Windows.Forms.Label lblTenShipper;
        private System.Windows.Forms.TextBox txtMaShipper;
        private System.Windows.Forms.Label lblMaShipper;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvShipper;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGTinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblGTinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuaHang;
    }
}