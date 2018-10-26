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
    public partial class frmHoaDon : Form
    {
        QLHoaDon qlhd = new QLHoaDon();
        QLChiTietHD qlcthd = new QLChiTietHD();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        //DataTable tt;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvHD.DataSource = qlhd.getHoaDon();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataBind();
            gbCTHD.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text.Trim();
            string makh = txtMaKH.Text.Trim();
            string manv = txtMaNV.Text.Trim();
            string ngay = dtpNgay.Value.ToString();
            string shipper = txtShipper.Text.Trim();
            qlhd.Update(mahd, makh, manv,ngay,shipper);
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text.Trim();
            qlhd.Delete(mahd);
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();
            txtMaKH.ResetText();
            txtMaNV.ResetText();
            dtpNgay.ResetText();
            txtShipper.ResetText();
            DataBind();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện tại
                int r = dgvHD.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                txtMaHD.Text =
                dgvHD.Rows[r].Cells[0].Value.ToString();
                txtMaKH.Text =
                dgvHD.Rows[r].Cells[1].Value.ToString();
                txtMaNV.Text =
                dgvHD.Rows[r].Cells[2].Value.ToString();
                dtpNgay.Text =
                dgvHD.Rows[r].Cells[3].Value.ToString();
                txtShipper.Text =
                dgvHD.Rows[r].Cells[4].Value.ToString();
                gbCTHD.Visible = true;
                dgvCTHD.DataSource = qlcthd.getCTHD(txtMaHD.Text);
                //int r = dgvHD.CurrentCell.RowIndex;
                //MessageBox.Show(dgvHD.Rows[r].Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbHD_Enter(object sender, EventArgs e)
        {

        }
    }
}
