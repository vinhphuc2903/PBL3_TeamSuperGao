using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLBan
    {

        private static DAL_QLBan _Instance;
        public static DAL_QLBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLBan();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLBan()
        {

        }
        //liet ke danh sach ban 
        public List<Ban> GetAllBan()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.Bans;
            return l1.ToList();
        }
        //xoa ban
        public void DeleteBan(string ID)
        {
            DTDoAn st = new DTDoAn();
            Ban s = st.Bans.Find(ID);
            st.Bans.Remove(s);
            st.SaveChanges();
        }
        //cap nhat trang thai ban tu Trong sang Co Nguoi va nguoc lai
        public void UpdateTTB(string u)
        {
            DTDoAn st = new DTDoAn();
            foreach (Ban i in st.Bans)
            {
                if (u.CompareTo(i.IDBan.ToString()) == 0 && i.TinhTrangBan == "Trong") i.TinhTrangBan = "Co Nguoi";
                else if (u.CompareTo(i.IDBan.ToString()) == 0 && i.TinhTrangBan == "Co Nguoi") i.TinhTrangBan = "Trong";
            }
            st.SaveChanges();
        }
        //tra ve ban hien tai theo ID ban
        public Ban GetBanID(int ID)
        {
            DTDoAn st = new DTDoAn();
            Ban u = st.Bans.Find(ID);
            return u;
        }

        //cap nhat trang thai ban theo ID ban thanh Trong
        public void UpdateTTBIDB_T(int u)
        {
            DTDoAn st = new DTDoAn();
            Ban i = st.Bans.Find(u);
            i.TinhTrangBan = "Trong";
            foreach(Ban k in st.Bans)
            {
                if(k.TinhTrangBan.CompareTo("Gop Ban " + u.ToString()) == 0)
                {
                    k.TinhTrangBan = "Trong";
                }
            }
            st.SaveChanges();
        }
        //cap nhat trang thai ban theo ID trong thanh Co Nguoi
        public void UpdateTTBIDT_B(int u)
        {
            DTDoAn st = new DTDoAn();
            foreach (Ban i in st.Bans)
            {
                if (u == i.IDBan && i.TinhTrangBan == "Trong") i.TinhTrangBan = "Co Nguoi";

            }
            st.SaveChanges();
        }
        //Them ban
        public void AddBan(Ban u)
        {
            DTDoAn st = new DTDoAn();
            st.Bans.Add(u);
            st.SaveChanges();
        }

        //chuyen ban co nguoi voi co nguoi
        public void ChuyenBan1(int IDCu,int IDMoi )
        {
            int IDHD1 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDCu);
            int IDHD2 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDMoi);
            DTDoAn st = new DTDoAn();
            HoaDon u1 = st.HoaDons.Find(IDHD1);
            HoaDon u2 = st.HoaDons.Find(IDHD2);
            Ban t1 = st.Bans.Find(IDCu);
            Ban t2 = st.Bans.Find(IDMoi);
            string ttb = t1.TinhTrangBan;
            t1.TinhTrangBan = t2.TinhTrangBan;
            t2.TinhTrangBan = ttb;
            if(u1 != null) u1.IDBan = IDMoi;
            if (u2 != null) u2.IDBan = IDCu;
            st.SaveChanges();
        }
        /// <summary>
        ///gop ban 1 voi ban 2
        ///khi gop ban thi tinh trang = ban
        /// </summary>
        /// <param name="IDB1"></param>
        /// <param name="IDB2"></param>
        public void GopBan(int IDB1, int IDB2)
        {
            DTDoAn st = new DTDoAn();
            Ban t1 = st.Bans.Find(IDB1);
            Ban t2 = st.Bans.Find(IDB2);
            int IDHDBan2 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDB2);
            HoaDon b2 = st.HoaDons.Find(IDHDBan2);
            if (t1.TinhTrangBan.CompareTo("Trong") == 0)
            {
                int IDHD2 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDB2);
                HoaDon u2 = st.HoaDons.Find(IDHD2);
                u2.IDBan = IDB1;
            }
            else
            {
                foreach (MonSL i in DAL_QLChiTietHoaDon.Instance.GetBill(IDB2))
                {
                    DAL_QLChiTietHoaDon.Instance.AddMon(DAL_QLMon.Instance.GetMonTheoTen(i.TenMon), Convert.ToInt32(i.SoLuong), IDB1);
                }
                var ListCTHD = st.ChiTietHoaDons.Where(p => p.IDHoaDon == IDHDBan2);
                foreach (ChiTietHoaDon j in ListCTHD)
                {
                    st.ChiTietHoaDons.Remove(j);
                }
                st.HoaDons.Remove(b2);
            }
            t1.TinhTrangBan = "Co Nguoi";
            t2.TinhTrangBan = "Gop Ban " + IDB1.ToString();
      
            st.SaveChanges();
        }
        //gop ban
        //trong - ban
        public void GopBan1(int IDB1,int IDB2)
        {
            
            DTDoAn st = new DTDoAn();
            Ban t1 = st.Bans.Find(IDB1);
            Ban t2 = st.Bans.Find(IDB2);
            if(t1.TinhTrangBan.CompareTo("Trong") == 0)
            {
                int IDHD2 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDB2);
                HoaDon u2 = st.HoaDons.Find(IDHD2);
                u2.IDBan = IDB1;
            }
           /* else
            {
                int IDHD1 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDB1);
                HoaDon u1 = st.HoaDons.Find(IDHD1);
                u1.IDBan = IDB2;
            }*/
            t1.TinhTrangBan = "Co Nguoi";
            t2.TinhTrangBan = "Gop Ban " + IDB1.ToString();
            st.SaveChanges();
        }
    }
}
