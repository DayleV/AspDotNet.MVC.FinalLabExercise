// <auto-generated />
using System;
using EmployeeData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeData.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeData.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .IsFixedLength(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeData.Models.EmployeeSkill", b =>
                {
                    b.Property<int>("EmployeeSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeSkillID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal>("HourlyWage")
                        .HasColumnType("money");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int")
                        .HasColumnName("SkillID");

                    b.Property<int?>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("EmployeeSkillId");

                    b.HasIndex(new[] { "EmployeeId" }, "IX_EmployeeSkills_EmployeeID");

                    b.HasIndex(new[] { "SkillId" }, "IX_EmployeeSkills_SkillID");

                    b.ToTable("EmployeeSkills");
                });

            modelBuilder.Entity("EmployeeData.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SkillID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("RequiresTicket")
                        .HasColumnType("bit");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EmployeeData.Models.EmployeeSkill", b =>
                {
                    b.HasOne("EmployeeData.Models.Employee", "Employee")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeData.Models.Skill", "Skill")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("EmployeeData.Models.Employee", b =>
                {
                    b.Navigation("EmployeeSkills");
                });

            modelBuilder.Entity("EmployeeData.Models.Skill", b =>
                {
                    b.Navigation("EmployeeSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
