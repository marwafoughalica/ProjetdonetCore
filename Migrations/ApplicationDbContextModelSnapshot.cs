﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mini_ProjetDonetCore.Models;

#nullable disable

namespace Mini_ProjetDonetCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientLocation", b =>
                {
                    b.Property<int>("IdCl")
                        .HasColumnType("int");

                    b.Property<int>("clientIdCl")
                        .HasColumnType("int");

                    b.HasKey("IdCl", "clientIdCl");

                    b.HasIndex("clientIdCl");

                    b.ToTable("ClientLocation");
                });

            modelBuilder.Entity("LocationVoiture", b =>
                {
                    b.Property<int>("IdVoi")
                        .HasColumnType("int");

                    b.Property<int>("VoitureIdVoi")
                        .HasColumnType("int");

                    b.HasKey("IdVoi", "VoitureIdVoi");

                    b.HasIndex("VoitureIdVoi");

                    b.ToTable("LocationVoiture");
                });

            modelBuilder.Entity("Mini_ProjetDonetCore.Models.Client", b =>
                {
                    b.Property<int>("IdCl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCl"));

                    b.Property<string>("adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCl");

                    b.ToTable("client");
                });

            modelBuilder.Entity("Mini_ProjetDonetCore.Models.Location", b =>
                {
                    b.Property<int>("IdLoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLoc"));

                    b.Property<int>("IdCl")
                        .HasColumnType("int");

                    b.Property<int>("IdVoi")
                        .HasColumnType("int");

                    b.Property<string>("dateLoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateRetour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoc");

                    b.ToTable("location");
                });

            modelBuilder.Entity("Mini_ProjetDonetCore.Models.Voiture", b =>
                {
                    b.Property<int>("IdVoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVoi"));

                    b.Property<string>("couleur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_sortie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matricule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVoi");

                    b.ToTable("voiture");
                });

            modelBuilder.Entity("ClientLocation", b =>
                {
                    b.HasOne("Mini_ProjetDonetCore.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("IdCl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mini_ProjetDonetCore.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("clientIdCl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocationVoiture", b =>
                {
                    b.HasOne("Mini_ProjetDonetCore.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("IdVoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mini_ProjetDonetCore.Models.Voiture", null)
                        .WithMany()
                        .HasForeignKey("VoitureIdVoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}