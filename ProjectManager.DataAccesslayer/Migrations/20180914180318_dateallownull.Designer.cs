﻿// <auto-generated />
using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManager.DataAccesslayer;

namespace ProjectManager.DataAccesslayer.Migrations
{
    [DbContext(typeof(ProjectManagerDbContext))]
    [Migration("20180914180318_dateallownull")]
    [ExcludeFromCodeCoverage]
    partial class dateallownull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManager.Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Project_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ActiveStatus")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("End_Date");

                    b.Property<int>("Priority");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnName("Project")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnName("Start_Date");

                    b.Property<int>("UserId")
                        .HasColumnName("User_Id");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ProjectManager.Model.TaskDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Task_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ActiveStatus")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("End_Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Task")
                        .HasMaxLength(100);

                    b.Property<int?>("ParentId")
                        .HasColumnName("ParentId");

                    b.Property<int>("Priority");

                    b.Property<int>("ProjectId")
                        .HasColumnName("Project_Id");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnName("Start_Date");

                    b.Property<int>("UserId")
                        .HasColumnName("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("ProjectManager.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("User_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnName("Employee_Id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProjectManager.Model.Project", b =>
                {
                    b.HasOne("ProjectManager.Model.User", "UserDetail")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjectManager.Model.TaskDetail", b =>
                {
                    b.HasOne("ProjectManager.Model.Project", "ProjectDetail")
                        .WithMany("TaskDetails")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProjectManager.Model.User", "UserDetail")
                        .WithMany("TaskDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
