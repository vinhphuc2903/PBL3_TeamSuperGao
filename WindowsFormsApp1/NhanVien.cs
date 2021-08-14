namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int IDNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(30)]
        public string DanToc { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(12)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(30)]
        public string QueQuan { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(30)]
        public string TrinhDoHocVan { get; set; }

        public int? IDChucVu { get; set; }

        public int? IDTaiKhoan { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
