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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDatMon { get; set; }

        public int IDMon { get; set; }

        public virtual ThucDon ThucDon { get; set; }

        public virtual DatMon DatMon { get; set; }

        public ChiTietDatMon(int iDDatMon, int iDMon)
        {
            IDDatMon = iDDatMon;
            IDMon = iDMon;
        }
    }
}
