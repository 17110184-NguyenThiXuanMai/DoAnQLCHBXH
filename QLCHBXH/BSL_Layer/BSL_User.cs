using QLCHBXH.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBXH.BSL_Layer
{
    class BSL_User
    {
        DL_User us = new DL_User();
        public string LogIn(string UserName, string Pass)
        {
            return us.LogIn(UserName, Pass);
        }
        public bool LayUsername(string username)
        {
            return us.LayUsername(username);
        }

        //public bool LayPass(string username)
        //{
        //    return us.LayPass(username);
        //}
        //public void ThemTaiKhoan(string manv, string pass, string chucvu)
        //{
        //    DangNhap dn = new DangNhap();
        //    dn.UserName = manv;
        //    dn.Pass = pass;
        //    dn.ChucVu = chucvu;
        //    us.ThemTaiKhoan(dn);
        //}
        public void SuaPass(DangNhap dn)
        {
            us.SuaPass(dn);
        }
    }
}
