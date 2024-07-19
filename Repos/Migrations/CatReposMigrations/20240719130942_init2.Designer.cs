﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repos;

#nullable disable

namespace Repos.Migrations.CatReposMigrations
{
    [DbContext(typeof(CatRepos))]
    [Migration("20240719130942_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Repos.Models.AnimalSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EveryDay")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Friday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Monday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Monthly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Reoccurring")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Saturday")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDateForSchedule")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sunday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Thursday")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Tuesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Wednesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Yearly")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AnimalSchedule");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnimalSchedule");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Repos.Models.Cat", b =>
                {
                    b.HasBaseType("Repos.Models.AnimalSchedule");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UID")
                        .HasColumnType("TEXT");

                    b.HasIndex("ScheduleId");

                    b.HasDiscriminator().HasValue("Cat");
                });

            modelBuilder.Entity("Repos.Models.Cat", b =>
                {
                    b.HasOne("Repos.Models.AnimalSchedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
