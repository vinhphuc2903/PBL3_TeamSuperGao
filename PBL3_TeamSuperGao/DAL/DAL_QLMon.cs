using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLMon
    {
        private static DAL_QLMon _Instance;
        public static DAL_QLMon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLMon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLMon()
        {

        }
        //them sua xoa 
        //get all mon
        public List<Mon> GetAllMon()
        {
            DTDoAn st = new DTDoAn();
            var t1 = st.Mons;
            //var t1 = st.Mon;
            return t1.ToList();
        }
        //liet ke mon an theo danh muc
        public List<Mon> GetMon_DM(int IDDanhMuc)
        {
            DTDoAn st = new DTDoAn();
            var t1 = st.Mons.Where(p => p.IDDanhMucMon == IDDanhMuc);
            //var t1 = st.Mon;
            return t1.ToList();
        }
        //liet ke mon an theo IDHoaDon
        public List<Mon> GetMon_IDHoaDon(int ID)
        {
            DTDoAn st = new DTDoAn();
            List<Mon> u = new List<Mon>();
            try
            {
                int idhd = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(ID);
                var l1 = st.ChiTietHoaDons.Where(p => p.IDHoaDon == idhd);//s[0].IDHoaDon
                foreach (ChiTietHoaDon i in l1)
                {
                    foreach (Mon j in DAL_QLMon.Instance.GetAllMon())
                    {
                        if (i.IDMon == j.IDMon) u.Add(j);
                    }
                }
            }
            catch
            {

            }
            return u;
        }

        //Them mon an 
        public void AddMon(Mon t)
        {
            DTDoAn st = new DTDoAn();
            st.Mons.Add(t);
            st.SaveChanges();
        }
        //xoa mon an theo ten
        public void DeleteMonTT(string TenMon)
        {
            DTDoAn st = new DTDoAn();
            Mon s = st.Mons.Find(TenMon);
            st.Mons.Remove(s);
            st.SaveChanges();
        }
        //sua mon an
        public void UpdateMon(Mon d)
        {
            DTDoAn st = new DTDoAn();
            Mon u = st.Mons.Find(d.TenMon);
            u = d;
            st.SaveChanges();
        }
        //tim kiem theo ma mon an
        public Mon SerchForMaMon(int MaMonAn)
        {
            DTDoAn st = new DTDoAn();
            var t1 = st.Mons.Where(p => p.IDMon == MaMonAn);
            List<Mon> s = new List<Mon>();
            foreach (Mon i in t1.ToList())
            {
                s.Add(i);
            }
            return s[0];
        }
        //chuyen tu mon sang mon theo sl
        public MonSL SwapMon(Mon t, int SoLuong)
        {
            //MonL u = new MonL();
            //foreach (Mon i in t)

            MonSL k = new MonSL();
            k.TenMon = t.TenMon;
            k.DonGia = t.DonGia;
            //k.HinhAnh = t.HinhAnh;
            k.SoLuong = SoLuong;
            k.ThanhTien = (double)k.DonGia * k.SoLuong;
            //u.Add(k);
            return k;
        }
        //get mon theo ten mon
        public Mon GetMonTheoTen(string u)
        {
            DTDoAn st = new DTDoAn();
            var i = st.Mons.Where(p => p.TenMon.CompareTo(u) == 0);
            Mon k = i.ToArray().ElementAt(0);
            return k;
        }
    }
}
