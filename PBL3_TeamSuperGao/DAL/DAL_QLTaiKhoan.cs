using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLTaiKhoan
    {
        private static DAL_QLTaiKhoan _Instance;
        public static DAL_QLTaiKhoan Instance
        {
            get
            {
                if(_Instance == null)

                {
                    _Instance = new DAL_QLTaiKhoan();
                }
                return _Instance;
            }
            private set { }
        }
        public List<TaiKhoan> Show()
        {
            DTDoAn db = new DTDoAn();
            var ListTaiKhoan = db.TaiKhoans;
            return ListTaiKhoan.ToList();
        }
        public int Add(TaiKhoan tk)
        {
            DTDoAn db = new DTDoAn();
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
            return tk.IDTaiKhoan;
        }
        public void Delete(int ID)
        {
            DTDoAn db = new DTDoAn();
            TaiKhoan temp =  db.TaiKhoans.Find(ID);
            db.TaiKhoans.Remove(temp);
            db.SaveChanges();
        }
        public void Edit(TaiKhoan tk)
        {
            DTDoAn db = new DTDoAn();
            var tkedit = db.TaiKhoans.Where(p => p.UserName == tk.UserName).FirstOrDefault();
            tkedit.PassWord = tk.PassWord;
            db.SaveChanges();
        }
        private DAL_QLTaiKhoan()
        {
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.TaiKhoans;
            return l1.ToList();
        }
        //lay ID tai khoan theo ten dn va mk
        public int GetIDTK(string tendn, string pw)
        {
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
                if (i.PassWord.Contains(pw) && i.UserName.Contains(tendn)) return i.IDTaiKhoan;
            }
            return -1;
        }
        //doi mat khau
        public bool ChangePassword(string tk, string mkcu, string mkmoi)
        {
            DTDoAn st = new DTDoAn();
            var t = st.TaiKhoans.Where(p => p.UserName == tk);
            TaiKhoan k = new TaiKhoan();
            foreach (var u in t)
            {
                k = u;
            }
            bool i = false;
            if (k.PassWord.CompareTo(mkcu) == 0)
            {
                k.PassWord = mkmoi;
                i = true;
            }
            st.SaveChanges();
            return i;
        }
        //them tai khoan
        //public void AddAdmin()

    }
}
