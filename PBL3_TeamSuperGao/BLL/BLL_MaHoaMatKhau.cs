using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_MaHoaMatKhau
    {
        // ma hoa mat khau
        public string MaHoaMatKhau(string str_pass)
        {
            string str_DaMaHoa = "";
            foreach (char i in str_pass)
            {
                int temp = Convert.ToInt32(i);
                if (temp <= 116)
                {
                    temp += 10;
                }
                else temp -= 81;
                str_DaMaHoa += Convert.ToChar(temp);
            }
            return str_DaMaHoa;
        }
        // dich mat khau da ma hoa
        public string Dich(string str_pass)
        {
            // string dich mau khau da ma hoa
            string str_dadich = "";
            foreach (char i in str_pass)
            {
                int temp = Convert.ToInt32(i);
                if (temp <= 126 && temp >= 42)
                {
                    temp -= 10;
                }
                else temp += 81;
                str_dadich += Convert.ToChar(temp);
            }
            return str_dadich;
        }
    }
}
