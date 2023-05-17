﻿// <auto-generated />
using System;
using MHT.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MHT.DataAccess.Migrations
{
    [DbContext(typeof(MhtContext))]
    [Migration("20230517120156_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MHT.Entity.Entities.Islem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("IslemAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Islemler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            IslemAdi = "İş Başlangıç"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            IslemAdi = "İş Bitiş"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            IslemAdi = "Mola Başlangıç"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            IslemAdi = "Mola Bitiş"
                        });
                });

            modelBuilder.Entity("MHT.Entity.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YoneticiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Isim = "default",
                            KullaniciAdi = "admin",
                            Sifre = "admin",
                            Soyisim = "admin",
                            YoneticiMi = true
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Isim = "default",
                            KullaniciAdi = "user",
                            Sifre = "user",
                            Soyisim = "user",
                            YoneticiMi = false
                        });
                });

            modelBuilder.Entity("MHT.Entity.Entities.Kullanim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Baslangic")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Bitis")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("MakineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kullanimlar");
                });

            modelBuilder.Entity("MHT.Entity.Entities.Makine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MakineAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makineler");
                });

            modelBuilder.Entity("MHT.Entity.Entities.Vardiya", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<int>("IslemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IslemSaati")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vardiyalar");
                });
#pragma warning restore 612, 618
        }
    }
}
