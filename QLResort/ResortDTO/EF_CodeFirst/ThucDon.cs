namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThucDon")]
    public partial class ThucDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucDon()
        {
            ChiTietDatMons = new HashSet<ChiTietDatMon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDMon { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public int IDLoaiMon { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "text")]
        public string MoTa { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatMon> ChiTietDatMons { get; set; }

        public virtual LoaiMon LoaiMon { get; set; }

        public ThucDon(int iDMon, string ten, int iDLoaiMon, decimal donGia, string moTa, bool trangThai)
        {
            IDMon = iDMon;
            Ten = ten;
            IDLoaiMon = iDLoaiMon;
            DonGia = donGia;
            MoTa = moTa;
            TrangThai = trangThai;
        }
    }
}
