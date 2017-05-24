namespace ResortDTO.EF_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ThucDonContext : DbContext
    {
        public ThucDonContext()
            : base("name=ThucDonContext")
        {
        }

        public virtual DbSet<ChiTietDatMon> ChiTietDatMons { get; set; }
        public virtual DbSet<DatMon> DatMons { get; set; }
        public virtual DbSet<LoaiMon> LoaiMons { get; set; }
        public virtual DbSet<ThucDon> ThucDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDatMon>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DatMon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DatMon>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<DatMon>()
                .HasMany(e => e.ChiTietDatMons)
                .WithRequired(e => e.DatMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiMon>()
                .HasMany(e => e.ThucDons)
                .WithRequired(e => e.LoaiMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThucDon>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThucDon>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<ThucDon>()
                .HasMany(e => e.ChiTietDatMons)
                .WithRequired(e => e.ThucDon)
                .WillCascadeOnDelete(false);
        }
    }
}
