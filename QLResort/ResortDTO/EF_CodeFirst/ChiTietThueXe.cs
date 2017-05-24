namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThueXe")]
    public partial class ChiTietThueXe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDThueXe { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDXe { get; set; }

        public DateTime NgayNhan { get; set; }

        public DateTime NgayTra { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaThue { get; set; }

        public virtual ThueXe ThueXe { get; set; }

        public virtual Xe Xe { get; set; }

        public ChiTietThueXe(int iDThueXe, string iDXe, DateTime ngayNhan, DateTime ngayTra,
            decimal? giaThue)
        {
            IDThueXe = iDThueXe;
            IDXe = iDXe;
            NgayNhan = ngayNhan;
            NgayTra = ngayTra;
            GiaThue = giaThue;
        }
    }
}
