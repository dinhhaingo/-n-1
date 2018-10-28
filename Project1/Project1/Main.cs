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
        public string TenShopget(string matk)
        {
            string st = null;
            var tenshop = (from p in qly.HTCuaHangs
                           join p1 in qly.NhanViens on p.MaCH equals p1.CuaHang
                           where p1.MaTK==matk
                          select p);
            foreach (var x in tenshop)
            {
                st = x.TenCH;
            }
            return st;
        }
        public void DoiPass(string taikhoan,string newpass)
        {
            var pass = from p in qly.TaiKhoans
                     where p.MaTK == taikhoan
                     select p;
            foreach (TaiKhoan p in pass)
            {
                p.Password = newpass;
            }
            try
            {
                qly.SubmitChanges();
                MessageBox.Show("Đổi thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không đổi được mật khẩu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            p1.CuaHang,
                            p.Password
                        };
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MaTK"));
            dt.Columns.Add(new DataColumn("MaNV"));
            dt.Columns.Add(new DataColumn("TenNV"));
            dt.Columns.Add(new DataColumn("LoaiNV"));
            dt.Columns.Add(new DataColumn("CuaHang"));
            dt.Columns.Add(new DataColumn("Password"));
            foreach (var x in login.ToList())
            {
                dt.LoadDataRow(new object[] {x.MaTK,x.MaNV, x.TenNV, x.LoaiNV,x.CuaHang,x.Password }, true);
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

