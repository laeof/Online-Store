﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Online_Store.Domain;

#nullable disable

namespace Online_Store.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230814181021_changes140820232110")]
    partial class changes140820232110
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Online_Store.Domain.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.CartItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Discounts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Begin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Percent")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.OrderItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Payments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Additional")
                        .HasColumnType("text");

                    b.Property<int?>("Amount")
                        .HasColumnType("integer");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Guarantee")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<string>("Kit")
                        .HasColumnType("text");

                    b.Property<Guid?>("MonitorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MonitorId");

                    b.ToTable("Products");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.ProductImages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d"),
                            Created = new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8391),
                            IsDeleted = false,
                            IsNew = true,
                            Name = "admin",
                            Priority = 1
                        },
                        new
                        {
                            Id = new Guid("acba65e7-a2e0-4805-9f57-4880d2f9f57b"),
                            Created = new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8440),
                            IsDeleted = false,
                            IsNew = true,
                            Name = "manager",
                            Priority = 2
                        },
                        new
                        {
                            Id = new Guid("281cc92a-1595-4227-a0ad-639a4aee3616"),
                            Created = new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8448),
                            IsDeleted = false,
                            IsNew = true,
                            Name = "supporter",
                            Priority = 3
                        },
                        new
                        {
                            Id = new Guid("15dbc710-9a99-478a-b9b2-91c5abfdb776"),
                            Created = new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8454),
                            IsDeleted = false,
                            IsNew = true,
                            Name = "user",
                            Priority = 4
                        });
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ApiKey")
                        .HasColumnType("text");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e673aa99-cf98-4bca-82d4-296852356f1b"),
                            ApiKey = "xd",
                            AvatarUrl = "../../../../img/Avatar/user.png",
                            Created = new DateTime(2023, 8, 14, 18, 10, 21, 184, DateTimeKind.Utc).AddTicks(8457),
                            Email = "Admin",
                            FirstName = "Max",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = false,
                            IsNew = true,
                            LastName = "Admin",
                            Password = "$HASH|V1$10000$2WZTanMJNNq52zdj5cVzzcXKLeJUpOU1mSo00CNeJ39YF3P8",
                            PhoneNumber = "1234567890",
                            RoleId = new Guid("b9083f5c-1cf3-4af2-975f-0d76674ce03d")
                        });
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.Keyboard", b =>
                {
                    b.HasBaseType("Online_Store.Domain.Entities.Product");

                    b.ToTable("Keyboards");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.Monitor", b =>
                {
                    b.HasBaseType("Online_Store.Domain.Entities.Product");

                    b.Property<string>("Brightness")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Contrast")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Diagonal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Interfaces")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MatrixType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ratio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Reaction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Cart", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.CartItems", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Store.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Order", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.OrderItems", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Payments", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Product", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Store.Domain.Entities.Products.Monitor", null)
                        .WithMany("Products")
                        .HasForeignKey("MonitorId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.ProductImages", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Review", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Store.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.User", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.Keyboard", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Product", null)
                        .WithOne()
                        .HasForeignKey("Online_Store.Domain.Entities.Products.Keyboard", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.Monitor", b =>
                {
                    b.HasOne("Online_Store.Domain.Entities.Product", null)
                        .WithOne()
                        .HasForeignKey("Online_Store.Domain.Entities.Products.Monitor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Product", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.User", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Online_Store.Domain.Entities.Products.Monitor", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}