﻿// <auto-generated />
using System;
using FlyTime.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlyTime.Data.Migrations
{
    [DbContext(typeof(FlyTimeDbContext))]
    [Migration("20240625210523_Second Migration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FlyTime.Core.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time(6)");

                    b.Property<int?>("FromDestinationId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time(6)");

                    b.Property<int?>("ToDestinationId")
                        .HasColumnType("int");

                    b.Property<int>("VolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromDestinationId");

                    b.HasIndex("ToDestinationId");

                    b.HasIndex("VolId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Aeroport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Aeroports");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Vol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PilotId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Activity", b =>
                {
                    b.HasOne("FlyTime.Core.Models.Aeroport", "FromDestination")
                        .WithMany()
                        .HasForeignKey("FromDestinationId");

                    b.HasOne("FlyTime.Core.Models.Aeroport", "ToDestination")
                        .WithMany()
                        .HasForeignKey("ToDestinationId");

                    b.HasOne("FlyTime.Core.Models.Vol", "Vol")
                        .WithMany("Activities")
                        .HasForeignKey("VolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromDestination");

                    b.Navigation("ToDestination");

                    b.Navigation("Vol");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Vol", b =>
                {
                    b.HasOne("FlyTime.Core.Models.Pilot", "Pilot")
                        .WithMany("Vols")
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pilot");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Pilot", b =>
                {
                    b.Navigation("Vols");
                });

            modelBuilder.Entity("FlyTime.Core.Models.Vol", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
