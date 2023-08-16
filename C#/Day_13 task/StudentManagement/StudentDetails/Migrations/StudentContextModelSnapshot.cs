﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentDetails.Context;

#nullable disable

namespace StudentDetails.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentDetails.Models.Student", b =>
                {
                    b.Property<int>("Rollno")
                        .HasColumnType("int");

                    b.Property<string>("Addr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Studentame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("phno")
                        .HasColumnType("bigint");

                    b.HasKey("Rollno");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}