using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLCHBXH.Data_Layer
{
    class DL_User
    {
        DbDataContext db = new DbDataContext();
        public string LogIn(string UserName, string Pass)
        {
            var chucvu = db.spLogin(UserName, Pass).SingleOrDefault();
            if (chucvu != null) return chucvu.ChucVu;
            return null;
        }
        public bool LayUsername(string username)
        {
            List<DangNhap> listns = new List<DangNhap>();
            var lstns = db.spLogin_SelectUser(username).ToList();
            foreach (var n in lstns)
            {
                DangNhap ns = new DangNhap()
                {
                    UserName = n.UserName,
                    Pass = n.Pass,
                    ChucVu = n.ChucVu
                };
                listns.Add(ns);
            }
            return listns.Count > 0;
        }

        //public bool LayPass(string username)
        //{
        //    List<DangNhap> listns = new List<DangNhap>();
        //    var lstns = db.spLogin_SelectPass(username).ToList();
        //    foreach (var n in lstns)
        //    {
        //        DangNhap ns = new DangNhap()
        //        {
        //            Pass = n.Pass
        //        };
        //        listns.Add(ns);
        //    }
        //    return listns.Count > 0;
        //}

        //public void ThemTaiKhoan(DangNhap dn)
        //{
        //    db.spLogin_Insert(dn.UserName, dn.Pass, dn.ChucVu);
        //}

        public void SuaPass(DangNhap dn)
        {
           db.spLogin_Update(dn.UserName, dn.Pass);
        }
    }
}
