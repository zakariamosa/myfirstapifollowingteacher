﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myFirstRESTApi.Entities;

#nullable disable

namespace myFirstRESTApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211215003613_dummy_data_for_artist_and_vinyls")]
    partial class dummy_data_for_artist_and_vinyls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("myFirstRESTApi.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FavoriteCar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7182),
                            FavoriteCar = "BMW",
                            Name = "Amr Diab"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7276),
                            FavoriteCar = "Mercedes",
                            Name = "mohammed fouad"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7281),
                            FavoriteCar = "Tesla",
                            Name = "Mostafa amar"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7283),
                            FavoriteCar = "Rols",
                            Name = "Hamaky"
                        });
                });

            modelBuilder.Entity("myFirstRESTApi.Entities.Vinyl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistID");

                    b.ToTable("Vinyls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistID = 1,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7381),
                            Title = "tammaly maaaak"
                        },
                        new
                        {
                            Id = 2,
                            ArtistID = 1,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7384),
                            Title = "esmaaaa"
                        },
                        new
                        {
                            Id = 3,
                            ArtistID = 2,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7386),
                            Title = "ahkilak"
                        },
                        new
                        {
                            Id = 4,
                            ArtistID = 3,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7388),
                            Title = "vinyl3"
                        },
                        new
                        {
                            Id = 5,
                            ArtistID = 3,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7390),
                            Title = "ya habibi"
                        },
                        new
                        {
                            Id = 6,
                            ArtistID = 4,
                            Created = new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7392),
                            Title = "ellylady"
                        });
                });

            modelBuilder.Entity("myFirstRESTApi.Entities.Vinyl", b =>
                {
                    b.HasOne("myFirstRESTApi.Entities.Artist", "Artist")
                        .WithMany("Vinyls")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("myFirstRESTApi.Entities.Artist", b =>
                {
                    b.Navigation("Vinyls");
                });
#pragma warning restore 612, 618
        }
    }
}
