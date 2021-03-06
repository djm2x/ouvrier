﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp.Models;

namespace asp3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181130094443_firstMG")]
    partial class firstMG
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("asp.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IdCatalogue");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("IdCatalogue");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("asp.Models.Catalogue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdUser");

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Catalogues");
                });

            modelBuilder.Entity("asp.Models.Commentaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Date");

                    b.Property<int>("IdOuvrier");

                    b.Property<int>("IdUser");

                    b.HasKey("Id");

                    b.HasIndex("IdOuvrier");

                    b.HasIndex("IdUser");

                    b.ToTable("Commentaires");
                });

            modelBuilder.Entity("asp.Models.Favorie", b =>
                {
                    b.Property<int>("IdOuvrier");

                    b.Property<int>("IdUser");

                    b.HasKey("IdOuvrier", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("Favories");
                });

            modelBuilder.Entity("asp.Models.Likeuser", b =>
                {
                    b.Property<int>("IdOuvrier");

                    b.Property<int>("IdUser");

                    b.Property<int>("Note");

                    b.HasKey("IdOuvrier", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("Likeusers");
                });

            modelBuilder.Entity("asp.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresse");

                    b.Property<bool>("Draggble");

                    b.Property<int>("IdQuartier");

                    b.Property<double>("Lat");

                    b.Property<double>("Lng");

                    b.HasKey("Id");

                    b.HasIndex("IdQuartier");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = 1, Adresse = "hay maamoura", Draggble = false, IdQuartier = 1, Lat = 33.927251, Lng = -6.887098 }
                    );
                });

            modelBuilder.Entity("asp.Models.Metier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.ToTable("Metiers");

                    b.HasData(
                        new { Id = 1, Nom = "Developpeur" },
                        new { Id = 2, Nom = "Reseaux" }
                    );
                });

            modelBuilder.Entity("asp.Models.Quartier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdVille");

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.HasIndex("IdVille");

                    b.ToTable("Quartiers");

                    b.HasData(
                        new { Id = 1, IdVille = 1, Nom = "Agdal" },
                        new { Id = 2, IdVille = 2, Nom = "Massira 2" },
                        new { Id = 3, IdVille = 3, Nom = "New port" },
                        new { Id = 4, IdVille = 4, Nom = "Marina" }
                    );
                });

            modelBuilder.Entity("asp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Civilite");

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Email");

                    b.Property<int>("IdLocation");

                    b.Property<int?>("IdMetier");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<string>("Tel");

                    b.Property<string>("Type");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("IdLocation");

                    b.HasIndex("IdMetier");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Civilite = "m", DateNaissance = new DateTime(1989, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "dj-m2x@hotmail.com", IdLocation = 1, IdMetier = 1, ImageUrl = "", LastName = "mourabit", Password = "12345678*", Role = 2008, Tel = "0671265478", Type = "ouvrier", Username = "mohamed" }
                    );
                });

            modelBuilder.Entity("asp.Models.Ville", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.ToTable("Villes");

                    b.HasData(
                        new { Id = 1, Nom = "Rabat" },
                        new { Id = 2, Nom = "Temara" },
                        new { Id = 3, Nom = "Tanger" },
                        new { Id = 4, Nom = "Agadir" }
                    );
                });

            modelBuilder.Entity("asp.Models.Article", b =>
                {
                    b.HasOne("asp.Models.Catalogue", "catalogues")
                        .WithMany("articles")
                        .HasForeignKey("IdCatalogue")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Catalogue", b =>
                {
                    b.HasOne("asp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Commentaire", b =>
                {
                    b.HasOne("asp.Models.User", "ouvrier")
                        .WithMany()
                        .HasForeignKey("IdOuvrier")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("asp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Favorie", b =>
                {
                    b.HasOne("asp.Models.User", "ouvrier")
                        .WithMany()
                        .HasForeignKey("IdOuvrier")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("asp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Likeuser", b =>
                {
                    b.HasOne("asp.Models.User", "ouvrier")
                        .WithMany()
                        .HasForeignKey("IdOuvrier")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("asp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Location", b =>
                {
                    b.HasOne("asp.Models.Quartier", "quartier")
                        .WithMany()
                        .HasForeignKey("IdQuartier")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.Quartier", b =>
                {
                    b.HasOne("asp.Models.Ville", "ville")
                        .WithMany()
                        .HasForeignKey("IdVille")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("asp.Models.User", b =>
                {
                    b.HasOne("asp.Models.Location", "location")
                        .WithMany("users")
                        .HasForeignKey("IdLocation")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("asp.Models.Metier", "metier")
                        .WithMany()
                        .HasForeignKey("IdMetier");
                });
#pragma warning restore 612, 618
        }
    }
}
