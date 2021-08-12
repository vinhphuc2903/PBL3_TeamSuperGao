using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_TeamSuperGao.DAL;
using PBL3_TeamSuperGao.DTO;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLMon
    {
        private static BLL_QLMon _Instance;
        public static BLL_QLMon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLMon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLMon()
        {

        }
        //them sua xoa 
        //get all mon
        public List<Mon> GetAllMon()
        {
            return DAL_QLMon.Instance.GetAllMon();
        }
        //liet ke mon an theo danh muc
        public List<Mon> GetMon_DM(int IDDanhMuc)
        {
            return DAL_QLMon.Instance.GetMon_DM(IDDanhMuc);
        }
        //liet ke mon an theo IDHoaDon
        public List<Mon> GetMon_IDHoaDon(int ID)
        {
            return DAL_QLMon.Instance.GetMon_IDHoaDon(ID);
        }

        //Them mon an 
        public void AddMon(Mon t)
        {
            DAL_QLMon.Instance.AddMon(t);
        }
        //xoa mon an theo ten
        public void DeleteMonTT(string TenMon)
        {
            DAL_QLMon.Instance.DeleteMonTT(TenMon);
        }
        //sua mon an
        public void UpdateMon(Mon d)
        {
            DAL_QLMon.Instance.UpdateMon(d);
        }
        //tim kiem theo ma mon an
        public Mon SerchForMaMon(int MaMonAn)
        {
            return DAL_QLMon.Instance.SerchForMaMon(MaMonAn);
        }
        //chuyen tu mon sang mon theo sl
        public MonSL SwapMon(Mon t, int SoLuong)
        {
            //MonSL u = new MonSL();
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
            return DAL_QLMon.Instance.GetMonTheoTen(u);
        }
    }
}
