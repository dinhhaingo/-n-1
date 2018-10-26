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
    public partial class frmKhachHang : Form
    {
        QLKhachHang qlkh = new QLKhachHang();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvKhachHang.DataSource = qlkh.getKhachHang();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text.Trim();
            qlkh.Delete(makh);
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text.Trim();
            string tenkh = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string loaikh = txtLoaiKH.Text.Trim();
            qlkh.Them(makh, tenkh, Convert.ToInt32(sdt), diachi, Convert.ToInt32(cmnd), loaikh);
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtLoaiKH.ResetText();
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text.Trim();
            string tenkh = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string loaikh = txtLoaiKH.Text.Trim();
            qlkh.Update(makh, tenkh, Convert.ToInt32(sdt), diachi, Convert.ToInt32(cmnd), loaikh);
            DataBind();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaKH.Text =
            dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text =
            dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.txtCMND.Text =
            dgvKhachHang.Rows[r].Cells[5].Value.ToString();
            this.txtLoaiKH.Text =
            dgvKhachHang.Rows[r].Cells[6].Value.ToString();
            this.txtDiaChi.Text =
            dgvKhachHang.Rows[r].Cells[4].Value.ToString();

        }
    }
}
