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
    class BanHang
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getSanPham()
        {
            var sp = from p in qly.SanPhams
                     join  p1 in qly.NhaCungCaps on p.NCC equals p1.MaNCC
                     select new
                     {
                         p.MaSP,
                         p.TenSP,
                         p.LoaiSP,
                         p1.TenNCC,
                         p.Gia,
                         p.Photo
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("LoaiSP"));
            dt.Columns.Add(new DataColumn("NCC"));
            dt.Columns.Add(new DataColumn("Gia"));
            dt.Columns.Add(new DataColumn("Photo"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaSP, s.TenSP, s.LoaiSP, s.TenNCC, s.Gia,s.Photo }, true);
            }
            return dt;

        }
        public DataTable getGioHang(string manql)
        {
            var sp = from p in qly.GIOHANGs
                     join p1 in qly.NhanViens on p.MACH equals p1.CuaHang
                     where p1.MaNV==manql
                     select new
                     {
                         p.MAKH,
                         p.MASP,
                         p.Size,
                         p.MACH,
                         p.SOLUONG
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaKH"));
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("MaCH"));

            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MAKH, s.MASP,s.MACH, s.Size, s.SOLUONG}, true);
            }
            return dt;

        }
        public DataTable getGioHang1()
        {
            var sp = from p in qly.GIOHANGs
                     select new
                     {
                         p.MAKH,
                         p.MASP,
                         p.Size,
                         p.MACH,
                         p.SOLUONG
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaKH"));
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sp.ToList())
            {
                dt.LoadDataRow(new object[] { s.MAKH, s.MASP,s.MACH,s.Size, s.SOLUONG }, true);
            }
            return dt;

        }
        public DataTable searchGio(string makh, string nql)
        {
            var sanpham = from p in qly.GIOHANGs
                          join p1 in qly.NhanViens on p.MACH equals p1.CuaHang
                          where p1.MaNV==nql
                          where p.MAKH==makh
                          select new
                          {
                              p.MAKH,
                              p.MASP,
                              p.MACH,
                              p.Size,
                              p.SOLUONG
                          };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sanpham.ToList())
            {
                dt.LoadDataRow(new object[] { s.MAKH, s.MASP, s.MACH, s.Size, s.SOLUONG }, true);
            }
            return dt;
        }
        public string getMaCH(string manql)
        {
            var ch = from p in qly.NhanViens
                     where p.MaNV == manql
                     select p.CuaHang;
            return ch.ToString();
        }
        public DataTable searchGio1(string makh)
        {
            var sanpham = from p in qly.GIOHANGs
                          where p.MAKH==makh
                          select new
                          {
                              p.MAKH,
                              p.MASP,
                              p.MACH,
                              p.Size,
                              p.SOLUONG
                          };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaSP"));
            dt.Columns.Add(new DataColumn("TenSP"));
            dt.Columns.Add(new DataColumn("MaCH"));
            dt.Columns.Add(new DataColumn("Size"));
            dt.Columns.Add(new DataColumn("SoLuong"));
            foreach (var s in sanpham.ToList())
            {
                dt.LoadDataRow(new object[] { s.MAKH, s.MASP, s.MACH, s.Size, s.SOLUONG }, true);
            }
            return dt;
        }
        
        public void Them(string makh,string masp, string mach,string size, int soluong)
        {
            var gh = new GIOHANG
            {
                MAKH = makh,
                MASP = masp,
                MACH = mach,
                Size = size,
                SOLUONG = soluong
            };
            try
            {
                qly.GIOHANGs.InsertOnSubmit(gh);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(string makh,string masp,string mach,string size, int soluong)
        {
            var gh = from p in qly.GIOHANGs
                       where p.MAKH == makh
                       where p.MASP==masp
                       where p.MACH==mach
                       select p;
            foreach (GIOHANG p in gh)
            {
                p.Size = size;
                p.SOLUONG = soluong;
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
        public void Delete(string makh,string masp,string mach,string size)
        {
            //var phim = qly.Phims.Find(maphim);
            var gh = from p in qly.GIOHANGs
                     where p.MAKH == makh
                     where p.MASP == masp
                     where p.MACH == mach
                     where p.Size == size
                     select p;
            if (gh != null)
            {
                try
                {
                    qly.GIOHANGs.DeleteAllOnSubmit(gh);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int soluong;
        public int SoLuong(string masp,string manql,string size)
        {
            
            var sl = from p in qly.Khos
                     join p1 in qly.NhanViens on p.MaCH equals p1.CuaHang
                     where p.MaSP == masp
                     where p1.MaNV == manql
                     where p.Size == size
                     select p.SoLuong;
            foreach (var s in sl.ToList())
            {
                soluong = Convert.ToInt32(s);
            }
            return soluong;
        }
        public DataTable getCH(string masp,string size, int sl)
        {
            var ch = from p in qly.Khos
                     join p1 in qly.HTCuaHangs on p.MaCH equals p1.MaCH
                     where p.MaSP == masp
                     where p.Size == size
                     where p.SoLuong == sl
                     select p1.TenCH;
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("TenCH"));
            foreach (var s in ch.ToList())
            {
                dt.LoadDataRow(new object[] { s }, true);
            }
            return dt;
        }
    }
}
