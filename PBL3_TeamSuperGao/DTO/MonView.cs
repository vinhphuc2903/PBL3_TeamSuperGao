using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DTO
{
    class MonView : IComparable<MonView>
    {
        public int IDMon { get; set; }
        public string TenMon { get; set; }
        public double DonGia { get; set; }
        public int LuotGoi { get; set; }
        public string DanhMuc { get; set; }
        public int CompareTo(MonView other)
        {
            if (this.LuotGoi > other.LuotGoi) return -1;
            else if (this.LuotGoi < other.LuotGoi) return 1;
            else return 0;
        }
    }
}
