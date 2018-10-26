using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    class Main
    {
        QuanLyShopDataContext qly = new QuanLyShopDataContext();
        public string TenShopget()
        {
            string st = null;
            var tenshop = (from p in qly.HTCuaHangs
                          select p);
            foreach (var x in tenshop)
            {
                st = x.TenCH;
            }
            return st;
        }
    
        public DataTable Login(string user, string pass)
        {
            var login = from p in qly.TaiKhoans
                        join p1 in qly.NhanViens on p.MaTK equals p1.MaTK
                        where p.MaTK == user && p.Password == pass
                        select new
                        {
                            p.MaTK,
                            p1.MaNV,
                            p1.TenNV,
                            p1.LoaiNV,
                            p1.CuaHang
                        };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaTK"));
            dt.Columns.Add(new DataColumn("MaNV"));
            dt.Columns.Add(new DataColumn("TenNV"));
            dt.Columns.Add(new DataColumn("LoaiNV"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            foreach (var x in login.ToList())
            {
                dt.LoadDataRow(new object[] {x.MaTK,x.MaNV, x.TenNV, x.LoaiNV,x.CuaHang }, true);
            }
            return dt;
        }

        public void LoginSuccess(string user)
        {
            var tk = from p in qly.TaiKhoans
                     select p;
            foreach (var x in tk)
            {
                x.Login = user;
            }
            try
            {
                qly.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

