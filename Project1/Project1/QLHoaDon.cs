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
    class QLHoaDon
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
        public DataTable getHoaDon()
        {
            var hd = from p in qly.HoaDons
                     select new
                     {
                         p.MaHD,
                         p.MaKH,
                         p.MaNV,
                         p.Ngay,
                         p.Shipper
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaHD"));
            dt.Columns.Add(new DataColumn("MaKH"));
            dt.Columns.Add(new DataColumn("MaNV"));
            dt.Columns.Add(new DataColumn("Ngay"));
            dt.Columns.Add(new DataColumn("Shipper"));
            foreach (var s in hd.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaHD, s.MaKH, s.MaNV, s.Ngay, s.Shipper }, true);
            }
            return dt;
        }
        public void Them(string mahd, string makh, string manv,string ngay , string shipper)
        {
            var hd = new HoaDon
            {
                MaHD=mahd,
                MaKH = makh,
                MaNV = manv,
                Ngay=Convert.ToDateTime(ngay),
                Shipper=shipper
            };
            try
            {
                qly.HoaDons.InsertOnSubmit(hd);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(string MaHD, string MaKH, string MaNV, string Ngay, string Shipper)
        {
            var hd = from p in qly.HoaDons
                     where p.MaHD == MaHD
                     select p;
            foreach (HoaDon p in hd)
            {
                p.MaKH = MaKH;
                p.MaNV = MaNV;
                p.Ngay = Convert.ToDateTime(Ngay);
                p.Shipper = Shipper;
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
        public void Delete(string mahd)
        {
            //var phim = qly.Phims.Find(maphim);
            var hd = from p in qly.HoaDons
                     where p.MaHD == mahd
                     select p;
            if (hd != null)
            {
                try
                {
                    qly.HoaDons.DeleteAllOnSubmit(hd);
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
