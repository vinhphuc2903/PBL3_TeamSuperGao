using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLNhanVien
    {
        private static BLL_QLNhanVien _Instance;
        public static BLL_QLNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNhanVien();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLNhanVien()
        {

        }
        //get all nhan vien
        public List<NhanVien> GetAllNV()
        {
            return DAL.DAL_QLNhanVien.Instance.GetAllNV();
        }
        //them nhan vien
        public void AddNhanVien(NhanVien t)
        {
            DAL.DAL_QLNhanVien.Instance.AddNhanVien(t);
        }
        //sua nhan vien
        public void UpdateNV(NhanVien t)
        {
            DAL.DAL_QLNhanVien.Instance.UpdateNV(t);
        }
        //tim ma nhan vien theo ma tai khoan 
        public int GetIDNVForIDTK(int ID)
        {
            return DAL.DAL_QLNhanVien.Instance.GetIDNVForIDTK(ID);
        }
        //tim nhan vien theo ma
        public NhanVien SearchNVForID(int ID)
        {
            return DAL.DAL_QLNhanVien.Instance.SearchNVForID(ID);
        }
        //liet ke danh sach nhan vien theo chuc vu
        public List<NhanVien> SearchNVForCV(int IDCV)
        {
            return DAL.DAL_QLNhanVien.Instance.SearchNVForCV(IDCV);
        }
        //tim nhan  vien theo ten
        public List<NhanVien> SearchForName(int ChucVu,string Name)
        {
            return DAL.DAL_QLNhanVien.Instance.SearchForName(ChucVu,Name);
        }
        //chuyen tu list nhan vien sang nhanvien view
        
        public List<NhanVienView> SwapNV(List<NhanVien> t)
        {
            return DAL.DAL_QLNhanVien.Instance.SwapNV(t);
        }
        //tra ve ma so nhan vien max
        public int IDNhanVienMax()
        {
            return DAL.DAL_QLNhanVien.Instance.IDNhanVienMax();
        }
        //xoa nhan vien theo stt
        public void DeleteHoten(int stt)
        {
            DAL.DAL_QLNhanVien.Instance.DeleteHoten(stt);
        }
        //kiem tra chuc vu theo ma, neu chuc vu quan ly thi tra ve true
        public bool KiemTraChucVu(int IDNhanVien)
        {
            return DAL.DAL_QLNhanVien.Instance.KiemTraChucVu(IDNhanVien);
        }
    }
}
