﻿// <auto-generated />
using System;
using ListaStudenti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ListaStudenti.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20221121173545_AdaugareGen")]
    partial class AdaugareGen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ListaStudenti.Models.Gen", b =>
                {
                    b.Property<string>("GenID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenID");

                    b.ToTable("Gen");

                    b.HasData(
                        new
                        {
                            GenID = "M",
                            Nume = "Masculin"
                        },
                        new
                        {
                            GenID = "F",
                            Nume = "Feminin"
                        });
                });

            modelBuilder.Entity("ListaStudenti.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnStudiu")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("GenID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Nota")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("GenID");

                    b.ToTable("Studenti");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            AnStudiu = 3,
                            GenID = "F",
                            Nota = 10,
                            Nume = "Sirbu Doina"
                        },
                        new
                        {
                            StudentID = 2,
                            AnStudiu = 2,
                            GenID = "M",
                            Nota = 8,
                            Nume = "Moraru Eusebiu"
                        },
                        new
                        {
                            StudentID = 3,
                            AnStudiu = 1,
                            GenID = "M",
                            Nota = 9,
                            Nume = "Popescu Ion"
                        });
                });

            modelBuilder.Entity("ListaStudenti.Models.Student", b =>
                {
                    b.HasOne("ListaStudenti.Models.Gen", "Gen")
                        .WithMany()
                        .HasForeignKey("GenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
