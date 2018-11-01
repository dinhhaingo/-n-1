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
    public class QLNhanVien
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaNV()
        {
            var phim = from p in qly.NhanViens
                       select new { p.MaNV };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaNV"));
            foreach (var x in phim.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaNV }, true);
            }
            return dt;
        }
        public DataTable getNhanVien(string MaNQL)
        {
            var phim = from p in qly.NhanViens
                       where p.NQL == MaNQL
                       select new
                       {
                           p.MaNV,
                           p.TenNV,
                           p.GioiTinh,
                           p.SDT,
                           p.DiaChi,
                           p.CMND,
                           p.LoaiNV,
                           p.CuaHang,
                           p.MaTK
                       };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaNV"));
            dt.Columns.Add(new DataColumn("TenNV"));
            dt.Columns.Add(new DataColumn("GioiTinh"));
            dt.Columns.Add(new DataColumn("SDT"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("CMND"));
            dt.Columns.Add(new DataColumn("LoaiNV"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            dt.Columns.Add(new DataColumn("MaTK"));
            foreach (var s in phim.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaNV, s.TenNV, s.GioiTinh,
                  s.SDT,s.DiaChi,s.CMND,s.LoaiNV,s.CuaHang,s.MaTK}, true);
            }
            return dt;
        }
        public DataTable getNhanVien1()
        {
            var phim = from p in qly.NhanViens
                       
                       select new
                       {
                           p.MaNV,
                           p.TenNV,
                           p.GioiTinh,
                           p.SDT,
                           p.DiaChi,
                           p.CMND,
                           p.LoaiNV,
                           p.CuaHang,
                           p.MaTK
                       };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaNV"));
            dt.Columns.Add(new DataColumn("TenNV"));
            dt.Columns.Add(new DataColumn("GioiTinh"));
            dt.Columns.Add(new DataColumn("SDT"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("CMND"));
            dt.Columns.Add(new DataColumn("LoaiNV"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            dt.Columns.Add(new DataColumn("MaTK"));
            foreach (var s in phim.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaNV, s.TenNV, s.GioiTinh,
                  s.SDT,s.DiaChi,s.CMND,s.LoaiNV,s.CuaHang,s.MaTK}, true);
            }
            return dt;
        }
        public void Update(string MaNV, string TenNV, string GioiTinh, int SDT, 
            string DiaChi, int CMND, string LoaiNV, string CuaHang,string  MaTK)
        {
            var qlnv = from p in qly.NhanViens
                         where p.MaNV == MaNV
                         select p;
            foreach (NhanVien p in qlnv)
            {
                p.TenNV = TenNV;
                p.GioiTinh = GioiTinh;
                p.SDT = SDT;
                p.DiaChi = DiaChi;
                p.CMND = CMND;
                p.LoaiNV = LoaiNV;
                p.CuaHang = CuaHang;
                p.MaTK = MaTK;
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
        public void Delete(string manv)
        {
            //var phim = qly.Phims.Find(maphim);
            var nv = from p in qly.NhanViens
                       where p.MaNV == manv
                       select p;
            if (nv != null)
            {
                try
                {
                    qly.NhanViens.DeleteAllOnSubmit(nv);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string manv, string tennv, string gioitinh, int sdt,
            string diachi, int cmnd, string loainv, string cuahang, string matk,string manql)
        {
            var nv = new NhanVien
            {
                MaNV = manv,
                TenNV = tennv,
                GioiTinh = gioitinh,
                SDT = sdt,
                DiaChi = diachi,
                CMND = cmnd,
                LoaiNV = loainv,
                CuaHang = cuahang,
                MaTK=matk,
                NQL=manql
            };
            try
            {
                qly.NhanViens.InsertOnSubmit(nv);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
