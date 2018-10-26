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
    public partial class frmShipper : Form
    {
        QLShipper qls = new QLShipper();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public frmShipper()
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
                dgvShipper.DataSource = qls.getShipper1();
            else dgvShipper.DataSource = qls.getShipper(_message);
        }
        private void frmShipper_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtMaShipper.Text.Trim();
            string tennv = txtTenShipper.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cuahang = txtCuaHang.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string gioitinh = txtGTinh.Text.Trim();
            qls.Them(manv, tennv, gioitinh, Convert.ToInt32(sdt), diachi, Convert.ToInt32(cmnd), cuahang);
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mashipper = txtMaShipper.Text.Trim();
            string tenshipper = txtTenShipper.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cuahang = txtCuaHang.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string gioitinh = txtGTinh.Text.Trim();
            qls.Update(mashipper, tenshipper, gioitinh, Convert.ToInt32(sdt), diachi, Convert.ToInt32(cmnd), cuahang);
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mashipper = txtMaShipper.Text.Trim();
            qls.Delete(mashipper);
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaShipper.ResetText();
            txtTenShipper.ResetText();
            txtSDT.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtGTinh.ResetText();
            txtCuaHang.ResetText();
            DataBind();
        }

        private void dgvShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện tại
            int r = dgvShipper.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaShipper.Text =
            dgvShipper.Rows[r].Cells[0].Value.ToString();
            this.txtTenShipper.Text =
            dgvShipper.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            dgvShipper.Rows[r].Cells[3].Value.ToString();
            this.txtCMND.Text =
            dgvShipper.Rows[r].Cells[5].Value.ToString();
            this.txtCuaHang.Text =
            dgvShipper.Rows[r].Cells[6].Value.ToString();
            this.txtGTinh.Text =
            dgvShipper.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text =
            dgvShipper.Rows[r].Cells[4].Value.ToString();
        }
    }
}
