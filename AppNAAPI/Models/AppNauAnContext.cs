using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppNAAPI.Models
{
    public partial class AppNauAnContext : DbContext
    {
        public AppNauAnContext()
        {
        }

        public AppNauAnContext(DbContextOptions<AppNauAnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anhmonan> Anhmonans { get; set; } = null!;
        public virtual DbSet<Binhluan> Binhluans { get; set; } = null!;
        public virtual DbSet<Congthucnguyenlieu> Congthucnguyenlieus { get; set; } = null!;
        public virtual DbSet<Loaimon> Loaimons { get; set; } = null!;
        public virtual DbSet<Mon> Mons { get; set; } = null!;
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; } = null!;
        public virtual DbSet<Nguoidungdb> Nguoidungdbs { get; set; } = null!;
        public virtual DbSet<Nguoidungsave> Nguoidungsaves { get; set; } = null!;
        public virtual DbSet<Nguyenlieu> Nguyenlieus { get; set; } = null!;
        public virtual DbSet<Thongbao> Thongbaos { get; set; } = null!;

        public virtual DbSet<NguyenlieuinFoodfinfoClass> NguyenlieuinFoodfinfoClasses { get; set; } = null!;

        public virtual DbSet<Fragnddb> Fragnddbs { get; set; } = null!;

        public virtual DbSet<Foodinfo> Foodinfos { get; set; } = null!;




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("duyhieu");

            modelBuilder.Entity<Anhmonan>(entity =>
            {
                entity.HasKey(e => e.IdAma);

                entity.ToTable("ANHMONAN", "dbo");

                entity.Property(e => e.IdAma).HasColumnName("ID_AMA");

                entity.Property(e => e.Anhmon)
                    .HasMaxLength(200)
                    .HasColumnName("anhmon");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Anhmonans)
                    .HasForeignKey(d => d.Mamon)
                    .HasConstraintName("FK_ANHMONAN_MON");
            });

            modelBuilder.Entity<Binhluan>(entity =>
            {
                entity.HasKey(e => e.IdBl)
                    .HasName("PK_binhluan");

                entity.ToTable("BINHLUAN", "dbo");

                entity.Property(e => e.IdBl).HasColumnName("ID_BL");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.Property(e => e.Noidungbl)
                    .HasMaxLength(100)
                    .HasColumnName("noidungbl");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .HasColumnName("tendangnhap");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Binhluans)
                    .HasForeignKey(d => d.Mamon)
                    .HasConstraintName("FK_BINHLUAN_MON");

                entity.HasOne(d => d.TendangnhapNavigation)
                    .WithMany(p => p.Binhluans)
                    .HasForeignKey(d => d.Tendangnhap)
                    .HasConstraintName("FK_BINHLUAN_NGUOIDUNG");
            });

            modelBuilder.Entity<Congthucnguyenlieu>(entity =>
            {
                entity.HasKey(e => new { e.Mamon, e.Manguyenlieu })
                    .HasName("PK__CONGTHUC__7634B334DEA652C8");

                entity.ToTable("CONGTHUCNGUYENLIEU", "dbo");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.Property(e => e.Manguyenlieu).HasColumnName("manguyenlieu");

                entity.Property(e => e.Khoiluong)
                    .HasMaxLength(30)
                    .HasColumnName("khoiluong");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Congthucnguyenlieus)
                    .HasForeignKey(d => d.Mamon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONGTHUCNGUYENLIEU_MON");

                entity.HasOne(d => d.ManguyenlieuNavigation)
                    .WithMany(p => p.Congthucnguyenlieus)
                    .HasForeignKey(d => d.Manguyenlieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONGTHUCNGUYENLIEU_NGUYENLIEU");
            });

            modelBuilder.Entity<Loaimon>(entity =>
            {
                entity.HasKey(e => e.Maloai)
                    .HasName("PK__LOAIMON__734B3AEAD0F646F5");

                entity.ToTable("LOAIMON", "dbo");

                entity.Property(e => e.Maloai).HasColumnName("maloai");

                entity.Property(e => e.Tenloai)
                    .HasMaxLength(50)
                    .HasColumnName("tenloai");
            });

            modelBuilder.Entity<Mon>(entity =>
            {
                entity.HasKey(e => e.Mamon);

                entity.ToTable("MON", "dbo");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.Property(e => e.Anhmonlvo)
                    .HasMaxLength(200)
                    .HasColumnName("anhmonlvo");

                entity.Property(e => e.Cachlam)
                    .HasMaxLength(600)
                    .HasColumnName("cachlam");

                entity.Property(e => e.Congthuclam)
                    .HasMaxLength(300)
                    .HasColumnName("congthuclam");

                entity.Property(e => e.Dokho)
                    .HasMaxLength(20)
                    .HasColumnName("dokho");

                entity.Property(e => e.Maloai).HasColumnName("maloai");

                entity.Property(e => e.Tenmon)
                    .HasMaxLength(100)
                    .HasColumnName("tenmon");

                entity.Property(e => e.Tgnau)
                    .HasMaxLength(30)
                    .HasColumnName("tgnau");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Mons)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK_MON_LOAIMON");
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.Tendangnhap);

                entity.ToTable("NGUOIDUNG", "dbo");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .HasColumnName("tendangnhap");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(30)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(20)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Sdt).HasColumnName("sdt");

                entity.Property(e => e.Tuoi).HasColumnName("tuoi");
            });

            modelBuilder.Entity<Nguoidungdb>(entity =>
            {
                entity.HasKey(e => e.IdNddb);

                entity.ToTable("NGUOIDUNGDB", "dbo");

                entity.Property(e => e.IdNddb).HasColumnName("ID_NDDB");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .HasColumnName("tendangnhap");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Nguoidungdbs)
                    .HasForeignKey(d => d.Mamon)
                    .HasConstraintName("FK_NGUOIDUNGDB_MON");

                entity.HasOne(d => d.TendangnhapNavigation)
                    .WithMany(p => p.Nguoidungdbs)
                    .HasForeignKey(d => d.Tendangnhap)
                    .HasConstraintName("FK_NGUOIDUNGDB_NGUOIDUNG");
            });

            modelBuilder.Entity<Nguoidungsave>(entity =>
            {
                entity.HasKey(e => e.IdNds)
                    .HasName("PK_nguoidungsave");

                entity.ToTable("NGUOIDUNGSAVE", "dbo");

                entity.Property(e => e.IdNds).HasColumnName("ID_NDS");

                entity.Property(e => e.Mamon).HasColumnName("mamon");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .HasColumnName("tendangnhap");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany(p => p.Nguoidungsaves)
                    .HasForeignKey(d => d.Mamon)
                    .HasConstraintName("FK_NGUOIDUNGSAVE_MON");

                entity.HasOne(d => d.TendangnhapNavigation)
                    .WithMany(p => p.Nguoidungsaves)
                    .HasForeignKey(d => d.Tendangnhap)
                    .HasConstraintName("FK_NGUOIDUNGSAVE_NGUOIDUNG");
            });

            modelBuilder.Entity<Nguyenlieu>(entity =>
            {
                entity.HasKey(e => e.Manguyenlieu);

                entity.ToTable("NGUYENLIEU", "dbo");

                entity.Property(e => e.Manguyenlieu).HasColumnName("manguyenlieu");

                entity.Property(e => e.Anhnguyenlieu)
                    .HasMaxLength(200)
                    .HasColumnName("anhnguyenlieu");

                entity.Property(e => e.Tennguyenlieu)
                    .HasMaxLength(50)
                    .HasColumnName("tennguyenlieu");
            });

            modelBuilder.Entity<Thongbao>(entity =>
            {
                entity.HasKey(e => e.IdTb)
                    .HasName("PK_thongbao");

                entity.ToTable("THONGBAO", "dbo");

                entity.Property(e => e.IdTb).HasColumnName("ID_TB");

                entity.Property(e => e.Noidungtb)
                    .HasMaxLength(100)
                    .HasColumnName("noidungtb");

                entity.Property(e => e.Tendangnhap)
                    .HasMaxLength(20)
                    .HasColumnName("tendangnhap");

                entity.HasOne(d => d.TendangnhapNavigation)
                    .WithMany(p => p.Thongbaos)
                    .HasForeignKey(d => d.Tendangnhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_THONGBAO_NGUOIDUNG");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
