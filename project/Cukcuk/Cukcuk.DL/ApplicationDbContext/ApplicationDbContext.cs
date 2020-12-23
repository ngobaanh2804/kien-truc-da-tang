using System;
using Cukcuk.EntityModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Cukcuk.DL.ApplicationDbContext
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Possition> Possition { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=35.194.135.168;port=3306;user=dev;password=12345678@Abc;database=MISA_NBAnh_Import", x => x.ServerVersion("10.3.25-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasComment("Bảng dữ liệu phòng ban");

                entity.Property(e => e.DepartmentId)
                    .HasComment("Khóa chính")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasComment("Tên phòng ban")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithOne(p => p.Department)
                    .HasPrincipalKey<Employee>(p => p.DepartmentId)
                    .HasForeignKey<Department>(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_DepartmentId");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasComment("Bảng dữ liệu nhân viên");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("UK_Employee_DepartmentId")
                    .IsUnique();

                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("UK_Employee_EmployeeCode")
                    .IsUnique();

                entity.HasIndex(e => e.PossitionId)
                    .HasName("UK_Employee_PossitionId")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasComment("Khóa chính")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasComment("Ngày sinh");

                entity.Property(e => e.DepartmentId)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(100)")
                    .HasComment("Email nhân viên")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasComment("Mã nhân viên")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasComment("Tên nhân viên")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("int(11)")
                    .HasComment("Giới tính");

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasComment("CMT/Hộ chiếu")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IssueBy)
                    .HasColumnType("varchar(255)")
                    .HasComment("Nơi cấp")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasComment("Ngày cấp");

                entity.Property(e => e.National)
                    .HasColumnType("varchar(100)")
                    .HasComment("Quốc tịch")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("varchar(50)")
                    .HasComment("Số điện thoại")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PossitionId)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18,4)")
                    .HasComment("Lương nhân viên");
            });

            modelBuilder.Entity<Possition>(entity =>
            {
                entity.HasComment("Bảng dữ liệu vị trí/ chức vụ");

                entity.Property(e => e.PossitionId)
                    .HasComment("Khóa chính")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PossitionName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasComment("Tên vị trí/chức vụ")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.PossitionNavigation)
                    .WithOne(p => p.Possition)
                    .HasPrincipalKey<Employee>(p => p.PossitionId)
                    .HasForeignKey<Possition>(d => d.PossitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Possition_PossitionId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
