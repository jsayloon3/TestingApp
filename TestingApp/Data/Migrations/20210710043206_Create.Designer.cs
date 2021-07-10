﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingApp.Data;

namespace TestingApp.Data.Migrations
{
    [DbContext(typeof(TestAppContext))]
    [Migration("20210710043206_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestingApp.Models.TestAppRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assigned_Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assigned_Tester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cycle_Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Per_Cycle_Count")
                        .HasColumnType("datetime2");

                    b.Property<int>("Issue_Number")
                        .HasColumnType("int");

                    b.Property<int>("Issue_Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TestAppRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
