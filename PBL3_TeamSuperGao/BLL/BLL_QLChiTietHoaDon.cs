using PBL3_TeamSuperGao.DAL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLChiTietHoaDon
    {
        private static BLL_QLChiTietHoaDon _Instance;
        public static BLL_QLChiTietHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLChiTietHoaDon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLChiTietHoaDon()
        {

        }
       
       //get bill theo id ban 
        public List<MonSL> GetBill(int ID)
        {
            return DAL_QLChiTietHoaDon.Instance.GetBill(ID);
        }
        
        // them mon vao hoa don da co
        public void AddMon(Mon i,int Sl,int IDBan)
        {
            DAL_QLChiTietHoaDon.Instance.AddMon( i, Sl, IDBan);
        }
        //xoa mon
        public void RemoveMon(int Index,int IDBan)
        {
            DAL_QLChiTietHoaDon.Instance.RemoveMon(Index, IDBan);
        }

    }
}
