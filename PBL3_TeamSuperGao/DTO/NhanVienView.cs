using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DTO
{
    class NhanVienView
    {
        public int IDNhanVien { get; set; }
        public string HoTen { get; set; }
        public string DanToc { get; set; }
        public bool GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string ChucVu { get; set; }

        
    }
}
