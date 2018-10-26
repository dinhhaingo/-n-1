namespace Project1
{
    partial class frmGioHang
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
            this.dgvGio = new System.Windows.Forms.DataGridView();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblCH = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblKH1 = new System.Windows.Forms.Label();
            this.lblCH1 = new System.Windows.Forms.Label();
            this.lblSP1 = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSL = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbSL = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGio
            // 
            this.dgvGio.AllowUserToAddRows = false;
            this.dgvGio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.MaSP,
            this.MaCH,
            this.Size,
            this.SoLuong});
            this.dgvGio.Location = new System.Drawing.Point(12, 82);
            this.dgvGio.Name = "dgvGio";
            this.dgvGio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGio.Size = new System.Drawing.Size(401, 225);
            this.dgvGio.TabIndex = 73;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Red;
            this.lblTimKiem.Location = new System.Drawing.Point(12, 12);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(83, 22);
            this.lblTimKiem.TabIndex = 80;
            this.lblTimKiem.Text = "Tìm kiếm";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(101, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(156, 20);
            this.txtTimKiem.TabIndex = 79;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::Project1.Properties.Resources.Text_Edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(674, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 64);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = global::Project1.Properties.Resources.delete_file_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(547, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 64);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Blue;
            this.btnReload.Image = global::Project1.Properties.Resources.Button_Refresh_icon;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.Location = new System.Drawing.Point(368, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(114, 64);
            this.btnReload.TabIndex = 76;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblSP
            // 
            this.lblSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP.ForeColor = System.Drawing.Color.Blue;
            this.lblSP.Location = new System.Drawing.Point(88, 56);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(116, 21);
            this.lblSP.TabIndex = 88;
            this.lblSP.Text = "Mã Sản Phẩm:";
            // 
            // lblCH
            // 
            this.lblCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH.ForeColor = System.Drawing.Color.Blue;
            this.lblCH.Location = new System.Drawing.Point(88, 87);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(116, 21);
            this.lblCH.TabIndex = 87;
            this.lblCH.Text = "Mã Cửa Hàng:";
            // 
            // lblSize
            // 
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Location = new System.Drawing.Point(88, 118);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(116, 21);
            this.lblSize.TabIndex = 86;
            this.lblSize.Text = "Size:";
            // 
            // lblKH1
            // 
            this.lblKH1.AutoSize = true;
            this.lblKH1.Location = new System.Drawing.Point(214, 25);
            this.lblKH1.Name = "lblKH1";
            this.lblKH1.Size = new System.Drawing.Size(35, 13);
            this.lblKH1.TabIndex = 85;
            this.lblKH1.Text = "label6";
            // 
            // lblCH1
            // 
            this.lblCH1.AutoSize = true;
            this.lblCH1.Location = new System.Drawing.Point(214, 87);
            this.lblCH1.Name = "lblCH1";
            this.lblCH1.Size = new System.Drawing.Size(35, 13);
            this.lblCH1.TabIndex = 84;
            this.lblCH1.Text = "label5";
            // 
            // lblSP1
            // 
            this.lblSP1.AutoSize = true;
            this.lblSP1.Location = new System.Drawing.Point(214, 56);
            this.lblSP1.Name = "lblSP1";
            this.lblSP1.Size = new System.Drawing.Size(35, 13);
            this.lblSP1.TabIndex = 83;
            this.lblSP1.Text = "label4";
            // 
            // lblKH
            // 
            this.lblKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.ForeColor = System.Drawing.Color.Blue;
            this.lblKH.Location = new System.Drawing.Point(88, 25);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(116, 21);
            this.lblKH.TabIndex = 81;
            this.lblKH.Text = "Mã Khách Hàng:";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.Frozen = true;
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 80;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 80;
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
            // lblSL
            // 
            this.lblSL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.ForeColor = System.Drawing.Color.Blue;
            this.lblSL.Location = new System.Drawing.Point(88, 152);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(116, 21);
            this.lblSL.TabIndex = 89;
            this.lblSL.Text = "Số Lượng:";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(217, 118);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 90;
            // 
            // cbSL
            // 
            this.cbSL.Location = new System.Drawing.Point(217, 152);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(100, 20);
            this.cbSL.TabIndex = 91;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btnThanhToan.Location = new System.Drawing.Point(101, 41);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(106, 35);
            this.btnThanhToan.TabIndex = 92;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSL);
            this.panel1.Controls.Add(this.cbSize);
            this.panel1.Controls.Add(this.lblSL);
            this.panel1.Controls.Add(this.lblSP);
            this.panel1.Controls.Add(this.lblCH);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblKH1);
            this.panel1.Controls.Add(this.lblCH1);
            this.panel1.Controls.Add(this.lblSP1);
            this.panel1.Controls.Add(this.lblKH);
            this.panel1.Location = new System.Drawing.Point(442, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 211);
            this.panel1.TabIndex = 93;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Image = global::Project1.Properties.Resources.Very_Basic_Cancel_icon__1_;
            this.btnClose.Location = new System.Drawing.Point(784, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 94;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvGio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGioHang";
            this.Text = "frmGioHang";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGio;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblCH;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblKH1;
        private System.Windows.Forms.Label lblCH1;
        private System.Windows.Forms.Label lblSP1;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox cbSL;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}