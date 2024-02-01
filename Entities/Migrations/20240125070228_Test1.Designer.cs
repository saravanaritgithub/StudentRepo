﻿// <auto-generated />
using System;
using ConsoleToDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240125070228_Test1")]
    partial class Test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Display", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarkId")
                        .HasColumnType("int");

                    b.Property<int>("MarksMarkId")
                        .HasColumnType("int");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarksMarkId");

                    b.ToTable("Display");
                });

            modelBuilder.Entity("Entities.Models.Marks", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkId"));

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Math")
                        .HasColumnType("int");

                    b.Property<int>("Science")
                        .HasColumnType("int");

                    b.Property<int>("Social")
                        .HasColumnType("int");

                    b.Property<int>("StudentDetailsRegno")
                        .HasColumnType("int");

                    b.Property<int>("Tamil")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("MarkId");

                    b.HasIndex("StudentDetailsRegno");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("Entities.Models.StudentDetails", b =>
                {
                    b.Property<int>("Regno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Regno"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phno")
                        .HasColumnType("bigint");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Std")
                        .HasColumnType("int");

                    b.HasKey("Regno");

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Entities.Models.Display", b =>
                {
                    b.HasOne("Entities.Models.Marks", "Marks")
                        .WithMany()
                        .HasForeignKey("MarksMarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marks");
                });

            modelBuilder.Entity("Entities.Models.Marks", b =>
                {
                    b.HasOne("Entities.Models.StudentDetails", "StudentDetails")
                        .WithMany()
                        .HasForeignKey("StudentDetailsRegno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
