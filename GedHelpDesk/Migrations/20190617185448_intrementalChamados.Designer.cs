﻿// <auto-generated />
using System;
using GedHelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GedHelpDesk.Migrations
{
    [DbContext(typeof(GedHelpDeskContext))]
    [Migration("20190617185448_intrementalChamados")]
    partial class intrementalChamados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GedHelpDesk.Models.Chamados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Hora");

                    b.Property<string>("Ramal");

                    b.Property<string>("Setor");

                    b.Property<int>("Status");

                    b.Property<string>("Titulo");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Chamados");
                });

            modelBuilder.Entity("GedHelpDesk.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("GedHelpDesk.Models.Chamados", b =>
                {
                    b.HasOne("GedHelpDesk.Models.Usuario", "Usuario")
                        .WithMany("ChamadosUser")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
