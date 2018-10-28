namespace Project1
{
    partial class frmDoiPass
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
            this.gbDoiPass = new System.Windows.Forms.GroupBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblacc = new System.Windows.Forms.Label();
            this.gbDoiPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoiPass
            // 
            this.gbDoiPass.Controls.Add(this.lblTK);
            this.gbDoiPass.Controls.Add(this.txtNewPass);
            this.gbDoiPass.Controls.Add(this.lblConfirm);
            this.gbDoiPass.Controls.Add(this.lblNewPass);
            this.gbDoiPass.Controls.Add(this.pictureBox1);
            this.gbDoiPass.Controls.Add(this.btnSave);
            this.gbDoiPass.Controls.Add(this.txtPass);
            this.gbDoiPass.Controls.Add(this.txtConfirm);
            this.gbDoiPass.Controls.Add(this.lblpass);
            this.gbDoiPass.Controls.Add(this.lblacc);
            this.gbDoiPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoiPass.ForeColor = System.Drawing.Color.Blue;
            this.gbDoiPass.Location = new System.Drawing.Point(193, 12);
            this.gbDoiPass.Name = "gbDoiPass";
            this.gbDoiPass.Size = new System.Drawing.Size(448, 246);
            this.gbDoiPass.TabIndex = 6;
            this.gbDoiPass.TabStop = false;
            this.gbDoiPass.Text = "Đổi Mật Khẩu";
            // 
            // lblTK
            // 
            this.lblTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTK.Location = new System.Drawing.Point(302, 32);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(130, 26);
            this.lblTK.TabIndex = 9;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(302, 98);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(130, 26);
            this.txtNewPass.TabIndex = 8;
            // 
            // lblConfirm
            // 
            this.lblConfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Blue;
            this.lblConfirm.Location = new System.Drawing.Point(154, 140);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(142, 24);
            this.lblConfirm.TabIndex = 7;
            this.lblConfirm.Text = "Xác Nhận MK Mới";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewPass
            // 
            this.lblNewPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.Blue;
            this.lblNewPass.Location = new System.Drawing.Point(154, 100);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(142, 24);
            this.lblNewPass.TabIndex = 6;
            this.lblNewPass.Text = "Mật Khẩu Mới";
            this.lblNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1.Properties.Resources.App_password_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Image = global::Project1.Properties.Resources.ModernXP_47_Printer_Save_Ok_icon__1_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(239, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 58);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(302, 66);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(130, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(302, 138);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(130, 26);
            this.txtConfirm.TabIndex = 2;
            // 
            // lblpass
            // 
            this.lblpass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Blue;
            this.lblpass.Location = new System.Drawing.Point(154, 68);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(142, 24);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Mật Khẩu Cũ";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblacc
            // 
            this.lblacc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblacc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacc.ForeColor = System.Drawing.Color.Blue;
            this.lblacc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblacc.Location = new System.Drawing.Point(154, 32);
            this.lblacc.Name = "lblacc";
            this.lblacc.Size = new System.Drawing.Size(142, 24);
            this.lblacc.TabIndex = 0;
            this.lblacc.Text = "Tài Khoản";
            this.lblacc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 319);
            this.Controls.Add(this.gbDoiPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiPass";
            this.Text = "frmDoiPass";
            this.Load += new System.EventHandler(this.frmDoiPass_Load);
            this.gbDoiPass.ResumeLayout(false);
            this.gbDoiPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoiPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblacc;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblNewPass;
    }
}