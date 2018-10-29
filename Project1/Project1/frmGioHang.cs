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
    public partial class frmGioHang : Form
    {
        BanHang bh = new BanHang();
        QLHoaDon hd = new QLHoaDon();
        QLShipper ship = new QLShipper();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        DataTable dt;
        public frmGioHang()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void DataBind()
        {
            if (_message == "admin")
            {
                dgvGio.DataSource = bh.getGioHang1();
                dt = bh.getGioHang1();
            }
            else
            {
                dgvGio.DataSource = bh.getGioHang(_message);
                dt = bh.getGioHang(_message);
            }
        }
        private void frmGioHang_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string ngay = DateTime.Now.ToString().Trim();
            foreach (DataRow dtRow in dt.Rows)
            {
                hd.Them(hd.ranMaHD(), txtTimKiem.Text, _message, ngay, ship.getMaShipper(_message));
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (_message == "admin")
                    dgvGio.DataSource = bh.searchGio1(txtTimKiem.Text);
                else dgvGio.DataSource = bh.searchGio(txtTimKiem.Text, _message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Show();
            //Form.ActiveForm.BringToFront();
            this.Close();
        }
    }
}
