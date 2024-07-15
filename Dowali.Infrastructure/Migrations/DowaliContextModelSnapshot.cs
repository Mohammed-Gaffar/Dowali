﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    [DbContext(typeof(DowaliContext))]
    partial class DowaliContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_by")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dowali.Core.Entities.Financial_Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<double>("Equepment_And_Accessories")
                        .HasColumnType("float");

                    b.Property<double>("Exchange_Visits")
                        .HasColumnType("float");

                    b.Property<double>("External_Partner_Contract_include_Tax")
                        .HasColumnType("float");

                    b.Property<double>("Other_Expendtiure_items")
                        .HasColumnType("float");

                    b.Property<int>("Project_Id")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_by")
                        .HasColumnType("int");

                    b.Property<double>("Wages_Salaries")
                        .HasColumnType("float");

                    b.Property<double>("consumable")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Financial_Sections");
                });

            modelBuilder.Entity("Dowali.Core.Entities.Investigator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<string>("Ex_Inv_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Ext_Inv_Academic_Rank")
                        .HasColumnType("int");

                    b.Property<string>("Ext_Inv_Address_Of_Institiution")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ext_Inv_Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ext_Inv_Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Ext_Inv_Mobile_Number")
                        .HasColumnType("int");

                    b.Property<int>("Ext_Inv_Office_Phone")
                        .HasColumnType("int");

                    b.Property<string>("Ext_inv_College_Center")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Int_Inv_Academic_Rank")
                        .HasColumnType("int");

                    b.Property<string>("Int_Inv_Address_Of_Institiution")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Int_Inv_Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Int_Inv_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Int_Inv_Office_Phone")
                        .HasColumnType("int");

                    b.Property<string>("Int_inv_College_Center")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Inv_Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_by")
                        .HasColumnType("int");

                    b.Property<string>("int_Inv_Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("int_Inv_Mobile_Number")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Investigators");
                });

            modelBuilder.Entity("Dowali.Core.Entities.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("Created_by")
                        .HasColumnType("int");

                    b.Property<int>("Douration")
                        .HasColumnType("int");

                    b.Property<int>("External_Int_Id")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<string>("File_Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Internal_Inv_Id")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<string>("Main_Field")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sub_Field")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Summary_Ar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Summary_En")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title_Ar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title_En")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_by")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
