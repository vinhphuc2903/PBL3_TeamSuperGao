using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLDanhMuc
    {
        private static DAL_QLDanhMuc _Instance;
        public static DAL_QLDanhMuc Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLDanhMuc();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLDanhMuc()
        {

        }
        //tra ve tat ca danh muc
        public List<DanhMucMon> GetDanhMucMon()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.DanhMucMons;
            return l1.ToList();
        }
        //them danh muc mon
        public void AddDanhMucMon(DanhMucMon u)
        {
            DTDoAn st = new DTDoAn();
            st.DanhMucMons.Add(u);
            st.SaveChanges();
        }
        //Xoa Danh Muc mon theo id danh muc
        public void DeleteDanhMucMon(string u)
        {
            DTDoAn st = new DTDoAn();
            DanhMucMon s = st.DanhMucMons.Find(u);
            st.DanhMucMons.Remove(s);
            st.SaveChanges();
        }
        //sua danh muc
        public void UpdateDanhMucMon(DanhMucMon u)
        {
            DTDoAn st = new DTDoAn();
            DanhMucMon s = st.DanhMucMons.Find(u.IDDanhMucMon);
            s = u;
            st.SaveChanges();
        }
    }
}
