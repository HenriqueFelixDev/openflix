﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenFlixAPI.Domain.Repositories;

#nullable disable

namespace OpenFlixAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220724145949_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FavoriteSerie", b =>
                {
                    b.Property<int>("FavoritesId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.HasKey("FavoritesId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("Favorite_Serie", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Profiles.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("ProfileImageId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileImageId");

                    b.HasIndex("UserId");

                    b.ToTable("profiles", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Profiles.ProfileImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("profile_images", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2022, 7, 24, 14, 59, 48, 942, DateTimeKind.Utc).AddTicks(3114));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("favorites", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Banner")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("series", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Banner")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("videos", (string)null);
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.VideoCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.ToTable("video_categories", (string)null);
                });

            modelBuilder.Entity("FavoriteSerie", b =>
                {
                    b.HasOne("OpenFlixAPI.Domain.Models.Videos.Favorite", null)
                        .WithMany()
                        .HasForeignKey("FavoritesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenFlixAPI.Domain.Models.Videos.Serie", null)
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Profiles.Profile", b =>
                {
                    b.HasOne("OpenFlixAPI.Domain.Models.Profiles.ProfileImage", "ProfileImage")
                        .WithMany("Profiles")
                        .HasForeignKey("ProfileImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenFlixAPI.Domain.Models.Users.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfileImage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Favorite", b =>
                {
                    b.HasOne("OpenFlixAPI.Domain.Models.Profiles.Profile", "Profile")
                        .WithOne("Favorite")
                        .HasForeignKey("OpenFlixAPI.Domain.Models.Videos.Favorite", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenFlixAPI.Domain.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Serie", b =>
                {
                    b.HasOne("OpenFlixAPI.Domain.Models.Videos.VideoCategory", "Category")
                        .WithMany("Series")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Video", b =>
                {
                    b.HasOne("OpenFlixAPI.Domain.Models.Videos.Serie", "Serie")
                        .WithMany("Videos")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Profiles.Profile", b =>
                {
                    b.Navigation("Favorite")
                        .IsRequired();
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Profiles.ProfileImage", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Users.User", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.Serie", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("OpenFlixAPI.Domain.Models.Videos.VideoCategory", b =>
                {
                    b.Navigation("Series");
                });
#pragma warning restore 612, 618
        }
    }
}
