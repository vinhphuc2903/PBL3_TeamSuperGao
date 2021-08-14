using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLChiTietHoaDon
    {
        private static DAL_QLChiTietHoaDon _Instance;
        public static DAL_QLChiTietHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLChiTietHoaDon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLChiTietHoaDon()
        {

        }

        public List<ChiTietHoaDon> GetAllChiTiet()
        {
            DTDoAn st = new DTDoAn();
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            var l = st.ChiTietHoaDons;
            list = l.ToList();
            return list;
        }

        //get bill theo id ban 
        public List<MonSL> GetBill(int ID)
        {
            DTDoAn st = new DTDoAn();
            List<MonSL> u = new List<MonSL>();
            //try
            //{
            int idhd = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(ID);
            var l1 = st.ChiTietHoaDons.Where(p => p.IDHoaDon == idhd);//s[0].IDHoaDon
            foreach (ChiTietHoaDon i in l1)
            {
                foreach (Mon j in DAL_QLMon.Instance.GetAllMon())
                {
                    if (i.IDMon == j.IDMon) u.Add(DAL_QLMon.Instance.SwapMon(j, (int)i.SoLuong));
                }
            }
            //}
            //catch
            //{

            //}
            return u;
        }

        // them mon vao hoa don da co
        public void AddMon(Mon i, int Sl, int IDBan)
        {
            DTDoAn st = new DTDoAn();
            ChiTietHoaDon u = new ChiTietHoaDon();
            int IDHoaDon = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDBan);
            bool kt = true;
            //kiem tra da co mon chua
            foreach (ChiTietHoaDon j in st.ChiTietHoaDons)
            {
                if (i.IDMon == j.IDMon && j.IDHoaDon == IDHoaDon)
                {
                    j.SoLuong += Sl;
                    kt = false;
                }
            }
            if (kt)
            {
                u.IDHoaDon = IDHoaDon;
                u.IDMon = i.IDMon;
                u.NgayThanhToan = null;
                u.SoLuong = Sl;
                st.ChiTietHoaDons.Add(u);
            }
            st.SaveChanges();
        }
        //xoa mon
        public void RemoveMon(int Index, int IDBan)
        {
            int idhd = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDBan);
            DTDoAn st = new DTDoAn();
            int j = 0;
            List<ChiTietHoaDon> ct = new List<ChiTietHoaDon>();
            foreach (ChiTietHoaDon i in st.ChiTietHoaDons)
            {
                if (idhd == i.IDHoaDon) ct.Add(i);
            }
            foreach (ChiTietHoaDon t in ct)
            {
                if (j == Index) st.ChiTietHoaDons.Remove(t);
                j++;
            }
            st.SaveChanges();
        }

    }
}
