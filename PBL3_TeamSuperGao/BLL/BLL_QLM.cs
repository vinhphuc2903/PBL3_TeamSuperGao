using System;
using PBL3_TeamSuperGao.DAL;
using PBL3_TeamSuperGao.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLM
    {
        private static BLL_QLM _Instance;
        public static BLL_QLM Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLM();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public List<DanhMucMon> GetDanhMuc_BLL()
        {
            DAL_QLM dal = new DAL_QLM();
            return dal.GetListDanhMuc_DAL();
        }

        public List<MonView> GetListMon_BLL(int ID_DanhMuc)
        {
            List<MonView> ListMon = new List<MonView>();
            DAL_QLM dal = new DAL_QLM();
            List<Mon> m = dal.GetListMon_DAL();
            foreach (var i in m)
            {
                if (ID_DanhMuc == i.IDDanhMucMon)
                {
                    ListMon.Add(new MonView
                    {
                        IDMon = i.IDMon,
                        TenMon = i.TenMon,
                        DonGia = Convert.ToDouble(i.DonGia),
                        DanhMuc = dal.GetDM_DAL(Convert.ToInt32(i.IDDanhMucMon)).TenDanhMuc
                    });
                }
                else if (ID_DanhMuc == 0)
                {
                    ListMon.Add(new MonView
                    {
                        IDMon = i.IDMon,
                        TenMon = i.TenMon,
                        DonGia = Convert.ToDouble(i.DonGia),
                        DanhMuc = dal.GetDM_DAL(Convert.ToInt32(i.IDDanhMucMon)).TenDanhMuc
                    });
                }
            }
            return ListMon;
        }

        public void DelMonByID_BLL(int ID_Mon)
        {
            DAL_QLM dal = new DAL_QLM();
            dal.DelMonByID(ID_Mon);
        }

        public bool Check(int ID_Mon)
        {
            List<ChiTietHoaDon> list = DAL_QLChiTietHoaDon.Instance.GetAllChiTiet();
            foreach(ChiTietHoaDon i in list)
            {
                if (i.IDMon == ID_Mon) return true;
            }
            return false;
        }

        public Mon GetMonByID_BLL(int ID_Mon)
        {
            DAL_QLM dal = new DAL_QLM();
            return dal.GetMonByID_DAL(ID_Mon);
        }

        public void AddMon_BLL(Mon m)
        {
            DAL_QLM dal = new DAL_QLM();
            dal.AddMon_DAL(m);
        }

        public void EditMon_BLL(Mon m, int ID_Mon)
        {
            DAL_QLM dal = new DAL_QLM();
            dal.EditMon_DAL(m, ID_Mon);
        }

        public List<MonView> SearchMonByName_BLL(int ID_DanhMuc, string NameMon)
        {
            List<MonView> m = new List<MonView>();
            List<MonView> st = GetListMon_BLL(ID_DanhMuc);
            if (NameMon != null) foreach (MonView i in st)
                {
                    if (i.TenMon.Contains(NameMon))
                        m.Add(i);
                }
            return m;
        }

        public List<MonView> SortMon_BLL(int ID_DanhMuc, int choice)
        {
            List<MonView> m = GetListMon_BLL(ID_DanhMuc);
            List<MonView> n = new List<MonView>();
            if (choice == 0)
            {
                var mSort = m.OrderBy(P => P.TenMon);
                n = mSort.ToList();
            }
            else if (choice == 1)
            {
                var mSort = m.OrderBy(P => P.DonGia);
                n = mSort.ToList();
            }
            else if (choice == 2)
            {
                var mSort = m.OrderBy(P => P.DanhMuc);
                n = mSort.ToList();
            }
            return n;
        }
    }
}
