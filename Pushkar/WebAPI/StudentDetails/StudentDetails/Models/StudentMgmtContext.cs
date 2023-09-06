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

    // each table will be shown as different DbSet
    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
