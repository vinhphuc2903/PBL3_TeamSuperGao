using PBL3_TeamSuperGao.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLDanhMuc
    {
        private static BLL_QLDanhMuc _Instance;
        public static BLL_QLDanhMuc Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLDanhMuc();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLDanhMuc()
        {
        }
        //tra ve tat ca danh muc
        public List<DanhMucMon> GetDanhMucMon()
        {
            return DAL_QLDanhMuc.Instance.GetDanhMucMon();
        }
        //them danh muc mon
        public void AddDanhMucMon(DanhMucMon u)
        {
            DAL_QLDanhMuc.Instance.AddDanhMucMon(u);
        }
        //Xoa Danh Muc mon theo id danh muc
        public void DeleteDanhMucMon(string u)
        {
            DAL_QLDanhMuc.Instance.DeleteDanhMucMon(u);
        }
        //sua danh muc
        public void UpdateDanhMucMon(DanhMucMon u)
        {
            DAL_QLDanhMuc.Instance.UpdateDanhMucMon(u);
        }

    }
}
