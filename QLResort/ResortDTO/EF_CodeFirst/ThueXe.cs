namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThueXe")]
    public partial class ThueXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThueXe()
        {
            ChiTietThueXes = new HashSet<ChiTietThueXe>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThueXe { get; set; }

        public Int64 IDKhachHang { get; set; }

        public int IDNhanVien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayThue { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "text")]
        public string GhiChu { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThueXe> ChiTietThueXes { get; set; }

        public ThueXe(int iDThueXe, Int64 iDKhachHang, int iDNhanVien,
            DateTime ngayThue, decimal? tongTien, string ghiChu, bool? trangThai)
        {
            IDThueXe = iDThueXe;
            IDKhachHang = iDKhachHang;
            IDNhanVien = iDNhanVien;
            NgayThue = ngayThue;
            TongTien = tongTien;
            GhiChu = ghiChu;
            TrangThai = trangThai;
        }
    }
}
