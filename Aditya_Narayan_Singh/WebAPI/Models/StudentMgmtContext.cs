using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentDetails.Models;

public partial class StudentMgmtContext : DbContext
{
    public StudentMgmtContext()
    {
    }

    public StudentMgmtContext(DbContextOptions<StudentMgmtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dummy> Dummies { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dummy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dummy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rollno).HasName("student_pkey");

            entity.ToTable("student");

            entity.Property(e => e.Rollno)
                .ValueGeneratedNever()
                .HasColumnName("rollno");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
