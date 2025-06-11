using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhuongHaiNam_L1.Models;

public partial class EmployeeManagementContext : DbContext
{
    public EmployeeManagementContext()
    {
    }

    public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Certificate> Certificates { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Ethnic> Ethnics { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=EmployeeManagement\n;User Id=sa;Password=123456aA@$;TrustServerCertificate=true;Integrated Security=false;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Certificate>(entity =>
        {
            entity.HasKey(e => e.CertificateId).HasName("PK__Certific__BBF8A7C1E20B69F1");

            entity.HasOne(d => d.Employee).WithMany(p => p.Certificates)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Certifica__Emplo__49C3F6B7");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__Cities__F2D21B76882F3950");

            entity.Property(e => e.CityId).ValueGeneratedNever();
            entity.Property(e => e.CityName).HasMaxLength(100);
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__District__85FDA4C6036AF343");

            entity.Property(e => e.DistrictId).ValueGeneratedNever();
            entity.Property(e => e.DistrictName).HasMaxLength(100);

            entity.HasOne(d => d.City).WithMany(p => p.Districts)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Districts__CityI__3D5E1FD2");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11839FE756");

            entity.HasOne(d => d.City).WithMany(p => p.Employees)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__CityI__44FF419A");

            entity.HasOne(d => d.District).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__Distr__45F365D3");

            entity.HasOne(d => d.Ethnic).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EthnicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__Ethni__4316F928");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__JobId__440B1D61");

            entity.HasOne(d => d.Ward).WithMany(p => p.Employees)
                .HasForeignKey(d => d.WardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__WardI__46E78A0C");
        });

        modelBuilder.Entity<Ethnic>(entity =>
        {
            entity.HasKey(e => e.EthnicId).HasName("PK__Ethnics__016EE47363BD0F7D");

            entity.Property(e => e.EthnicId).ValueGeneratedNever();
            entity.Property(e => e.EthnicName).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Jobs__056690C24435A493");

            entity.Property(e => e.JobId).ValueGeneratedNever();
            entity.Property(e => e.JobName).HasMaxLength(100);
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.WardId).HasName("PK__Wards__C6BD9BCA10FDA1F0");

            entity.Property(e => e.WardId).ValueGeneratedNever();
            entity.Property(e => e.WardName).HasMaxLength(100);

            entity.HasOne(d => d.District).WithMany(p => p.Wards)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__Wards__DistrictI__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
