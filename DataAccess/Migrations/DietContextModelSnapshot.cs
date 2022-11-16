﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DietContext))]
    partial class DietContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 16, 16, 45, 23, 791, DateTimeKind.Local).AddTicks(6516));

                    b.Property<int>("MealTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 16, 16, 45, 23, 791, DateTimeKind.Local).AddTicks(7015));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)");

                    b.HasKey("Id");

                    b.HasIndex("MealTypeID");

                    b.HasIndex("UserName");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("Entities.Concrete.MealDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Gram")
                        .HasColumnType("float");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealID");

                    b.HasIndex("ProductId");

                    b.ToTable("MealDetail");
                });

            modelBuilder.Entity("Entities.Concrete.MealType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("MealType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TypeName = "Kahvaltı"
                        },
                        new
                        {
                            Id = 2,
                            TypeName = "AraÖğün"
                        },
                        new
                        {
                            Id = 3,
                            TypeName = "ÖğleYemeği"
                        },
                        new
                        {
                            Id = 4,
                            TypeName = "AkşamYemeği"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(5302));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ProductTypeID")
                        .HasColumnType("int");

                    b.Property<double?>("UnitCalorie")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(5607));

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductName = "Antrikot",
                            ProductTypeID = 1,
                            UnitCalorie = 1.21
                        },
                        new
                        {
                            Id = 2,
                            ProductName = "Biftek",
                            ProductTypeID = 1,
                            UnitCalorie = 2.4199999999999999
                        },
                        new
                        {
                            Id = 3,
                            ProductName = "Bonfile",
                            ProductTypeID = 1,
                            UnitCalorie = 1.3799999999999999
                        },
                        new
                        {
                            Id = 4,
                            ProductName = "Dana Kıyma",
                            ProductTypeID = 1,
                            UnitCalorie = 2.46
                        },
                        new
                        {
                            Id = 5,
                            ProductName = "Hindi Budu",
                            ProductTypeID = 1,
                            UnitCalorie = 2.0800000000000001
                        },
                        new
                        {
                            Id = 6,
                            ProductName = "Hindi Göğsü",
                            ProductTypeID = 1,
                            UnitCalorie = 1.3500000000000001
                        },
                        new
                        {
                            Id = 7,
                            ProductName = "Hindi Kanadı",
                            ProductTypeID = 1,
                            UnitCalorie = 2.21
                        },
                        new
                        {
                            Id = 8,
                            ProductName = "Kuzu Pirzola",
                            ProductTypeID = 1,
                            UnitCalorie = 2.7599999999999998
                        },
                        new
                        {
                            Id = 9,
                            ProductName = "Kuzu İncik",
                            ProductTypeID = 1,
                            UnitCalorie = 2.0099999999999998
                        },
                        new
                        {
                            Id = 10,
                            ProductName = "Sığır Eti",
                            ProductTypeID = 1,
                            UnitCalorie = 2.48
                        },
                        new
                        {
                            Id = 11,
                            ProductName = "Sığır Filetosu",
                            ProductTypeID = 1,
                            UnitCalorie = 2.1800000000000002
                        },
                        new
                        {
                            Id = 12,
                            ProductName = "Sığır Kaburgası",
                            ProductTypeID = 1,
                            UnitCalorie = 2.3799999999999999
                        },
                        new
                        {
                            Id = 13,
                            ProductName = "Tavuk But",
                            ProductTypeID = 1,
                            UnitCalorie = 1.74
                        },
                        new
                        {
                            Id = 14,
                            ProductName = "Tavuk Ciğeri",
                            ProductTypeID = 1,
                            UnitCalorie = 1.6699999999999999
                        },
                        new
                        {
                            Id = 15,
                            ProductName = "Tavuk Göğsü",
                            ProductTypeID = 1,
                            UnitCalorie = 1.72
                        },
                        new
                        {
                            Id = 16,
                            ProductName = "Tavuk Kanadı",
                            ProductTypeID = 1,
                            UnitCalorie = 2.6600000000000001
                        },
                        new
                        {
                            Id = 17,
                            ProductName = "Tavuk Taşlığı",
                            ProductTypeID = 1,
                            UnitCalorie = 1.46
                        },
                        new
                        {
                            Id = 18,
                            ProductName = "Tavuk Yağı",
                            ProductTypeID = 1,
                            UnitCalorie = 8.9800000000000004
                        },
                        new
                        {
                            Id = 19,
                            ProductName = "Ördek",
                            ProductTypeID = 1,
                            UnitCalorie = 3.3700000000000001
                        },
                        new
                        {
                            Id = 20,
                            ProductName = "Şinitzel",
                            ProductTypeID = 1,
                            UnitCalorie = 1.5600000000000001
                        },
                        new
                        {
                            Id = 21,
                            ProductName = "Alabalık",
                            ProductTypeID = 2,
                            UnitCalorie = 1.8999999999999999
                        },
                        new
                        {
                            Id = 22,
                            ProductName = "Havyar",
                            ProductTypeID = 2,
                            UnitCalorie = 2.6400000000000001
                        },
                        new
                        {
                            Id = 23,
                            ProductName = "Lüfer",
                            ProductTypeID = 2,
                            UnitCalorie = 1.5900000000000001
                        },
                        new
                        {
                            Id = 24,
                            ProductName = "Mezgit",
                            ProductTypeID = 2,
                            UnitCalorie = 0.90000000000000002
                        },
                        new
                        {
                            Id = 25,
                            ProductName = "Midye",
                            ProductTypeID = 2,
                            UnitCalorie = 1.72
                        },
                        new
                        {
                            Id = 26,
                            ProductName = "Ton Balığı",
                            ProductTypeID = 2,
                            UnitCalorie = 1.3200000000000001
                        },
                        new
                        {
                            Id = 27,
                            ProductName = "Uskumru",
                            ProductTypeID = 2,
                            UnitCalorie = 2.6200000000000001
                        },
                        new
                        {
                            Id = 28,
                            ProductName = "Çipura",
                            ProductTypeID = 2,
                            UnitCalorie = 1.3500000000000001
                        },
                        new
                        {
                            Id = 29,
                            ProductName = "Somon",
                            ProductTypeID = 2,
                            UnitCalorie = 2.0600000000000001
                        },
                        new
                        {
                            Id = 30,
                            ProductName = "Kalkan Balığı",
                            ProductTypeID = 2,
                            UnitCalorie = 1.22
                        },
                        new
                        {
                            Id = 31,
                            ProductName = "Cheddar Peyniri ",
                            ProductTypeID = 3,
                            UnitCalorie = 4.0300000000000002
                        },
                        new
                        {
                            Id = 32,
                            ProductName = "Hellim",
                            ProductTypeID = 3,
                            UnitCalorie = 3.21
                        },
                        new
                        {
                            Id = 33,
                            ProductName = "Kaşar Peyniri",
                            ProductTypeID = 3,
                            UnitCalorie = 3.3700000000000001
                        },
                        new
                        {
                            Id = 34,
                            ProductName = "Tulum Peyniri",
                            ProductTypeID = 3,
                            UnitCalorie = 3.6299999999999999
                        },
                        new
                        {
                            Id = 35,
                            ProductName = "Yumuşak Peynir",
                            ProductTypeID = 3,
                            UnitCalorie = 2.6800000000000002
                        },
                        new
                        {
                            Id = 36,
                            ProductName = "Bazlama",
                            ProductTypeID = 3,
                            UnitCalorie = 2.3999999999999999
                        },
                        new
                        {
                            Id = 37,
                            ProductName = "Beyaz Ekmek",
                            ProductTypeID = 3,
                            UnitCalorie = 2.3799999999999999
                        },
                        new
                        {
                            Id = 38,
                            ProductName = "Esmer Ekmek",
                            ProductTypeID = 3,
                            UnitCalorie = 2.5
                        },
                        new
                        {
                            Id = 39,
                            ProductName = "Hamburger Ekmeği",
                            ProductTypeID = 3,
                            UnitCalorie = 1.78
                        },
                        new
                        {
                            Id = 40,
                            ProductName = "Lavaş",
                            ProductTypeID = 3,
                            UnitCalorie = 2.6400000000000001
                        },
                        new
                        {
                            Id = 41,
                            ProductName = "Mısır Ekmeği",
                            ProductTypeID = 3,
                            UnitCalorie = 1.79
                        },
                        new
                        {
                            Id = 42,
                            ProductName = "Tam Buğday Ekmek",
                            ProductTypeID = 3,
                            UnitCalorie = 2.4700000000000002
                        },
                        new
                        {
                            Id = 43,
                            ProductName = "Zeytin Yağı",
                            ProductTypeID = 3,
                            UnitCalorie = 8.8399999999999999
                        },
                        new
                        {
                            Id = 44,
                            ProductName = "Yeşil Zeytin",
                            ProductTypeID = 3,
                            UnitCalorie = 1.1499999999999999
                        },
                        new
                        {
                            Id = 45,
                            ProductName = "Siyah Zeytin",
                            ProductTypeID = 3,
                            UnitCalorie = 1.1499999999999999
                        },
                        new
                        {
                            Id = 46,
                            ProductName = "Bal",
                            ProductTypeID = 3,
                            UnitCalorie = 3.04
                        },
                        new
                        {
                            Id = 47,
                            ProductName = "Erik Reçeli",
                            ProductTypeID = 3,
                            UnitCalorie = 2.5
                        },
                        new
                        {
                            Id = 48,
                            ProductName = "Fıstık Ezmesi",
                            ProductTypeID = 3,
                            UnitCalorie = 5.8899999999999997
                        },
                        new
                        {
                            Id = 49,
                            ProductName = "Kayısı Reçeli",
                            ProductTypeID = 3,
                            UnitCalorie = 2.5
                        },
                        new
                        {
                            Id = 50,
                            ProductName = "Yumurta",
                            ProductTypeID = 3,
                            UnitCalorie = 0.96999999999999997
                        },
                        new
                        {
                            Id = 51,
                            ProductName = "Bamya ",
                            ProductTypeID = 4,
                            UnitCalorie = 0.33000000000000002
                        },
                        new
                        {
                            Id = 52,
                            ProductName = "Bezelye",
                            ProductTypeID = 4,
                            UnitCalorie = 0.81000000000000005
                        },
                        new
                        {
                            Id = 53,
                            ProductName = "Biber",
                            ProductTypeID = 4,
                            UnitCalorie = 0.27000000000000002
                        },
                        new
                        {
                            Id = 54,
                            ProductName = "Domates",
                            ProductTypeID = 4,
                            UnitCalorie = 0.17999999999999999
                        },
                        new
                        {
                            Id = 55,
                            ProductName = "Havuç",
                            ProductTypeID = 4,
                            UnitCalorie = 0.40999999999999998
                        },
                        new
                        {
                            Id = 56,
                            ProductName = "Kırmızı Biber",
                            ProductTypeID = 4,
                            UnitCalorie = 0.26000000000000001
                        },
                        new
                        {
                            Id = 57,
                            ProductName = "Kabak",
                            ProductTypeID = 4,
                            UnitCalorie = 0.26000000000000001
                        },
                        new
                        {
                            Id = 58,
                            ProductName = "Lahana",
                            ProductTypeID = 4,
                            UnitCalorie = 0.25
                        },
                        new
                        {
                            Id = 59,
                            ProductName = "Mantar",
                            ProductTypeID = 4,
                            UnitCalorie = 0.22
                        },
                        new
                        {
                            Id = 60,
                            ProductName = "Mısır",
                            ProductTypeID = 4,
                            UnitCalorie = 3.6499999999999999
                        },
                        new
                        {
                            Id = 61,
                            ProductName = "Patates",
                            ProductTypeID = 4,
                            UnitCalorie = 0.77000000000000002
                        },
                        new
                        {
                            Id = 62,
                            ProductName = "Patlıcan",
                            ProductTypeID = 4,
                            UnitCalorie = 0.25
                        },
                        new
                        {
                            Id = 63,
                            ProductName = "Pırasa",
                            ProductTypeID = 4,
                            UnitCalorie = 0.60999999999999999
                        },
                        new
                        {
                            Id = 64,
                            ProductName = "Salatalık",
                            ProductTypeID = 4,
                            UnitCalorie = 1.49
                        },
                        new
                        {
                            Id = 65,
                            ProductName = "Soğan",
                            ProductTypeID = 4,
                            UnitCalorie = 0.40000000000000002
                        },
                        new
                        {
                            Id = 66,
                            ProductName = "Sarımsak",
                            ProductTypeID = 4,
                            UnitCalorie = 1.49
                        },
                        new
                        {
                            Id = 67,
                            ProductName = "Turp",
                            ProductTypeID = 4,
                            UnitCalorie = 0.28000000000000003
                        },
                        new
                        {
                            Id = 68,
                            ProductName = "Marul",
                            ProductTypeID = 4,
                            UnitCalorie = 0.22
                        },
                        new
                        {
                            Id = 69,
                            ProductName = "Roka",
                            ProductTypeID = 4,
                            UnitCalorie = 0.25
                        },
                        new
                        {
                            Id = 70,
                            ProductName = "Kara Lahana",
                            ProductTypeID = 4,
                            UnitCalorie = 0.32000000000000001
                        },
                        new
                        {
                            Id = 71,
                            ProductName = "Armut",
                            ProductTypeID = 5,
                            UnitCalorie = 0.56999999999999995
                        },
                        new
                        {
                            Id = 72,
                            ProductName = "Ayva",
                            ProductTypeID = 5,
                            UnitCalorie = 0.56999999999999995
                        },
                        new
                        {
                            Id = 73,
                            ProductName = "Elma",
                            ProductTypeID = 5,
                            UnitCalorie = 0.52000000000000002
                        },
                        new
                        {
                            Id = 74,
                            ProductName = "Erik",
                            ProductTypeID = 5,
                            UnitCalorie = 0.46000000000000002
                        },
                        new
                        {
                            Id = 75,
                            ProductName = "Hurma",
                            ProductTypeID = 5,
                            UnitCalorie = 2.8199999999999998
                        },
                        new
                        {
                            Id = 76,
                            ProductName = "İncir",
                            ProductTypeID = 5,
                            UnitCalorie = 0.73999999999999999
                        },
                        new
                        {
                            Id = 77,
                            ProductName = "Muz",
                            ProductTypeID = 5,
                            UnitCalorie = 0.89000000000000001
                        },
                        new
                        {
                            Id = 78,
                            ProductName = "Karpuz",
                            ProductTypeID = 5,
                            UnitCalorie = 0.29999999999999999
                        },
                        new
                        {
                            Id = 79,
                            ProductName = "Kayısı",
                            ProductTypeID = 5,
                            UnitCalorie = 0.47999999999999998
                        },
                        new
                        {
                            Id = 80,
                            ProductName = "Kiraz",
                            ProductTypeID = 5,
                            UnitCalorie = 0.5
                        },
                        new
                        {
                            Id = 81,
                            ProductName = "Kivi",
                            ProductTypeID = 5,
                            UnitCalorie = 0.60999999999999999
                        },
                        new
                        {
                            Id = 82,
                            ProductName = "Nar",
                            ProductTypeID = 5,
                            UnitCalorie = 0.82999999999999996
                        },
                        new
                        {
                            Id = 83,
                            ProductName = "Portakal",
                            ProductTypeID = 5,
                            UnitCalorie = 0.46999999999999997
                        },
                        new
                        {
                            Id = 84,
                            ProductName = "Çilek",
                            ProductTypeID = 5,
                            UnitCalorie = 0.32000000000000001
                        },
                        new
                        {
                            Id = 85,
                            ProductName = "Üzüm",
                            ProductTypeID = 5,
                            UnitCalorie = 0.68999999999999995
                        },
                        new
                        {
                            Id = 86,
                            ProductName = "Şeftali",
                            ProductTypeID = 5,
                            UnitCalorie = 0.39000000000000001
                        });
                });

            modelBuilder.Entity("Entities.Concrete.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductTypeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductTypeName = "Meat"
                        },
                        new
                        {
                            Id = 2,
                            ProductTypeName = "Fish"
                        },
                        new
                        {
                            Id = 3,
                            ProductTypeName = "Staple Food"
                        },
                        new
                        {
                            Id = 4,
                            ProductTypeName = "Vegetable"
                        },
                        new
                        {
                            Id = 5,
                            ProductTypeName = "Fruit"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varbinary(500)");

                    b.Property<DateTime?>("RegisterTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 16, 16, 45, 23, 792, DateTimeKind.Local).AddTicks(7788));

                    b.Property<int>("UserClaim")
                        .HasColumnType("int");

                    b.HasKey("UserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entities.Concrete.Meal", b =>
                {
                    b.HasOne("Entities.Concrete.MealType", "MealType")
                        .WithMany("Meals")
                        .HasForeignKey("MealTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MealType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.MealDetail", b =>
                {
                    b.HasOne("Entities.Concrete.Meal", "Meal")
                        .WithMany("MealDetails")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Product", "Product")
                        .WithMany("MealDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Meal");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Entities.Concrete.Meal", b =>
                {
                    b.Navigation("MealDetails");
                });

            modelBuilder.Entity("Entities.Concrete.MealType", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Navigation("MealDetails");
                });

            modelBuilder.Entity("Entities.Concrete.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
