﻿// <auto-generated />
using System;
using BasicsOfEntityFramework.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicsOfEntityFramework.Domain.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("ProductId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            ProductId = 1,
                            Text = "4"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            ProductId = 1,
                            Text = "4"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 2,
                            ProductId = 2,
                            Text = "5"
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            ProductId = 2,
                            Text = "4+"
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 1,
                            ProductId = 3,
                            Text = "5"
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CustomerName");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Astana",
                            CustomerName = "Tom",
                            Email = "tom@gmail.com",
                            Phone = "789321"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Karaganda",
                            CustomerName = "Alice",
                            Email = "alice@gmail.com",
                            Phone = "159753"
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Number");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Date = new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "Order00001",
                            Status = "Available"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Date = new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = "Order00002",
                            Status = "Accepted"
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName");

                    b.Property<int>("Quantity");

                    b.Property<int>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "HP Notebook Keyboard",
                            Price = 6000m,
                            ProductName = "Keyboard",
                            Quantity = 5,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Mouse Delux",
                            Price = 4000m,
                            ProductName = "Mouse",
                            Quantity = 4,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Monitor Philips",
                            Price = 20000m,
                            ProductName = "Monitor",
                            Quantity = 2,
                            SellerId = 1
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.ProductCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCarts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartId = 1,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            CartId = 2,
                            ProductId = 1,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            ProductId = 1,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("SellerName");

                    b.HasKey("Id");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Almaty",
                            Email = "sam@gmail.com",
                            Phone = "357951",
                            SellerName = "Sam"
                        });
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Cart", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("BasicsOfEntityFramework.Domain.Entities.Cart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Comment", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Customer", "Customer")
                        .WithMany("Comments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Order", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.Product", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.ProductCart", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Cart", "Cart")
                        .WithMany("ProductCarts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BasicsOfEntityFramework.Domain.Entities.ProductOrder", b =>
                {
                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BasicsOfEntityFramework.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}