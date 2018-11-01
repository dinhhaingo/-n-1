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
    class QLKho
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getKho()
        {
            var sp = from p in qly.Khos
                     join p1 in qly.SanPhams on p.MaSP equals p1.MaSP
                     select new
                     {
                         p.MaSP,
                         p1.TenSP,
                         p.MaCH,
                         p.Size,
                         p.SoLuong
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP,s.TenSP, s.MaCH, s.Size, s.SoLuong }, true);
            }
            return dt;
        }
        public DataTable getKho1(string manql)
        {
            var sp = from p in qly.NhanViens
                     join p1 in qly.Khos on p.CuaHang equals p1.MaCH
                     join p2 in qly.SanPhams on p1.MaSP equals p2.MaSP
                     where p.MaNV == manql
                     select new
                     {
                         p1.MaSP,
                         p2.TenSP,
                         p1.MaCH,
                         p1.Size,
                         p1.SoLuong
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP,s.TenSP, s.MaCH, s.Size, s.SoLuong }, true);
            }
            return dt;
        }
        public void Update(string masp, string mach, string size, int soluong)
        {
            var qlk = from p in qly.Khos
                       where p.MaSP == masp
                       where p.MaCH==mach
                       where p.Size==size
                       select p;
            foreach (Kho p in qlk)
            {
                p.SoLuong = soluong;
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
        public void Delete(string masp,string mach,string size)
        {
            //var phim = qly.Phims.Find(maphim);
            var kho = from p in qly.Khos
                     where p.MaSP == masp
                      where p.MaCH==mach
                      where p.Size==size
                     select p;
            if (kho!= null)
            {
                try
                {
                    qly.Khos.DeleteAllOnSubmit(kho);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string masp, string mach, string size, int soluong)
        {
            var kho = new Kho
            {
                MaSP = masp,
                MaCH = mach,
                Size = size,
                SoLuong = soluong
            };
            try
            {
                qly.Khos.InsertOnSubmit(kho);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable searchSP(string tensp, string nql)
        {
            var sanpham = from p in qly.Khos
                            join p1 in qly.SanPhams on p.MaSP equals p1.MaSP
                            join p2 in qly.NhanViens on p.MaCH equals p2.CuaHang
                            where p2.MaNV ==nql
                            where p1.TenSP.Contains(tensp)
                            select new
                            {
                                p.MaSP,
                                p1.TenSP,
                                p.MaCH,
                                p.Size,
                                p.SoLuong
                            };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sanpham.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP, s.TenSP, s.MaCH, s.Size,s.SoLuong }, true);
            }
            return dt;
        }
    }
}
