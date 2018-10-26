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
    public partial class frmKho : Form
    {
        QLKho qlk = new QLKho();
        QLSanPham qlsp = new QLSanPham();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        DataTable tt;
        public frmKho()
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
                dgvKho.DataSource = qlk.getKho();
            else dgvKho.DataSource = qlk.getKho1(_message);
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            DataBind();
            gbThongTin.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.ResetText();
            txtMaCH.ResetText();
            txtSize.ResetText();
            txtSoLuong.ResetText();
            txtTimKiem.ResetText();
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            string mach = txtMaCH.Text.Trim();
            string size = txtSize.Text.Trim();
            string soluong = txtSoLuong.Text.Trim();
            qlk.Them(masp, mach, size, Convert.ToInt32(soluong));
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            string mach = txtMaCH.Text.Trim();
            string size = txtSize.Text.Trim();
            qlk.Delete(masp,mach,size);
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            string mach = txtMaCH.Text.Trim();
            string size = txtSize.Text.Trim();
            string soluong = txtSoLuong.Text.Trim();
            qlk.Update(masp, mach, size, Convert.ToInt32(soluong));
            DataBind();
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện tại
            int r = dgvKho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaSP.Text =
            dgvKho.Rows[r].Cells[0].Value.ToString();
            this.txtMaCH.Text =
            dgvKho.Rows[r].Cells[2].Value.ToString();
            this.txtSize.Text =
            dgvKho.Rows[r].Cells[3].Value.ToString();
            this.txtSoLuong.Text =
            dgvKho.Rows[r].Cells[4].Value.ToString();
            gbThongTin.Visible = true;
            tt = qlsp.getSanPham1(txtMaSP.Text);
            lblTenSP1.Text = tt.Rows[0][0].ToString();
            lblLoaiSP1.Text = tt.Rows[0][1].ToString();
            lblNCC1.Text = tt.Rows[0][2].ToString();
            lblGia1.Text = tt.Rows[0][3].ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvKho.DataSource = qlk.searchSP(txtTimKiem.Text,_message);
        }
    }
}
