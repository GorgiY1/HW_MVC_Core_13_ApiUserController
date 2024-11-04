﻿// <auto-generated />
using System;
using HW_MVC_Core_11_Roles_2.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW_MVC_Core_11_Roles_2.Migrations.Products
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20241021105708_Create_Products")]
    partial class Create_Products
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("products")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop_app.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products", "products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac6dbf0c-753b-441d-8a9c-add7843a9d02"),
                            Description = "High performance laptop for gaming and work",
                            Name = "Laptop",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = new Guid("e80c0dcc-10d0-40c6-89dd-d55d988fe6e6"),
                            Description = "Latest smartphone with 5G connectivity",
                            Name = "Smartphone",
                            Price = 599.99m
                        },
                        new
                        {
                            Id = new Guid("40ab9282-07da-48c7-9425-71e456adcd4b"),
                            Description = "Noise-cancelling over-ear headphones",
                            Name = "Headphones",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = new Guid("eac29f27-c2d2-4986-9bba-d23d85ca2e02"),
                            Description = "27-inch 4K UHD monitor for professional use",
                            Name = "Monitor",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = new Guid("62dbb15e-dee8-4c49-b710-7b70d6d8b655"),
                            Description = "Mechanical keyboard with RGB backlight",
                            Name = "Keyboard",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("aca44239-cb31-4b33-9190-f59a5ab88018"),
                            Description = "Wireless optical mouse with ergonomic design",
                            Name = "Mouse",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("19bc4394-0a11-488e-aa56-19197159760e"),
                            Description = "10-inch tablet with high-resolution display",
                            Name = "Tablet",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = new Guid("38ec0de2-ffbf-44df-ab3c-c02ddf1b4013"),
                            Description = "All-in-one color printer with Wi-Fi support",
                            Name = "Printer",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = new Guid("2462991a-af65-4aa1-afb8-378dca7ea7cf"),
                            Description = "1TB external hard drive for data backup",
                            Name = "External Hard Drive",
                            Price = 89.99m
                        },
                        new
                        {
                            Id = new Guid("8807c933-f3bc-4243-81ae-8fea13f469f5"),
                            Description = "1080p HD webcam with built-in microphone",
                            Name = "Webcam",
                            Price = 59.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}