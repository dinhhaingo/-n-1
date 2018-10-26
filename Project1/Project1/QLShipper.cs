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
    class QLShipper
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaShipper()
        {
            var ship = from p in qly.Shippers
                       select new { p.MaShipper };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaShipper"));
            foreach (var x in ship.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaShipper }, true);
            }
            return dt;
        }
        public DataTable getShipper(string MaNQL)
        {
            var ql = from q in (from p in qly.NhanViens
                                join p1 in qly.HTCuaHangs on p.CuaHang equals p1.MaCH
                                where p.MaNV == MaNQL
                                select new
                                {
                                    p.MaNV,
                                    p.CuaHang
                                })
                     join p2 in qly.Shippers on q.CuaHang equals p2.CuaHang
                     select new
                     {
                         p2.MaShipper,
                         p2.TenShipper,
                         p2.GioiTinh,
                         p2.SDT,
                         p2.DiaChi,
                         p2.CMND,
                         p2.CuaHang
                     };

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaShipper"));
            dt.Columns.Add(new DataColumn("TenShipper"));
            dt.Columns.Add(new DataColumn("GioiTinh"));
            dt.Columns.Add(new DataColumn("SDT"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("CMND"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            foreach (var s in ql.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaShipper, s.TenShipper, s.GioiTinh,
                  s.SDT,s.DiaChi,s.CMND,s.CuaHang}, true);
            }
            return dt;
        }
        public DataTable getShipper1()
        {
            var ql = from p in qly.Shippers
                       select new
                       {
                           p.MaShipper,
                           p.TenShipper,
                           p.GioiTinh,
                           p.SDT,
                           p.DiaChi,
                           p.CMND,
                           p.CuaHang
                       };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaShipper"));
            dt.Columns.Add(new DataColumn("TenShipper"));
            dt.Columns.Add(new DataColumn("GioiTinh"));
            dt.Columns.Add(new DataColumn("SDT"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("CMND"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            foreach (var s in ql.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaShipper, s.TenShipper, s.GioiTinh,
                  s.SDT,s.DiaChi,s.CMND,s.CuaHang}, true);
            }
            return dt;
        }
        public void Update(string MaShipper, string TenShipper, string GioiTinh, int SDT,
            string DiaChi, int CMND, string CuaHang)
        {
            var qls = from p in qly.Shippers
                       where p.MaShipper == MaShipper
                       select p;
            foreach (Shipper p in qls)
            {
                p.TenShipper = TenShipper;
                p.GioiTinh = GioiTinh;
                p.SDT = SDT;
                p.DiaChi = DiaChi;
                p.CMND = CMND;
                p.CuaHang = CuaHang;
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
        public void Delete(string mashipper)
        {
            //var phim = qly.Phims.Find(maphim);
            var ship = from p in qly.Shippers
                     where p.MaShipper == mashipper
                     select p;
            if (ship != null)
            {
                try
                {
                    qly.Shippers.DeleteAllOnSubmit(ship);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string mashipper, string tenshipper, string gioitinh, int sdt,
            string diachi, int cmnd, string cuahang)
        {
            var nv = new Shipper
            {
                MaShipper = mashipper,
                TenShipper = tenshipper,
                GioiTinh = gioitinh,
                SDT = sdt,
                DiaChi = diachi,
                CMND = cmnd,
                CuaHang = cuahang,
            };
            try
            {
                qly.Shippers.InsertOnSubmit(nv);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
