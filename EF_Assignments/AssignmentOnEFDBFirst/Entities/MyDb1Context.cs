using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFDBFirst.Entities;

public partial class MyDb1Context : DbContext
{
    public MyDb1Context()
    {
        
    }

    public MyDb1Context(DbContextOptions<MyDb1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EmDetail> EmDetails { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Gender1> Gender1s { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<VwDepartment1> VwDepartment1s { get; set; }

    public virtual DbSet<VwEmDept> VwEmDepts { get; set; }

    public virtual DbSet<VwEmDept1> VwEmDept1s { get; set; }

    public virtual DbSet<VwEmpdetail> VwEmpdetails { get; set; }

    public virtual DbSet<VwEmpdetails1> VwEmpdetails1s { get; set; }

    public virtual DbSet<VwEmpdetails3> VwEmpdetails3s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DAUGHTER-OF-SRI;Initial Catalog=MyDB1;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptCode).HasName("dept_pk");

            entity.ToTable("Department");

            entity.HasIndex(e => e.DeptName, "UQ__Departme__C7D39AE19A195682").IsUnique();

            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
        });

        modelBuilder.Entity<EmDetail>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBA79E749F075");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("EmpID");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dept_code");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Joindate).HasColumnName("joindate");

            entity.HasOne(d => d.DeptCodeNavigation).WithMany(p => p.EmDetails)
                .HasForeignKey(d => d.DeptCode)
                .HasConstraintName("employee_fk1");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gender");

            entity.Property(e => e.Gender1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Gender1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gender1");

            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__product__DD37D91A23D5DE11");

            entity.ToTable("product");

            entity.HasIndex(e => e.Pname, "UQ__product__1FC9734CCC4B0B7A").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Stock).HasColumnName("stock");
        });

        modelBuilder.Entity<VwDepartment1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_department1");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
        });

        modelBuilder.Entity<VwEmDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_em_dept");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwEmDept1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_em_dept1");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwEmpdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_empdetails");

            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Empid).HasColumnName("empid");
        });

        modelBuilder.Entity<VwEmpdetails1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_empdetails1");

            entity.Property(e => e.Empid).HasColumnName("empid");
        });

        modelBuilder.Entity<VwEmpdetails3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_empdetails3");

            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
