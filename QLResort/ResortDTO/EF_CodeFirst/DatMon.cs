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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDatMon { get; set; }

        public Int64 IDKhachHang { get; set; }

        public int IDNhanVien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayDat { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [Column(TypeName = "text")]
        public string GhiChu { get; set; }

        public bool? TrangThai { get; set; }

        public virtual ChiTietDatMon ChiTietDatMon { get; set; }

        public DatMon(int iDDatMon, Int64 iDKhachHang, int iDNhanVien,
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
