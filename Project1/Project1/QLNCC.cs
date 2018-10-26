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
    class QLNCC
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public DataTable getMaNCC()
        {
            var ncc = from p in qly.NhaCungCaps
                     select new { p.MaNCC };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaNCC"));
            foreach (var x in ncc.ToList())
            {
                dt.LoadDataRow(new object[] { x.MaNCC }, true);
            }
            return dt;
        }
        public DataTable getNCC()
        {
            var ncc = from p in qly.NhaCungCaps
                     select new
                     {
                         p.MaNCC,
                         p.TenNCC,
                         p.DiaChi,
                         p.SDT,
                     };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaNCC"));
            dt.Columns.Add(new DataColumn("TenNCC"));
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns.Add(new DataColumn("SDT"));
            foreach (var s in ncc.ToList())
            {
                dt.LoadDataRow(new object[] { s.MaNCC, s.TenNCC, s.DiaChi, s.SDT }, true);
            }
            return dt;
        }
        public void Update(string MaNCC, string TenNCC, string DiaChi, int SDT)
        {
            var ncc = from p in qly.NhaCungCaps
                     where p.MaNCC == MaNCC
                     select p;
            foreach (NhaCungCap p in ncc)
            {
                p.TenNCC = TenNCC;
                p.SDT = SDT;
                p.DiaChi = DiaChi;
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
        public void Delete(string mancc)
        {
            //var phim = qly.Phims.Find(maphim);
            var ncc = from p in qly.NhaCungCaps
                     where p.MaNCC == mancc
                     select p;
            if (ncc != null)
            {
                try
                {
                    qly.NhaCungCaps.DeleteAllOnSubmit(ncc);
                    qly.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xoá được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Them(string mancc, string tenncc, string diachi, int sdt)
        {
            var ncc = new NhaCungCap
            {
                MaNCC = mancc,
                TenNCC = tenncc,
                SDT = sdt,
                DiaChi = diachi
            };
            try
            {
                qly.NhaCungCaps.InsertOnSubmit(ncc);
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
