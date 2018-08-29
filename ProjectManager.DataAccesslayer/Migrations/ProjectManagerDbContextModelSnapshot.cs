﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectManager.DataAccesslayer;
using System;

namespace ProjectManager.DataAccesslayer.Migrations
{
    [DbContext(typeof(ProjectManagerDbContext))]
    partial class ProjectManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManager.Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Project_Id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnName("Status");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnName("End_Date");

                    b.Property<int>("Priority");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnName("Project")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
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
                        .HasColumnName("Task_Id");

                    b.Property<bool>("ActiveStatus")
                        .HasColumnName("Status");

                    b.Property<DateTime>("EndDate")
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

                    b.Property<DateTime>("StartDate")
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
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("User_Id");

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

                    b.HasKey("Userid");

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
