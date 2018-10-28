using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmSanPham : Form
    {
        QLSanPham qlsp = new QLSanPham();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        MemoryStream ms;
        
        private byte[] arrImage;

        public frmSanPham()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvSanPham.DataSource = qlsp.getSanPham();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            string tensp = txtTenSP.Text.Trim();
            string loaisp = txtLoaiSP.Text.Trim();
            string ncc = txtNCC.Text.Trim();
            string gia = txtGia.Text.Trim();
            qlsp.Them(masp, tensp, loaisp, ncc, Convert.ToInt32(gia));
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            string tensp = txtTenSP.Text.Trim();
            string loaisp = txtLoaiSP.Text.Trim();
            string ncc = txtNCC.Text.Trim();
            string gia = txtGia.Text.Trim();
            qlsp.Update(masp, tensp, loaisp, ncc, Convert.ToInt32(gia));
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text.Trim();
            qlsp.Delete(masp);
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtLoaiSP.ResetText();
            txtNCC.ResetText();
            txtGia.ResetText();
            DataBind();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                ms = new MemoryStream();
                picHinh.Image.Save(ms, picHinh.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaSP.Text =
            dgvSanPham.Rows[r].Cells[1].Value.ToString();
            this.txtTenSP.Text =
            dgvSanPham.Rows[r].Cells[2].Value.ToString();
            this.txtLoaiSP.Text =
            dgvSanPham.Rows[r].Cells[3].Value.ToString();
            this.txtNCC.Text =
            dgvSanPham.Rows[r].Cells[4].Value.ToString();
            this.txtGia.Text =
            dgvSanPham.Rows[r].Cells[5].Value.ToString();
            this.picHinh.Image = (System.Drawing.Image)
            dgvSanPham.Rows[r].Cells[0].FormattedValue;
        }
    }
}
