using PBL3_TeamSuperGao;
using PBL3_TeamSuperGao.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLBan
    {

        private static BLL_QLBan _Instance;
        public static BLL_QLBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLBan();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLBan()
        {

        }
        //get all ban 
        public List<Ban> GetAllBan()
        {
            return DAL_QLBan.Instance.GetAllBan();
        }
        //delete ban
        public void DeleteBan(string ID)
        {
            DAL_QLBan.Instance.DeleteBan(ID);
        }
        //cap nhat trang thai ban
        public void UpdateTTB(string u)
        {
            DAL_QLBan.Instance.UpdateTTB(u);
        }
        //tra ve ban hien tai
        public Ban GetBanID(int ID)
        {
            return DAL_QLBan.Instance.GetBanID(ID);
        }
        //cap nhat trang thai ban theo ID ban thanh trong
        public void UpdateTTBIDB_T(int u)
        {
            DAL_QLBan.Instance.UpdateTTBIDB_T(u);
        }
        //cap nhat trang thai ban theo ID trong thanh ban
        public void UpdateTTBIDT_B(int u)
        {
            DAL_QLBan.Instance.UpdateTTBIDT_B(u);
        }
        //add ban
        public void AddBan(Ban u)
        {
            DAL_QLBan.Instance.AddBan(u);
        }

        //chuyen ban co nguoi sang co nguoi
        public void ChuyenBan1(int IDCu, int IDMoi)
        {
            DAL_QLBan.Instance.ChuyenBan1(IDCu, IDMoi);
        }
        //chuyen ban co nguoi dang gop sang ban khac
        public void ChuyenBan2(int IDCu, int IDMoi)
        {
            DAL_QLBan.Instance.ChuyenBan2(IDCu, IDMoi);
        }
        public void GopBan(int IDB1, int IDB2)
        {
            DAL_QLBan.Instance.GopBan(IDB1, IDB2);
        }
        /// <summary>
        ///gop ban 1 voi ban 2
        /// </summary>
        /// <param name="IDB1"></param>
        /// <param name="IDB2"></param>
        public void GopBan1(int IDB1, int IDB2)
        {
            DAL_QLBan.Instance.GopBan1(IDB1, IDB2);
        }
        public bool TestBan(int IDBan1, int IDBan2)
        {
            return DAL_QLBan.Instance.TestBan(IDBan1, IDBan2);
        }
        public bool TestBan1(int IDB1, int IDB2)
        {
            return DAL_QLBan.Instance.TestBan1(IDB1, IDB2);
        }
    }
}
//Gop ban: okkk
//