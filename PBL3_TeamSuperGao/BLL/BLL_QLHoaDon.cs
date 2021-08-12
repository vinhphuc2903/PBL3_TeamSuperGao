
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_TeamSuperGao.DAL;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLHoaDon
    {
        private static BLL_QLHoaDon _Instance;
        public static BLL_QLHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLHoaDon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLHoaDon()
        {

        }
        //liet ke full hoa don
        public List<HoaDon> GetAllHoaDon()
        {
            return DAL_QLHoaDon.Instance.GetAllHoaDon();
        }
 
        //tra ve IDHoaDon max;
        public int GetIDHoaDonMax()
        {
            return DAL_QLHoaDon.Instance.GetIDHoaDonMax();
        }
        //them 1 hoa don
        public void AddHD_CTHD(int IDBan,int GG,  int IDNhanVien )
        {
            DAL_QLHoaDon.Instance.AddHD_CTHD(IDBan,GG,IDNhanVien);
        }
        //cap nhat khi thanh toan hoa don
        public void ThanhToan(int IDHoaDon)
        {
            DAL_QLHoaDon.Instance.ThanhToan(IDHoaDon);
        }
        //tong tien theo ID ban
        public float TongTien(int ID)
        {
            return DAL_QLHoaDon.Instance.TongTien(ID); ;
        }
        //cap nhat tong tien hoa don theo ID ban
        public void UpdateTT(int ID)
        {
            DAL_QLHoaDon.Instance.UpdateTT(ID);
        }
        //get ID Hoa Don theo ID ban
        public int GetIDHoaDonForIDBan(int ID)
        {
            return DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(ID);
        }
        //cap nhat tong tien va giam gia 
        public void UpdateTongTien_GiamGia(int IDBan,double TT, double GG)
        {
            DAL_QLHoaDon.Instance.UpdateTongTien_GiamGia(IDBan,TT, GG);
        }
        //xoa hoa don theo IDBan
        public void DeleteHoaDon(int IDBan)
        {
            DAL_QLHoaDon.Instance.DeleteHoaDon(IDBan);
        }
    }
}
