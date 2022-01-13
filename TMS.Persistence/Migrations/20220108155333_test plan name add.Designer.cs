﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMS.Persistence;

namespace TMS.Persistence.Migrations
{
    [DbContext(typeof(TmsDbContext))]
    [Migration("20220108155333_test plan name add")]
    partial class testplannameadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TMS.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdditionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectStatusId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TMS.Domain.ProjectParticipants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdditionToProject")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectRoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasAlternateKey("ProjectId", "UserId");

                    b.HasIndex("ProjectRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectParticipants");
                });

            modelBuilder.Entity("TMS.Domain.ProjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectRoles");
                });

            modelBuilder.Entity("TMS.Domain.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasAlternateKey("StatusName");

                    b.ToTable("ProjectStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusName = "Open"
                        },
                        new
                        {
                            Id = 2,
                            StatusName = "Close"
                        });
                });

            modelBuilder.Entity("TMS.Domain.TestCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("TestCases");
                });

            modelBuilder.Entity("TMS.Domain.TestCaseResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdditionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestCaseResultResultId")
                        .HasColumnType("int");

                    b.Property<int>("TestPlanCasesId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseResultResultId");

                    b.HasIndex("TestPlanCasesId");

                    b.HasIndex("UserId");

                    b.ToTable("TestCaseResults");
                });

            modelBuilder.Entity("TMS.Domain.TestCaseResultResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResultName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestCaseResultResults");
                });

            modelBuilder.Entity("TMS.Domain.TestCaseStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestCaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId");

                    b.ToTable("TestCaseSteps");
                });

            modelBuilder.Entity("TMS.Domain.TestPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdditionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("SatusId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TestPlanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SatusId");

                    b.HasIndex("UserId");

                    b.ToTable("TestPlans");
                });

            modelBuilder.Entity("TMS.Domain.TestPlanCases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TestCaseId")
                        .HasColumnType("int");

                    b.Property<int?>("TestPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseId");

                    b.HasIndex("TestPlanId");

                    b.ToTable("TestPlanCases");
                });

            modelBuilder.Entity("TMS.Domain.TestPlanStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestPlanStatus");
                });

            modelBuilder.Entity("TMS.Domain.TestStepResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FactReaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestCaseResultId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestCaseResultId");

                    b.ToTable("TestStepResults");
                });

            modelBuilder.Entity("TMS.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TMS.Domain.Project", b =>
                {
                    b.HasOne("TMS.Domain.ProjectStatus", "ProjectStatus")
                        .WithMany()
                        .HasForeignKey("ProjectStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectStatus");
                });

            modelBuilder.Entity("TMS.Domain.ProjectParticipants", b =>
                {
                    b.HasOne("TMS.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.ProjectRole", "ProjectRole")
                        .WithMany()
                        .HasForeignKey("ProjectRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("ProjectRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS.Domain.TestCase", b =>
                {
                    b.HasOne("TMS.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS.Domain.TestCaseResult", b =>
                {
                    b.HasOne("TMS.Domain.TestCaseResultResult", "TestCaseResultResult")
                        .WithMany()
                        .HasForeignKey("TestCaseResultResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.TestPlanCases", "TestPlanCase")
                        .WithMany()
                        .HasForeignKey("TestPlanCasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("TestCaseResultResult");

                    b.Navigation("TestPlanCase");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS.Domain.TestCaseStep", b =>
                {
                    b.HasOne("TMS.Domain.TestCase", "TestCase")
                        .WithMany()
                        .HasForeignKey("TestCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCase");
                });

            modelBuilder.Entity("TMS.Domain.TestPlan", b =>
                {
                    b.HasOne("TMS.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS.Domain.TestPlanStatus", "Satus")
                        .WithMany()
                        .HasForeignKey("SatusId");

                    b.HasOne("TMS.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("Satus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS.Domain.TestPlanCases", b =>
                {
                    b.HasOne("TMS.Domain.TestCase", "TestCase")
                        .WithMany()
                        .HasForeignKey("TestCaseId");

                    b.HasOne("TMS.Domain.TestPlan", "TestPlan")
                        .WithMany()
                        .HasForeignKey("TestPlanId");

                    b.Navigation("TestCase");

                    b.Navigation("TestPlan");
                });

            modelBuilder.Entity("TMS.Domain.TestStepResult", b =>
                {
                    b.HasOne("TMS.Domain.TestCaseResult", "TestCaseResult")
                        .WithMany()
                        .HasForeignKey("TestCaseResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCaseResult");
                });
#pragma warning restore 612, 618
        }
    }
}
