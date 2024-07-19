﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repos;

#nullable disable

namespace Repos.Migrations
{
    [DbContext(typeof(DogRepos))]
    partial class TravisReposModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Repos.Models.AnimalSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalVaccinationId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EveryDay")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Friday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Monday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Monthly")
                        .HasColumnType("INTEGER");

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

                    b.Property<bool>("Tuesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Wednesday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Yearly")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AnimalSchedule");
                });

            modelBuilder.Entity("Repos.Models.AnimalVaccinations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DogId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("AnimalVaccinations");
                });

            modelBuilder.Entity("Repos.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("Repos.Models.AnimalVaccinations", b =>
                {
                    b.HasOne("Repos.Models.Dog", null)
                        .WithMany("Vaccinations")
                        .HasForeignKey("DogId");

                    b.HasOne("Repos.Models.AnimalSchedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Repos.Models.Dog", b =>
                {
                    b.Navigation("Vaccinations");
                });
#pragma warning restore 612, 618
        }
    }
}
