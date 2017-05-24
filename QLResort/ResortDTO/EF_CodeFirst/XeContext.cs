namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XeContext : DbContext
    {
        public XeContext()
            : base("name=XeContext")
        {
        }

        public virtual DbSet<ChiTietThueXe> ChiTietThueXes { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<ThueXe> ThueXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietThueXe>()
                .Property(e => e.IDXe)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietThueXe>()
                .Property(e => e.GiaThue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiXe>()
                .HasMany(e => e.Xes)
                .WithRequired(e => e.LoaiXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThueXe>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThueXe>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<ThueXe>()
                .HasMany(e => e.ChiTietThueXes)
                .WithRequired(e => e.ThueXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.IDXe)
                .IsFixedLength();

            modelBuilder.Entity<Xe>()
                .Property(e => e.GiaThue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Xe>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChiTietThueXes)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);
        }
    }
}
