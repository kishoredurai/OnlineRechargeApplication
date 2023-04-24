﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineRechargeApplication.Data;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    [DbContext(typeof(OnlineRechargeApplicationContext))]
    [Migration("20230424150832_alter column custmodel")]
    partial class altercolumncustmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineRechargeApplication.Models.AdminModel", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminModel");
                });

            modelBuilder.Entity("OnlineRechargeApplication.Models.CustomerModel", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<int>("CountryCode")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerPhone")
                        .HasColumnType("int");

                    b.Property<string>("ServiceProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerModel");
                });

            modelBuilder.Entity("OnlineRechargeApplication.Models.ServiceProviderModel", b =>
                {
                    b.Property<int>("ServiceProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceProviderId"), 1L, 1);

                    b.Property<string>("ServiceProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceProviderId");

                    b.ToTable("ServiceProviderModel");
                });
#pragma warning restore 612, 618
        }
    }
}
