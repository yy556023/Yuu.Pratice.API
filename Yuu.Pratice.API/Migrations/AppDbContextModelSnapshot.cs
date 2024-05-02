﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yuu.Pratice.API.Database;

#nullable disable

namespace Yuu.Pratice.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Yuu.Pratice.API.Models.TouristRoutes.TouristRoute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("DepartureCity")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<double?>("DiscountPersent")
                        .HasColumnType("float");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fees")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte?>("TravelDays")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("TripType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TouristRoute");
                });

            modelBuilder.Entity("Yuu.Pratice.API.Models.TouristRoutes.TouristRoutePicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("TouristRouteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("TouristRouteId");

                    b.ToTable("TouristRoutePicture");
                });

            modelBuilder.Entity("Yuu.Pratice.API.Models.TouristRoutes.TouristRoutePicture", b =>
                {
                    b.HasOne("Yuu.Pratice.API.Models.TouristRoutes.TouristRoute", "TouristRoute")
                        .WithMany("TouristRoutePictures")
                        .HasForeignKey("TouristRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TouristRoute");
                });

            modelBuilder.Entity("Yuu.Pratice.API.Models.TouristRoutes.TouristRoute", b =>
                {
                    b.Navigation("TouristRoutePictures");
                });
#pragma warning restore 612, 618
        }
    }
}
