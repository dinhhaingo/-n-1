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
    public partial class frmNhanVien : Form
    {
        QLNhanVien qlnv = new QLNhanVien();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        Main me = new Main();
        public frmNhanVien()
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
                dgvNhanVien.DataSource = qlnv.getNhanVien1();
            else dgvNhanVien.DataSource = qlnv.getNhanVien(_message);
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataBind();         
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            cbLoaiNV.ResetText();
            cbGTinh.ResetText();
            txtTK.ResetText();
            txtCuaHang.ResetText();
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            string manv = txtMaNV.Text.Trim();
            string tennv = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cuahang = txtCuaHang.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string loainv = cbLoaiNV.Text.Trim();
            string tk = txtTK.Text.Trim();
            string gioitinh = cbGTinh.Text.Trim();
            qlnv.Update(manv, tennv, gioitinh,Convert.ToInt32(sdt), diachi,Convert.ToInt32(cmnd), loainv, cuahang, tk);
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            string tennv = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cuahang = txtCuaHang.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string tk = txtTK.Text.Trim();
            string loainv = cbLoaiNV.Text.Trim();
            string gioitinh = cbGTinh.Text.Trim();
            qlnv.Them(manv, tennv, gioitinh, Convert.ToInt32(sdt), diachi, Convert.ToInt32(cmnd), loainv, cuahang, tk,_message);
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            qlnv.Delete(manv);
            DataBind();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện tại
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text =
            dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtCMND.Text =
            dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtCuaHang.Text =
            dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            this.cbLoaiNV.Text =
            dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            this.cbGTinh.Text =
            dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text =
            dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtTK.Text =
            dgvNhanVien.Rows[r].Cells[8].Value.ToString();

        }
    }
}
