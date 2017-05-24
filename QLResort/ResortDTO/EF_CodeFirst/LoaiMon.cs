namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMon")]
    public partial class LoaiMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiMon()
        {
            ThucDons = new HashSet<ThucDon>();
        }

        [Key]
        public int IDLoaiMon { get; set; }

        [StringLength(15)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucDon> ThucDons { get; set; }

        public LoaiMon(int iDLoaiMon, string ten)
        {
            IDLoaiMon = iDLoaiMon;
            Ten = ten;
        }
    }
}
