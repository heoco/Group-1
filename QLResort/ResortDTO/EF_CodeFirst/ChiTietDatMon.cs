namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDatMon")]
    public partial class ChiTietDatMon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDatMon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDMon { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public virtual DatMon DatMon { get; set; }

        public virtual ThucDon ThucDon { get; set; }

        public ChiTietDatMon(int iDDatMon, int iDMon, decimal? donGia)
        {
            IDDatMon = iDDatMon;
            IDMon = iDMon;
            DonGia = donGia;
        }
    }
}
