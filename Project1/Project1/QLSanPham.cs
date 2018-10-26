using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project1
{
    class QLSanPham
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaSP()
        {
            var sp = from p in qly.SanPhams
                     select new { p.MaSP };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            foreach (var x in sp.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaSP }, true);
            }
            return dt;
        }
        public DataTable getSanPham()
        {
            var sp = from p in qly.SanPhams
                     select new
                     {
                         p.MaSP,
                         p.TenSP,
                         p.LoaiSP,
                         p.NCC,
                         p.Gia
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("LoaiSP"));
            dt.Columns.Add(new DataColumn("NCC"));
            dt.Columns.Add(new DataColumn("Gia"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP, s.TenSP, s.LoaiSP, s.NCC, s.Gia}, true);
            }
            return dt;
        }

        public DataTable getSanPham1(string masp)
        {
            var sp = from p in qly.SanPhams
                     where p.MaSP == masp
                     select new
                     {
                         p.TenSP,
                         p.LoaiSP,
                         p.NCC,
                         p.Gia
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("LoaiSP"));
            dt.Columns.Add(new DataColumn("NCC"));
            dt.Columns.Add(new DataColumn("Gia"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.TenSP, s.LoaiSP, s.NCC, s.Gia }, true);
            }
            return dt;
        }
        public void Update(string MaSP, string TenSP, string LoaiSP, string NCC, int Gia)
        {
            var sp = from p in qly.SanPhams
                     where p.MaSP == MaSP
                     select p;
            foreach (SanPham p in sp)
            {
                p.TenSP = TenSP;
                p.LoaiSP = LoaiSP;
                p.NCC = NCC;
                p.Gia = Gia;
            }
            try
            {
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete(string masp)
        {
            //var phim = qly.Phims.Find(maphim);
            var sp = from p in qly.SanPhams
                     where p.MaSP == masp
                     select p;
            if (sp != null)
            {
                try
                {
                    qly.SanPhams.DeleteAllOnSubmit(sp);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string masp, string tensp, string loaisp, string ncc, int gia)
        {
            var sp = new SanPham
            {
                MaSP = masp,
                TenSP = tensp,
                LoaiSP = loaisp,
                NCC = ncc,
                Gia = gia
                };
            try
            {
                qly.SanPhams.InsertOnSubmit(sp);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
