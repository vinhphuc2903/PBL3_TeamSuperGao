using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DTO
{
    class HoaDonView : IComparable<HoaDonView>
    {
        public int IDHoaDon { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string GiamGia { get; set; }
        public double TongTien { get; set; }

        public int CompareTo(HoaDonView other)
        {
            if (this.NgayThanhToan > other.NgayThanhToan) return 1;
            else if (this.NgayThanhToan < other.NgayThanhToan) return -1;
            return 0;
        }
    }
}
