using PBL3_TeamSuperGao.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLTaiKhoan : BLL_MaHoaMatKhau
    {
        private static BLL_QLTaiKhoan _Instance;
        public static BLL_QLTaiKhoan Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_QLTaiKhoan();
                }
                return _Instance;
            }
            private set { }
        }
        public bool BLL_isTrueLogin(string TK,String MK)
        {
            foreach(var i in BLL_ShowTK())
            {
                if (String.Compare(TK, i.UserName.Trim(),true) == 0 && MK == i.PassWord.Trim()) return true;
            }
            return false;
        }
        public int GetIDTK(string tendn, string pw)
        {
            foreach (TaiKhoan i in BLL_ShowTK())
            {
                if (String.Compare(tendn, i.UserName.Trim(), true) == 0 && pw == i.PassWord.Trim()) return i.IDTaiKhoan;
            }
            return -1;
        }
        public List<TaiKhoan> BLL_ShowTK()
        {
            List<TaiKhoan> ListTaiKhoan = DAL_QLTaiKhoan.Instance.Show();
            foreach(var i in ListTaiKhoan)
            {
                string temp = Dich(i.PassWord.Trim());
                i.PassWord = temp;
            }
            return ListTaiKhoan;
        }
        public void BLL_AddTK(string Username,string Password)
        {
            TaiKhoan TempTaiKhoan = new TaiKhoan();
            TempTaiKhoan.UserName = Username;
            TempTaiKhoan.PassWord = MaHoaMatKhau(Password);
            DAL_QLTaiKhoan.Instance.Add(TempTaiKhoan);
        }
        public void BLL_EditTK(string User, string Password)
        {
            TaiKhoan TempTaiKhoan = new TaiKhoan();
            TempTaiKhoan.UserName = User;
            TempTaiKhoan.PassWord = MaHoaMatKhau(Password);
            DAL_QLTaiKhoan.Instance.Edit(TempTaiKhoan);
        }
        public void BLL_DeleteTK(int ID)
        {
            DAL_QLTaiKhoan.Instance.Delete(ID);
        }
    }
}
