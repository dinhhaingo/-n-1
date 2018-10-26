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
    class QLChiTietHD
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaHD()
        {
            var hd = from p in qly.HoaDons
                     select new { p.MaHD };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaHD"));
            foreach (var x in hd.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaHD }, true);
            }
            return dt;
        }
        public DataTable getCTHoaDon()
        {
            var hd = from p in qly.ChiTietHDs
                     select new
                     {
                         p.MaHD,
                        p.MaSP,
                        p.SoLuong
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaHD"));
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in hd.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaHD, s.MaSP, s.SoLuong }, true);
            }
            return dt;
        }
        public DataTable getCTHD(string mahd)
        {
            var sp = from p in qly.ChiTietHDs
                     join p1 in qly.SanPhams on p.MaSP equals p1.MaSP
                     where p.MaHD == mahd
                     select new
                     {
                        p.MaSP,
                        p1.TenSP,
                        p.SoLuong
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP,s.TenSP, s.SoLuong }, true);
            }
            return dt;
        }
        public void Them(string mahd, string masp, int soluong)
        {
            var hd = new ChiTietHD
            {
                MaHD = mahd,
                MaSP = masp,
                SoLuong = soluong,
            };
            try
            {
                qly.ChiTietHDs.InsertOnSubmit(hd);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(string MaHD, string MaSP, int SoLuong)
        {
            var hd = from p in qly.ChiTietHDs
                     where p.MaHD == MaHD
                     where p.MaSP==MaSP
                     select p;
            foreach (ChiTietHD p in hd)
            {
                p.SoLuong = SoLuong;
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
        public void Delete(string mahd,string masp)
        {
            //var phim = qly.Phims.Find(maphim);
            var hd = from p in qly.ChiTietHDs
                     where p.MaHD == mahd
                     where p.MaSP==masp
                     select p;
            if (hd != null)
            {
                try
                {
                    qly.ChiTietHDs.DeleteAllOnSubmit(hd);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
