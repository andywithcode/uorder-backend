﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(UOrderDbContext))]
    partial class UOrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Accounts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            IsActive = true,
                            Password = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entities.Dish", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CompletionTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 5, 14, 28, 4, 106, DateTimeKind.Local).AddTicks(4459));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("QtyPerDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(100);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dishes", (string)null);
                });

            modelBuilder.Entity("Data.Entities.DishMedia", b =>
                {
                    b.Property<string>("MediaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MediaId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("DishOfMedia", (string)null);
                });

            modelBuilder.Entity("Data.Entities.DishMenu", b =>
                {
                    b.Property<string>("MenuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MenuId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("DishOfMenu", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Media", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 5, 14, 28, 4, 108, DateTimeKind.Local).AddTicks(2380));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medias", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Menu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 5, 14, 28, 4, 108, DateTimeKind.Local).AddTicks(4215));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Menus", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 5, 14, 28, 4, 108, DateTimeKind.Local).AddTicks(5164));

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("OrderStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("PaymentStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("TableId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Data.Entities.OrderDetail", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("Data.Entities.SystemSetting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ChefCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("SystemSettings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ChefCount = 1
                        });
                });

            modelBuilder.Entity("Data.Entities.Table", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 10, 5, 14, 28, 4, 109, DateTimeKind.Local).AddTicks(3563));

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Tables", (string)null);
                });

            modelBuilder.Entity("Data.Entities.DishMedia", b =>
                {
                    b.HasOne("Data.Entities.Dish", "Dish")
                        .WithMany("DishMedias")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Media", "Media")
                        .WithMany("DishMedias")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("Data.Entities.DishMenu", b =>
                {
                    b.HasOne("Data.Entities.Dish", "Dish")
                        .WithMany("DishMenus")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Menu", "Menu")
                        .WithMany("DishMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Data.Entities.Order", b =>
                {
                    b.HasOne("Data.Entities.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("Data.Entities.Dish", "Dish")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Data.Entities.Dish", b =>
                {
                    b.Navigation("DishMedias");

                    b.Navigation("DishMenus");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Data.Entities.Media", b =>
                {
                    b.Navigation("DishMedias");
                });

            modelBuilder.Entity("Data.Entities.Menu", b =>
                {
                    b.Navigation("DishMenus");
                });

            modelBuilder.Entity("Data.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Data.Entities.Table", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
