namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatMon")]
    public partial class DatMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatMon()
        {
            ChiTietDatMons = new HashSet<ChiTietDatMon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDatMon { get; set; }

        public long IDKhachHang { get; set; }

        public int IDNhanVien { get; set; }

        public DateTime NgayDat { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "text")]
        public string GhiChu { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatMon> ChiTietDatMons { get; set; }

        public DatMon(int iDDatMon, long iDKhachHang, int iDNhanVien,
            DateTime ngayDat, decimal? tongTien, string ghiChu, bool? trangThai)
        {
            IDDatMon = iDDatMon;
            IDKhachHang = iDKhachHang;
            IDNhanVien = iDNhanVien;
            NgayDat = ngayDat;
            TongTien = tongTien;
            GhiChu = ghiChu;
            TrangThai = trangThai;
        }
    }
}
