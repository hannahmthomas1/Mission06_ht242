﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_ht242.Models;

namespace Mission06_ht242.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    [Migration("20230221162556_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29");

            modelBuilder.Entity("Mission06_ht242.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Sport"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Sci-fi"
                        });
                });

            modelBuilder.Entity("Mission06_ht242.Models.movieEntry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntryID");

                    b.HasIndex("CategoryId");

                    b.ToTable("entries");

                    b.HasData(
                        new
                        {
                            EntryID = 1,
                            CategoryId = 1,
                            Director = "Marc Forster",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "A Man Called Otto",
                            Year = 2023
                        },
                        new
                        {
                            EntryID = 2,
                            CategoryId = 9,
                            Director = "Miguel Sapochnik",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Finch",
                            Year = 2021
                        },
                        new
                        {
                            EntryID = 3,
                            CategoryId = 1,
                            Director = "Sally El Hosaini",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Swimmers",
                            Year = 2022
                        },
                        new
                        {
                            EntryID = 4,
                            CategoryId = 3,
                            Director = "Sarah Spillane",
                            Edited = false,
                            Rating = "PG",
                            Title = "True Spirit",
                            Year = 2023
                        },
                        new
                        {
                            EntryID = 5,
                            CategoryId = 2,
                            Director = "Taika Waititi",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Hunt for the Wilderpeople",
                            Year = 2016
                        });
                });

            modelBuilder.Entity("Mission06_ht242.Models.movieEntry", b =>
                {
                    b.HasOne("Mission06_ht242.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
