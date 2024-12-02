﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Niu.Nutri.Livraria.Infra.Data.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Niu.Nutri.Livraria.Infra.Data.Migrations
{
    [DbContext(typeof(LivrariaAggContext))]
    partial class LivrariaAggContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Assunto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("CodAs");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deletado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("IdExterno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Assunto");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("CodAu");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deletado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IdExterno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.LivrariaAggSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deletado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IdExterno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LivrariaAggSettings");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Codl");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AnoPublicacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deletado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("Edicao")
                        .HasColumnType("integer");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("IdExterno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro_Assunto", b =>
                {
                    b.Property<int>("Assunto_CodAut")
                        .HasColumnType("integer");

                    b.Property<int>("Livro_Codl")
                        .HasColumnType("integer");

                    b.HasKey("Assunto_CodAut", "Livro_Codl");

                    b.HasIndex("Livro_Codl");

                    b.ToTable("Livro_Assunto");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro_Autor", b =>
                {
                    b.Property<int>("Autor_CodAut")
                        .HasColumnType("integer");

                    b.Property<int>("Livro_Codl")
                        .HasColumnType("integer");

                    b.HasKey("Autor_CodAut", "Livro_Codl");

                    b.HasIndex("Livro_Codl");

                    b.ToTable("Livro_Autor");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Deletado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IdExterno")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro_Assunto", b =>
                {
                    b.HasOne("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Assunto", "Assunto")
                        .WithMany()
                        .HasForeignKey("Assunto_CodAut")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("Livro_Codl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assunto");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro_Autor", b =>
                {
                    b.HasOne("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("Autor_CodAut")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("Livro_Codl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });
#pragma warning restore 612, 618
        }
    }
}
