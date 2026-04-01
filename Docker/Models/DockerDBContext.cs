using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Docker.Models;

public partial class DockerDBContext : DbContext
{
    public DockerDBContext()
    {
    }

    public DockerDBContext(DbContextOptions<DockerDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=localhost;Database=DockerDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCDCA8FAFBD");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF195FC0580");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasConstraintName("FK__Employees__Depar__398D8EEE");
        });

        modelBuilder.Entity<EmployeeProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC27EA23EE8D");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeProjects).HasConstraintName("FK__EmployeeP__Emplo__3E52440B");

            entity.HasOne(d => d.Project).WithMany(p => p.EmployeeProjects).HasConstraintName("FK__EmployeeP__Proje__3F466844");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__761ABED09141442E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
