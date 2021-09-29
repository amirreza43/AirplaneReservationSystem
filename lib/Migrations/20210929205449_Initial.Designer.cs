﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lib;

namespace lib.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20210929205449_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("lib.Flight", b =>
                {
                    b.Property<int>("FlightNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AircraftType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalLoc")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureLoc")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightCap")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Revenue")
                        .HasColumnType("TEXT");

                    b.HasKey("FlightNumber");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("lib.Passenger", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isKid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("lib.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Column")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassengerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Row")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SectionId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("price")
                        .HasColumnType("TEXT");

                    b.HasKey("SeatId");

                    b.HasIndex("PassengerName");

                    b.HasIndex("SectionId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("lib.Section", b =>
                {
                    b.Property<string>("SectionId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FlightNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rows")
                        .HasColumnType("INTEGER");

                    b.HasKey("SectionId");

                    b.HasIndex("FlightNumber");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("lib.Seat", b =>
                {
                    b.HasOne("lib.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerName");

                    b.HasOne("lib.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");

                    b.Navigation("Passenger");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("lib.Section", b =>
                {
                    b.HasOne("lib.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightNumber");

                    b.Navigation("Flight");
                });
#pragma warning restore 612, 618
        }
    }
}