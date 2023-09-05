using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentDetails.Models;

public partial class StudentManagementContext : DbContext
{
    public StudentManagementContext()
    {
    }

    public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentDetail> StudentDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity.HasKey(e => e.RollNo).HasName("StudentDetails_pkey");

            entity.Property(e => e.RollNo)
                .ValueGeneratedNever()
                .HasColumnName("Roll no");
            entity.Property(e => e.Name).HasColumnType("character varying(20)[]");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
