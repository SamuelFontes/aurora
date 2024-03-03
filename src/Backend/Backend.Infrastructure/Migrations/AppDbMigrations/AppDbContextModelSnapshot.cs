﻿// <auto-generated />
using System;
using Backend.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Infrastructure.Migrations.AppDbMigrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Backend.Domain.Entities.Agents.Agent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Active = true,
                            CategoryName = "Eletronic",
                            Created = new DateTime(2024, 3, 2, 22, 59, 55, 304, DateTimeKind.Utc).AddTicks(7843),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.ProductTypes.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Description = "Crafting material",
                            Name = "Feedstock"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Description = "Intermediate Product/Crafting material",
                            Name = "Intermediate Component"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Description = "Final Product",
                            Name = "Product"
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GTIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("LiquidWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<double?>("TotalWeight")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a910ea5b-2d5a-4cc5-8093-1bf042c5504f"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Created = new DateTime(2024, 3, 2, 22, 59, 55, 304, DateTimeKind.Utc).AddTicks(7975),
                            Description = "Produto de teste gerado na migration - Aurora",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.13,
                            Name = "Samsung Galaxy S4",
                            ProductTypeId = 3,
                            SKU = "202401",
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5"),
                            TotalWeight = 0.13,
                            Value = 604.99000000000001
                        },
                        new
                        {
                            Id = new Guid("393c064a-ac56-4c97-b9bc-97995a0157c1"),
                            Active = true,
                            Created = new DateTime(2024, 3, 2, 22, 59, 55, 304, DateTimeKind.Utc).AddTicks(7984),
                            Description = "Produto de teste gerado na migration - SampleCompany",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.0,
                            Name = "Motorola Moto E",
                            ProductTypeId = 3,
                            SKU = "202401",
                            TenantId = new Guid("ae100414-8fbb-4286-839a-5bafc51a84fb"),
                            TotalWeight = 0.0,
                            Value = 100.0
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<int>("MediaType")
                        .HasColumnType("integer");

                    b.Property<string>("MediaURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Priority")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMedia");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Stock.Stock", b =>
                {
                    b.Property<Guid>("StockMovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("MovementDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MovementStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("MovementType")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VariantId")
                        .HasColumnType("uuid");

                    b.HasKey("StockMovementId");

                    b.HasIndex("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.Property<Guid>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");

                    b.HasData(
                        new
                        {
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Created = new DateTime(2024, 3, 2, 22, 59, 55, 304, DateTimeKind.Utc).AddTicks(7921),
                            SubCategoryName = "Smartphone",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Backend.Domain.Entities.ProductTypes.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Domain.Entities.SubCategories.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("Category");

                    b.Navigation("ProductType");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductMedia", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Stock.Stock", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Agents.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
