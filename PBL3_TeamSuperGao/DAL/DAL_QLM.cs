using System;
using PBL3_TeamSuperGao.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLM
    {
        private static DAL_QLM _Instance;
        public static DAL_QLM Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLM();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public List<Mon> GetListMon_DAL()
        {
            List<Mon> ListMonAn = new List<Mon>();
            DTDoAn db = new DTDoAn();
            var l = db.Mons;
            ListMonAn = l.ToList();
            return ListMonAn;
        }

        public DanhMucMon GetDM_DAL(int ID_DanhMuc)
        {
            DTDoAn db = new DTDoAn();
            DanhMucMon dm = db.DanhMucMons.Find(ID_DanhMuc);
            return dm;
        }

        public List<DanhMucMon> GetListDanhMuc_DAL()
        {
            DTDoAn db = new DTDoAn();
            var l = db.DanhMucMons;
            return l.ToList();
        }

        public void DelMonByID(int ID_Mon)
        {
            DTDoAn db = new DTDoAn();
            Mon m = new Mon();
            foreach (Mon i in db.Mons)
            {
                if (i.IDMon == ID_Mon) db.Mons.Remove(i);
            }
            db.SaveChanges();
        }

        public Mon GetMonByID_DAL(int ID_Mon)
        {
            DTDoAn db = new DTDoAn();
            Mon m = db.Mons.Find(ID_Mon);
            return m;
        }

        public void AddMon_DAL(Mon m)
        {
            DTDoAn db = new DTDoAn();
            db.Mons.Add(m);
            db.SaveChanges();
        }

        public void EditMon_DAL(Mon nv, int ID_Mon)
        {
            DTDoAn db = new DTDoAn();
            Mon temp = db.Mons.Find(ID_Mon);
            temp.TenMon = nv.TenMon;
            temp.DonGia = nv.DonGia;
            temp.IDDanhMucMon = Convert.ToInt32(nv.IDDanhMucMon);
            db.SaveChanges();
        }
    }
}
