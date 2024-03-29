﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkShark.Data;

#nullable disable

namespace ParkShark.Migrations
{
    [DbContext(typeof(MysqlContext))]
    [Migration("20230408163938_Parking")]
    partial class Parking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkShark.Models.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TimeEntry")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TransportationTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransportationTypeId");

                    b.ToTable("Parking");
                });

            modelBuilder.Entity("ParkShark.Models.TransportationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TransportationTypes");
                });

            modelBuilder.Entity("ParkShark.Models.Parking", b =>
                {
                    b.HasOne("ParkShark.Models.TransportationType", "TransportationType")
                        .WithMany()
                        .HasForeignKey("TransportationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransportationType");
                });
#pragma warning restore 612, 618
        }
    }
}
