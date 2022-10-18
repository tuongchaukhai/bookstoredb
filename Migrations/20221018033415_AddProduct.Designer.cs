﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookstore.Models;

#nullable disable

namespace bookstore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221018033415_AddProduct")]
    partial class AddProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("bookstore.Models.Product.Age", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Ages");
                });

            modelBuilder.Entity("bookstore.Models.Product.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("bookstore.Models.Product.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("bookstore.Models.Product.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("bookstore.Models.Product.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("bookstore.Models.Product.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("bookstore.Models.Product.ImageProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ImageProducts");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductGenre", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("ProductGenres");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductImageProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ImageProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ImageProductId");

                    b.HasIndex("ImageProductId");

                    b.ToTable("ProductImageProducts");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AgeId")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookLayout")
                        .HasColumnType("longtext");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direction")
                        .HasColumnType("longtext");

                    b.Property<bool?>("HomeFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("HotFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Material")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Origin")
                        .HasColumnType("longtext");

                    b.Property<int?>("PageCount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<DateTime?>("PublicationDate")
                        .HasMaxLength(4)
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Specification")
                        .HasColumnType("longtext");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Translator")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("AgeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("bookstore.Models.Product.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("bookstore.Models.Product.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("bookstore.Models.Product.Category", b =>
                {
                    b.HasOne("bookstore.Models.Product.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductCategory", b =>
                {
                    b.HasOne("bookstore.Models.Product.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bookstore.Models.Product.ProductModel", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductGenre", b =>
                {
                    b.HasOne("bookstore.Models.Product.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bookstore.Models.Product.ProductModel", "Product")
                        .WithMany("ProductGenres")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductImageProduct", b =>
                {
                    b.HasOne("bookstore.Models.Product.ImageProduct", "ImageProduct")
                        .WithMany()
                        .HasForeignKey("ImageProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bookstore.Models.Product.ProductModel", "Product")
                        .WithMany("ProductImageProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImageProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductModel", b =>
                {
                    b.HasOne("bookstore.Models.Product.Age", "Age")
                        .WithMany()
                        .HasForeignKey("AgeId");

                    b.HasOne("bookstore.Models.Product.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("bookstore.Models.Product.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("bookstore.Models.Product.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("bookstore.Models.Product.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("bookstore.Models.Product.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId");

                    b.HasOne("bookstore.Models.Product.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Age");

                    b.Navigation("Author");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Publisher");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("bookstore.Models.Product.ProductModel", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductGenres");

                    b.Navigation("ProductImageProducts");
                });
#pragma warning restore 612, 618
        }
    }
}