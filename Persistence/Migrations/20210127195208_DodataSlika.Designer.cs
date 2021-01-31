﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210127195208_DodataSlika")]
    partial class DodataSlika
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Domain.Automobil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("cena")
                        .HasColumnType("TEXT");

                    b.Property<string>("model")
                        .HasColumnType("TEXT");

                    b.Property<string>("slika")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Automobili");
                });

            modelBuilder.Entity("Domain.Karoserija", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Karoserije");
                });

            modelBuilder.Entity("Domain.Kubikaza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kubikaze");
                });

            modelBuilder.Entity("Domain.Kwks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KonjskeSnage");
                });

            modelBuilder.Entity("Domain.Oprema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Opreme");
                });

            modelBuilder.Entity("Domain.Pogon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vrsta")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pogoni");
                });

            modelBuilder.Entity("Domain.SveOAutomobilu", b =>
                {
                    b.Property<Guid>("KaroserijaId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("KubikazaId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("KwksId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PogonId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OpremaId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AutomobilId")
                        .HasColumnType("TEXT");

                    b.HasKey("KaroserijaId", "KubikazaId", "KwksId", "PogonId", "OpremaId");

                    b.HasIndex("AutomobilId");

                    b.HasIndex("KubikazaId");

                    b.HasIndex("KwksId");

                    b.HasIndex("OpremaId");

                    b.HasIndex("PogonId");

                    b.ToTable("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.SveOAutomobilu", b =>
                {
                    b.HasOne("Domain.Automobil", "Automobil")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("AutomobilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Karoserija", "Karoserija")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("KaroserijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Kubikaza", "Kubikaza")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("KubikazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Kwks", "Kwks")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("KwksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Oprema", "Oprema")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("OpremaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Pogon", "Pogon")
                        .WithMany("SveOAutomobilima")
                        .HasForeignKey("PogonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Automobil");

                    b.Navigation("Karoserija");

                    b.Navigation("Kubikaza");

                    b.Navigation("Kwks");

                    b.Navigation("Oprema");

                    b.Navigation("Pogon");
                });

            modelBuilder.Entity("Domain.Automobil", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.Karoserija", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.Kubikaza", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.Kwks", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.Oprema", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });

            modelBuilder.Entity("Domain.Pogon", b =>
                {
                    b.Navigation("SveOAutomobilima");
                });
#pragma warning restore 612, 618
        }
    }
}
