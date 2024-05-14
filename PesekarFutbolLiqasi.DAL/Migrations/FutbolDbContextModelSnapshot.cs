﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PesekarFutbolLiqasi.DAL.Context;

#nullable disable

namespace PesekarFutbolLiqasi.DAL.Migrations
{
    [DbContext(typeof(FutbolDbContext))]
    partial class FutbolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Futbolcu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AtdigiQolSayi")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaNomresi")
                        .HasColumnType("int");

                    b.Property<int>("KomandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KomandaId");

                    b.ToTable("Futbolcular", (string)null);
                });

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Komanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtdigiQolSayi")
                        .HasColumnType("int");

                    b.Property<int>("BeraberlikSayi")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KomandaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeglubiyyetSayi")
                        .HasColumnType("int");

                    b.Property<int>("QaliblikSayi")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("YediyiQolSayi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Komandalar", (string)null);
                });

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Oyun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EvSahibiId")
                        .HasColumnType("int");

                    b.Property<int>("EvSahibiQolSayı")
                        .HasColumnType("int");

                    b.Property<int>("HefteNomresi")
                        .HasColumnType("int");

                    b.Property<int>("QonaqId")
                        .HasColumnType("int");

                    b.Property<int>("QonaqQolSayı")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EvSahibiId");

                    b.HasIndex("QonaqId");

                    b.ToTable("Oyunlar", (string)null);
                });

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Futbolcu", b =>
                {
                    b.HasOne("PeşəkarFutbolLiqası.DAL.Models.Komanda", "Komanda")
                        .WithMany("Futbolcular")
                        .HasForeignKey("KomandaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Komanda");
                });

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Oyun", b =>
                {
                    b.HasOne("PeşəkarFutbolLiqası.DAL.Models.Komanda", "EvSahibi")
                        .WithMany()
                        .HasForeignKey("EvSahibiId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeşəkarFutbolLiqası.DAL.Models.Komanda", "Qonaq")
                        .WithMany()
                        .HasForeignKey("QonaqId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EvSahibi");

                    b.Navigation("Qonaq");
                });

            modelBuilder.Entity("PeşəkarFutbolLiqası.DAL.Models.Komanda", b =>
                {
                    b.Navigation("Futbolcular");
                });
#pragma warning restore 612, 618
        }
    }
}
