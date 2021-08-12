using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLChucVu
    {
        private static DAL_QLChucVu _Instance;
        public static DAL_QLChucVu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLChucVu();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLChucVu()
        {

        }
        public List<ChucVu> GetAllChucVu()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.ChucVus;
            return l1.ToList();
        }
    }
}
