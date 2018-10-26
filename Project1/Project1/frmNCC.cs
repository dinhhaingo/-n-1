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
    public partial class frmNCC : Form
    {
        QLNCC qlncc = new QLNCC();
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public frmNCC()
        {
            InitializeComponent();
        }

        private void DataBind()
        {
            dgvNCC.DataSource = qlncc.getNCC();
        }
        private void frmNCC_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text.Trim();
            string tenncc = txtTenNCC.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            qlncc.Them(mancc, tenncc, diachi, Convert.ToInt32(sdt));
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text.Trim();
            qlncc.Delete(mancc);
            DataBind();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mancc = txtMaNCC.Text.Trim();
            string tenncc = txtTenNCC.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            qlncc.Update(mancc, tenncc, diachi, Convert.ToInt32(sdt));
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            DataBind();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNCC.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNCC.Text =
            dgvNCC.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text =
            dgvNCC.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            dgvNCC.Rows[r].Cells[3].Value.ToString();
            this.txtDiaChi.Text =
            dgvNCC.Rows[r].Cells[2].Value.ToString();
        }
    }
}
