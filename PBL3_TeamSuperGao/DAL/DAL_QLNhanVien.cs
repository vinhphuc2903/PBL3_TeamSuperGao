using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLNhanVien
    {
                private static DAL_QLNhanVien _Instance;
        public static DAL_QLNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLNhanVien();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLNhanVien()
        {

        }
        //get all nhan vien
        public List<NhanVien> GetAllNV()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.NhanViens;
            return l1.ToList();
        }
        //them nhan vien
        public void AddNhanVien(NhanVien t)
        {
            DTDoAn st = new DTDoAn();
            st.NhanViens.Add(t);
            st.SaveChanges();
        }
        // cap nhat ID Tai Khoan
        public void UpdateIDTaiKhoan(int IDTK,int IDNV)
        {
            DTDoAn st = new DTDoAn();
            NhanVien UpdateID = st.NhanViens.Find(IDNV);
            UpdateID.IDTaiKhoan = IDTK;
            st.SaveChanges();
        }
        //sua nhan vien
        public void UpdateNV(NhanVien t)
        {
            DTDoAn st = new DTDoAn();
            NhanVien u = st.NhanViens.Find(t.IDNhanVien);
            u = t;
            st.SaveChanges();
        }
        //tim ma nhan vien theo ma tai khoan 
        public int GetIDNVForIDTK(int ID)
        {
            foreach (NhanVien i in GetAllNV())
            {
                if (i.IDTaiKhoan == ID) return i.IDNhanVien;
            }
            return -1;
        }
        //tim nhan vien theo ma
        public NhanVien SearchNVForID(int ID)
        {
            DTDoAn st = new DTDoAn();
            NhanVien u = st.NhanViens.Find(ID);
            return u;
        }
        //liet ke danh sach nhan vien theo chuc vu
        public List<NhanVien> SearchNVForCV(int IDCV)
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.NhanViens.Where(p => p.IDChucVu == IDCV);
            return l1.ToList();
        }
        //tim nhan  vien theo ten
        public List<NhanVien> SearchForName(int ChucVu, string Name)
        {
            List<NhanVien> t = new List<NhanVien>();
            List<NhanVien> st = SearchNVForCV(ChucVu);
            if (Name != null) foreach (NhanVien i in st)
                {
                    if (i.HoTen.Contains(Name))
                        t.Add(i);
                }
            return t;
        }
        //chuyen tu list nhan vien sang nhanvien view

        public List<NhanVienView> SwapNV(List<NhanVien> t)
        {
            List<NhanVienView> st = new List<NhanVienView>();
            foreach (NhanVien i in t)
            {
                NhanVienView k = new NhanVienView();
                k.HoTen = i.HoTen;
                k.GioiTinh = i.GioiTinh;
                k.NgaySinh = i.NgaySinh;
                k.QueQuan = i.QueQuan;
                k.SoDienThoai = i.SoDienThoai;
                k.TrinhDoHocVan = i.TrinhDoHocVan;
                k.DanToc = i.DanToc;
                foreach (ChucVu y in DAL_QLChucVu.Instance.GetAllChucVu())
                {
                    if (i.IDChucVu == y.IDChucVu) k.ChucVu = y.TenChucVu;
                }
                st.Add(k);
            }

            return st;
        }
        //tra ve ma so nhan vien max
        public int IDNhanVienMax()
        {
            int u = 0;
            foreach (NhanVien i in GetAllNV())
            {
                foreach (NhanVien j in GetAllNV())
                {
                    if (i.IDNhanVien < j.IDNhanVien) u = j.IDNhanVien;
                    else u = i.IDNhanVien;
                }
            }
            return u;
        }
        //xoa nhan vien theo stt
        public void DeleteHoten(int stt)
        {
            DTDoAn st = new DTDoAn();
            NhanVien u = new NhanVien();
            int j = 0;
            foreach (NhanVien i in st.NhanViens)
            {
                if (j == stt) st.NhanViens.Remove(i);
                j++;
            }
            st.SaveChanges();
        }
        //kiem tra chuc vu theo ma nhan vien, neu chuc vu la quan li thi tra ve true
        public bool KiemTraChucVu(int IDNhanVien)
        {
            DTDoAn st = new DTDoAn();
            NhanVien i = st.NhanViens.Find(IDNhanVien);
            if (i.IDChucVu == 1) return true;
            else return false;
        }

    }
}
