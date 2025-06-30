using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AreasWithUserWiseDynamicMenus.Models;

public partial class DemoDbContext : DbContext
{
    public DemoDbContext()
    {
    }

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tblrole> Tblroles { get; set; }

    public virtual DbSet<Tbluser> Tblusers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-O1CD770\\SQLEXPRESS;Database=demoDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tblrole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__tblroles__760965CCCD66031B");

            entity.ToTable("tblroles");

            entity.HasIndex(e => e.RoleName, "UQ__tblroles__783254B16FA83D09").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Tbluser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__tblusers__B9BE370F7F6C94E2");

            entity.ToTable("tblusers");

            entity.HasIndex(e => e.UserName, "UQ__tblusers__7C9273C40528388F").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");

            entity.HasOne(d => d.Role).WithMany(p => p.Tblusers)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("fkrole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
