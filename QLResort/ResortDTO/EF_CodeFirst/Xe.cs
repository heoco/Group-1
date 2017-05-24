namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            ChiTietThueXes = new HashSet<ChiTietThueXe>();
        }

        [Key]
        [StringLength(10)]
        public string IDXe { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string HangSX { get; set; }

        public int IDLoaiXe { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaThue { get; set; }

        [Column(TypeName = "text")]
        public string MoTa { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThueXe> ChiTietThueXes { get; set; }

        public virtual LoaiXe LoaiXe { get; set; }

        public Xe(string iDXe, string ten, string hangSX, int iDLoaiXe, decimal giaThue, string moTa, bool trangThai)
        {
            IDXe = iDXe;
            Ten = ten;
            HangSX = hangSX;
            IDLoaiXe = iDLoaiXe;
            GiaThue = giaThue;
            MoTa = moTa;
            TrangThai = trangThai;
        }
    }
}
