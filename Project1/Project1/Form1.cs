using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        Main me = new Main();
        string tenshop;
        public Form1()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void LoadTenShop()
        {
            //InitializeTimer();
            tenshop = me.TenShopget().Trim();
            lblChao.Text = " Chào mừng đến với " + tenshop + " ";
            timer1.Start();
            //lblChao.Location = new Point(Width, lblChao.Location.Y);         
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable log = me.Login(txtUser.Text, txtPass.Text);
            try
            {
                lblUser.Text = log.Rows[0][1].ToString().Trim();               
                MessageBox.Show("Đăng nhập thành công", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                me.LoginSuccess(txtUser.Text);
                timer2.Start();
                //tabControl1.Enabled = true;
                btnShipper.Enabled = true;
                btnNhanVien.Enabled = true;
                btnKhachHang.Enabled = true;
                btnSanPham.Enabled = true;
                //btnSuaTT.Enabled = true;
                //btnThongKe.Enabled = true;
                btnThongTin.Enabled = true;
                //btnKho.Enabled = true;
                //btnBanHang.Enabled = true;
                //btnBanHang.Enabled = true;
                btnLogout.Enabled = true;
                btnDoiPass.Enabled = true;
                btnKho1.Enabled = true;
                btnNCC.Enabled = true;
                btnBanHang.Enabled = true;
                btnHoaDon.Enabled = true;
                //9
                //if (log.Rows[0][1].ToString().Trim() != "admin")
                //{
                //    //
                //    tabControl1.TabPages.Remove(QlyRapTab); // thêm tab nếu là admin
                //    tabControl1.TabPages.Remove(TTRap);
                //}
                //else
                //{
                //    tabControl1.TabPages.Add(QlyRapTab); // thêm tab nếu là admin
                //    tabControl1.TabPages.Add(TTRap);
                //}
                tabControl1.Visible = true;
                lblChao.Visible = true;
                lblUser.Visible = true;
                btnLogout.Visible = true;
                tabControl2.TabPages.Remove(pageLogin);
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Sorry",
                             MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.Visible = false;
            btnShipper.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = false;
            btnSanPham.Enabled = false;
            //btnSuaTT.Enabled = false;
            //btnThongKe.Enabled = false;
            btnThongTin.Enabled = false;
            btnBanHang.Enabled = false;
            btnHoaDon.Enabled = false;
            //tabControl1.Visible = false;
            //lblChao.Visible = false;
            lblUser.Visible = false;
            //lblLogout.Visible = false;
            tabControl2.TabPages.Clear();
            tabControl2.TabPages.Add(pageLogin);
            tabControl2.TabPages.Add(pageHelp);
            txtUser.ResetText();
            txtPass.ResetText();
            tabControl2.SelectedTab = pageLogin;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Message = lblUser.Text;
            frm.TopLevel = false;
            string title = "QL Nhan Vien";
            TabPage pageQLNhanVien = new TabPage(title);
            tabControl2.TabPages.Add(pageQLNhanVien);
            pageQLNhanVien.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLNhanVien;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        
        private void lblChao_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = false;
            btnSanPham.Enabled = false;
            btnShipper.Enabled = false;
            btnKho1.Enabled = false;
            //btnThongKe.Enabled = false;
            btnThongTin.Enabled = false;
            btnDoiPass.Enabled = false;
            btnKho1.Enabled = false;
            btnNCC.Enabled = false;
            btnHoaDon.Enabled = false;
            btnBanHang.Enabled = false;
            
            //btnXemLich.Enabled = false;
            //btnDatVe.Enabled = false;
            //lblUser.Visible = false;
            btnLogout.Visible = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.TopLevel = false;
            string title = "QL Khach Hang";
            TabPage pageQLKhachHang = new TabPage(title);
            tabControl2.TabPages.Add(pageQLKhachHang);
            pageQLKhachHang.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLKhachHang;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnShipper_Click(object sender, EventArgs e)
        {
            frmShipper frm = new frmShipper();
            frm.Message = lblUser.Text;
            frm.TopLevel = false;
            string title = "QL Shipper";
            TabPage pageQLShipper = new TabPage(title);
            tabControl2.TabPages.Add(pageQLShipper);
            pageQLShipper.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLShipper;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.TopLevel = false;
            string title = "QL NCC";
            TabPage pageQLNCC = new TabPage(title);
            tabControl2.TabPages.Add(pageQLNCC);
            pageQLNCC.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLNCC;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.TopLevel = false;
            string title = "QL San Pham";
            TabPage pageQLSanPham = new TabPage(title);
            tabControl2.TabPages.Add(pageQLSanPham);
            pageQLSanPham.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLSanPham;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnKho1_Click(object sender, EventArgs e)
        {
            frmKho frm = new frmKho();
            frm.Message = lblUser.Text;
            frm.TopLevel = false;
            string title = "QL Kho";
            TabPage pageQLKho = new TabPage(title);
            tabControl2.TabPages.Add(pageQLKho);
            pageQLKho.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLKho;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.Message = lblUser.Text;
            frm.TopLevel = false;
            string title = "Bán Hàng";
            TabPage pageBanHang = new TabPage(title);
            tabControl2.TabPages.Add(pageBanHang);
            pageBanHang.Controls.Add(frm);
            tabControl2.SelectedTab = pageBanHang;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.TopLevel = false;
            string title = "QL Hoa Don";
            TabPage pageQLHD = new TabPage(title);
            tabControl2.TabPages.Add(pageQLHD);
            pageQLHD.Controls.Add(frm);
            tabControl2.SelectedTab = pageQLHD;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        
    }
}
