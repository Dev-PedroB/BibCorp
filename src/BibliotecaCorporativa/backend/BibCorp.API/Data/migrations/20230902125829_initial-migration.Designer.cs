﻿// <auto-generated />
using BibCorp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibCorp.API.data.migrations
{
    [DbContext(typeof(BibCorpContext))]
    [Migration("20230902125829_initial-migration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("BibCorp.API.Models.Acervo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcertoAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcervoUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("AnoPublicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Autores")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataSuspensão")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeLivro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Patrimonio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Resumo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Acervos");
                });
#pragma warning restore 612, 618
        }
    }
}
