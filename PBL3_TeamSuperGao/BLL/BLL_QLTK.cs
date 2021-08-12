using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLTK
    {
        private static BLL_QLTK _Instance;
        public static BLL_QLTK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLTK();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLTK()
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
            foreach(TaiKhoan i in GetAllTaiKhoan())
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
            TaiKhoan k= new TaiKhoan();
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

        internal int GetIDTK(object text1, object text2)
        {
            throw new NotImplementedException();
        }
        //them tai khoan
        //public void AddAdmin()
    }
}
