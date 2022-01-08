﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_final.Data;

namespace Proiect_final.Migrations
{
    [DbContext(typeof(Proiect_finalContext))]
    [Migration("20220108125933_SongGenre")]
    partial class SongGenre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect_final.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Proiect_final.Models.RecordLabel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RecordLabelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RecordLabel");
                });

            modelBuilder.Entity("Proiect_final.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Album")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AlbumPrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int>("RecordLabelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Single")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RecordLabelID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("Proiect_final.Models.SongGenre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("SongID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.HasIndex("SongID");

                    b.ToTable("SongGenre");
                });

            modelBuilder.Entity("Proiect_final.Models.Song", b =>
                {
                    b.HasOne("Proiect_final.Models.RecordLabel", "RecordLabel")
                        .WithMany("Songs")
                        .HasForeignKey("RecordLabelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecordLabel");
                });

            modelBuilder.Entity("Proiect_final.Models.SongGenre", b =>
                {
                    b.HasOne("Proiect_final.Models.Genre", "Genre")
                        .WithMany("SongGenres")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_final.Models.Song", "Song")
                        .WithMany("SongGenres")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Proiect_final.Models.Genre", b =>
                {
                    b.Navigation("SongGenres");
                });

            modelBuilder.Entity("Proiect_final.Models.RecordLabel", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Proiect_final.Models.Song", b =>
                {
                    b.Navigation("SongGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
