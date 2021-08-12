using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_QLCV
    {
        private static BLL_QLCV _Instance;
        public static BLL_QLCV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLCV();
                }
                return _Instance;
            }

            private set
            { }
        }
        private BLL_QLCV()
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
