using System;
using PBL3_TeamSuperGao.DAL;
using PBL3_TeamSuperGao.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNV();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public List<ChucVu> GetChucVu_BLL()
        {
            DAL_QLNV dal = new DAL_QLNV();
            return dal.GetListChucVu_DAL();
        }

        public List<NhanVienView> GetListNV_BLL(int ID_ChucVu)
        {
            List<NhanVienView> ListNV = new List<NhanVienView>();
            DAL_QLNV dal = new DAL_QLNV();
            List<NhanVien> nv = dal.GetListNV_DAL();
            foreach (var i in nv)
            {
                if (ID_ChucVu == i.IDChucVu)
                {
                    ListNV.Add(new NhanVienView
                    {
                        IDNhanVien = i.IDNhanVien,
                        HoTen = i.HoTen,
                        DanToc = i.DanToc,
                        GioiTinh = i.GioiTinh,
                        SoDienThoai = i.SoDienThoai,
                        QueQuan = i.QueQuan,
                        NgaySinh = i.NgaySinh,
                        TrinhDoHocVan = i.TrinhDoHocVan,
                        ChucVu = dal.GetCV_DAL(Convert.ToInt32(i.IDChucVu)).TenChucVu
                    });
                }
                else if (ID_ChucVu == 0)
                {
                    ListNV.Add(new NhanVienView
                    {
                        IDNhanVien = i.IDNhanVien,
                        HoTen = i.HoTen,
                        DanToc = i.DanToc,
                        GioiTinh = i.GioiTinh,
                        SoDienThoai = i.SoDienThoai,
                        QueQuan = i.QueQuan,
                        NgaySinh = i.NgaySinh,
                        TrinhDoHocVan = i.TrinhDoHocVan,
                        ChucVu = dal.GetCV_DAL(Convert.ToInt32(i.IDChucVu)).TenChucVu
                    });
                }
            }
            return ListNV;
        }

        public void DelNVByID_BLL(int ID_NhanVien)
        {
            DAL_QLNV dal = new DAL_QLNV();
            dal.DelNVByID(ID_NhanVien);
        }

        public bool Check(int ID_NhanVien)
        {
            List<HoaDon> ListHoaDon = DAL_QLHoaDon.Instance.GetAllHoaDon();
            foreach(HoaDon i in ListHoaDon)
            {
                if (i.IDNhanVien == ID_NhanVien) return true;
            }
            return false;
        }

        public NhanVien GetNVByID_BLL(int ID_NhanVien)
        {
            DAL_QLNV dal = new DAL_QLNV();
            return dal.GetNVByID_DAL(ID_NhanVien);
        }
        
        public void AddNV_BLL(NhanVien nv)
        {
            DAL_QLNV dal = new DAL_QLNV();
            dal.AddNV_DAL(nv);
        }

        public void EditNV_BLL(NhanVien nv, int ID_NhanVien)
        {
            DAL_QLNV dal = new DAL_QLNV();
            dal.EditNV_DAL(nv, ID_NhanVien);
        }

        public List<NhanVienView> SearchNVByName_BLL(int ID_ChucVu, string NameNV)
        {
            List<NhanVienView> nv = new List<NhanVienView>();
            List<NhanVienView> st = GetListNV_BLL(ID_ChucVu);
            if (NameNV != null) foreach (NhanVienView i in st)
                {
                    if (i.HoTen.Contains(NameNV))
                        nv.Add(i);
                }
            return nv;
        }

        public List<NhanVienView> SortNV_BLL(int ID_ChucVu, int choice)
        {
            List<NhanVienView> nv = GetListNV_BLL(ID_ChucVu);
            List<NhanVienView> temp = new List<NhanVienView>();
            if (choice == 0)
            {
                var nvSort = nv.OrderBy(P => P.HoTen);
                foreach (NhanVienView mon in nvSort)
                {
                    temp.Add(mon);
                }
            }
            else if (choice == 1)
            {
                var nvSort = nv.OrderBy(P => P.GioiTinh);
                foreach (NhanVienView mon in nvSort)
                {
                    temp.Add(mon);
                }
            }
            else if (choice == 2)
            {
                var nvSort = nv.OrderBy(P => P.ChucVu);
                foreach (NhanVienView mon in nvSort)
                {
                    temp.Add(mon);
                }
            }
            return temp;
        }
    }
}
