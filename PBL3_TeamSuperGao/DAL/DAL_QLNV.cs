using System;
using PBL3_TeamSuperGao.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLNV();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public List<NhanVien> GetListNV_DAL()
        {
            List<NhanVien> ListNhanVien = new List<NhanVien>();
            DTDoAn db = new DTDoAn();
            var l = db.NhanViens;
            ListNhanVien = l.ToList();
            return ListNhanVien;
        }

        public ChucVu GetCV_DAL(int ID_ChucVu)
        {
            DTDoAn db = new DTDoAn();
            ChucVu cv = db.ChucVus.Find(ID_ChucVu);
            return cv;
        }

        public List<ChucVu> GetListChucVu_DAL()
        {
            DTDoAn db = new DTDoAn();
            var l = db.ChucVus;
            return l.ToList();
        }

        public void DelNVByID(int ID_NhanVien)
        {
            DTDoAn db = new DTDoAn();
            NhanVien nv = new NhanVien();
            foreach (NhanVien i in db.NhanViens)
            {
                if (i.IDNhanVien == ID_NhanVien) db.NhanViens.Remove(i);
            }
            db.SaveChanges();
        }

        public NhanVien GetNVByID_DAL(int ID_NhanVien)
        {
            DTDoAn db = new DTDoAn();
            NhanVien nv = db.NhanViens.Find(ID_NhanVien);
            return nv;
        }

        public void AddNV_DAL(NhanVien nv)
        {
            DTDoAn db = new DTDoAn();
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public void EditNV_DAL(NhanVien nv, int ID_NhanVien)
        {
            DTDoAn db = new DTDoAn();
            NhanVien temp = db.NhanViens.Find(ID_NhanVien);
            temp.HoTen = nv.HoTen;
            temp.DanToc = nv.DanToc;
            temp.GioiTinh = nv.GioiTinh;
            temp.SoDienThoai = nv.SoDienThoai;
            temp.QueQuan = nv.QueQuan;
            temp.NgaySinh = Convert.ToDateTime(nv.NgaySinh);
            temp.TrinhDoHocVan = nv.TrinhDoHocVan;
            temp.IDChucVu = Convert.ToInt32(nv.IDChucVu);
            db.SaveChanges();
        }
    }
}
