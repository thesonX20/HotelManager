using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.DataTier.Models
{
    public partial class DBQLKS : DbContext
    {
        public DBQLKS()
            : base("name=DBQLKS")
        {
        }

        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public virtual DbSet<PHIEUDENBU> PHIEUDENBUs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TIENNGHI> TIENNGHIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MALUONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MUCLUONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SODT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.MALP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANGLUONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDENBUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.MAPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .HasMany(e => e.PHIEUDENBUs)
                .WithRequired(e => e.PHIEUDATPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDENBU>()
                .Property(e => e.MAPDB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDENBU>()
                .Property(e => e.MAPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDENBU>()
                .Property(e => e.MAPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDENBU>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MAPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            //modelBuilder.Entity<PHONG>()
            //    .Property(e => e.TANG)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MALP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDENBUs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.TIENNGHIs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIENNGHI>()
                .Property(e => e.MATN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIENNGHI>()
                .Property(e => e.MAPHONG)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
