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
    public partial class frmBanHang : Form
    {
        
        QLNhanVien qlnv = new QLNhanVien();
        BanHang bh = new BanHang();
        
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        //DataTable tt;
        public frmBanHang()
        {
            InitializeComponent();
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void picHinh_Click(object sender, EventArgs e)
        {

        }
        private void DataBind()
        {
            dgvBanHang.DataSource = bh.getSanPham();
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            DataBind();
            gbThongTin.Visible = false;
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbThongTin.Visible = true;
            int r = dgvBanHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.lblMaSP1.Text =
            dgvBanHang.Rows[r].Cells[1].Value.ToString();
            this.lblTenSP1.Text =
            dgvBanHang.Rows[r].Cells[2].Value.ToString();
            this.lblLoaiSP1.Text =
            dgvBanHang.Rows[r].Cells[3].Value.ToString();
            this.lblNCC1.Text =
            dgvBanHang.Rows[r].Cells[4].Value.ToString();
            this.lblGia1.Text =
            dgvBanHang.Rows[r].Cells[5].Value.ToString();
            this.picHinh.Image= (System.Drawing.Image)
            dgvBanHang.Rows[r].Cells[0].FormattedValue;
        }

        private void cbSize_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString());
            lblSoLuong1.Text = bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString();
        }
        int sl;
        string kh;
        string message;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtKH.Text.Trim().Equals("") || txtSL.Text.Trim().Equals(""))
                MessageBox.Show("Không để trống mục khách hàng và số lượng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                //try
                //{
                    sl = Convert.ToInt32(txtSL.Text);
                    kh = txtKH.Text.Trim();
                    if (sl > Convert.ToInt32(lblSoLuong1.Text))
                    {
                        message = bh.getCH1(lblMaSP1.Text, cbSize.Text, Convert.ToInt32(txtSL.Text));
                        //var ch = from p in qly.Khos
                        //         join p1 in qly.HTCuaHangs on p.MaCH equals p1.MaCH
                        //         where p.MaSP == lblMaSP1.Text
                        //         where p.Size == cbSize.Text
                        //         where p.SoLuong == Convert.ToInt32(txtSL.Text)
                        //         select p1.TenCH;
                        //foreach (var s in ch.ToList())
                        //{
                        //    message = s+",";
                        ////MessageBox.Show(s.ToString());
                        
                        //}
                        //MessageBox.Show(message);
                        MessageBox.Show("Số lượng trong kho không đủ, bạn nhập lại số lượng cần thêm hoặc đến các cửa hàng khác trong hệ thống đang còn sản phẩm: "+message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else bh.Them(kh, lblMaSP1.Text, bh.getMaCH(_message), cbSize.Text, sl);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Dữ liệu nhập vào sai, mời nhập lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Hide ();
            frmGioHang frm = new frmGioHang();
            frm.ShowDialog();
            
        }

        private void cbSize_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString());
            lblSoLuong1.Text = bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString();
        }

        //private void cbSize_TextChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString());
        //    lblSoLuong1.Text = bh.SoLuong(lblMaSP1.Text, _message, cbSize.Text).ToString();
        //}
    }
}
