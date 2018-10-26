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
    class QLKhachHang
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaKH()
        {
            var kh = from p in qly.KhachHangs
                       select new { p.MaKH };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaKH"));
            foreach (var x in kh.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaKH }, true);
            }
            return dt;
        }
        public DataTable getKhachHang()
        {
            var kh = from p in qly.KhachHangs
                       select new
                       {
                           p.MaKH,
                           p.TenKH,
                           p.SDT,
                           p.DiaChi,
                           p.CMND,
                           p.LoaiKH
                       };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaKH"));
            dt.Columns.Add(new DataColumn("TenKH"));
            dt.Columns.Add(new DataColumn("SDT"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("CMND"));
            dt.Columns.Add(new DataColumn("LoaiKH"));
            foreach (var s in kh.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaKH, s.TenKH, s.SDT,s.DiaChi,s.CMND,s.LoaiKH}, true);
            }
            return dt;
        }
        public void Update(string MaKH, string TenKH, int SDT, string DiaChi, int CMND, string LoaiKH)
        {
            var kh = from p in qly.KhachHangs
                       where p.MaKH == MaKH
                       select p;
            foreach (KhachHang p in kh)
            {
                p.TenKH = TenKH;
                p.SDT = SDT;
                p.DiaChi = DiaChi;
                p.CMND = CMND;
                p.LoaiKH = LoaiKH;
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
        public void Delete(string makh)
        {
            //var phim = qly.Phims.Find(maphim);
            var kh = from p in qly.KhachHangs
                     where p.MaKH == makh
                     select p;
            if (kh != null)
            {
                try
                {
                    qly.KhachHangs.DeleteAllOnSubmit(kh);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string makh, string tenkh, int sdt, string diachi, int cmnd, string loaikh)
        {
            var kh = new KhachHang
            {
                MaKH = makh,
                TenKH = tenkh,
                SDT = sdt,
                DiaChi = diachi,
                CMND = cmnd,
                LoaiKH = loaikh
            };
            try
            {
                qly.KhachHangs.InsertOnSubmit(kh);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
