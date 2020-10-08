﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamSho5SpcWebApi.Data;

namespace SamSho5SpcWebApi.Migrations
{
    [DbContext(typeof(SamShoDbContext))]
    partial class SamShoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("SamSho5SpcWebApi.Data.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GameplayDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lore")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("SamSho5SpcWebApi.Data.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ActiveFrames")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CancelWindowEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CancelWindowStart")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CausesKnockdown")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GuardStance")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LateCancelWindowEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LateCancelWindowStart")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LateWeaponClashEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LateWeaponClashStart")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OnBackhit")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OnBlock")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OnHit")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StartupFrames")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TotalFrames")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WeaponClashEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WeaponClashStart")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("SamSho5SpcWebApi.Data.Models.Move", b =>
                {
                    b.HasOne("SamSho5SpcWebApi.Data.Models.Character", null)
                        .WithMany("Moves")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
