﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(MacroclinicsDbContext))]
    [Migration("20230422144748_CriarBancoTabelas")]
    partial class CriarBancoTabelas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Models.Clinica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("clinica");
                });

            modelBuilder.Entity("Api.Models.ClinicaUsuario", b =>
                {
                    b.Property<Guid>("ClinicaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("ClinicaId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("clinica_usuario");
                });

            modelBuilder.Entity("Api.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("Api.Models.UsuarioPerfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("usuario_perfil");
                });

            modelBuilder.Entity("Api.Models.ClinicaUsuario", b =>
                {
                    b.HasOne("Api.Models.Clinica", "Clinica")
                        .WithMany("ClinicaUsuarios")
                        .HasForeignKey("ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.Usuario", "Usuario")
                        .WithMany("ClinicaUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Api.Models.UsuarioPerfil", b =>
                {
                    b.HasOne("Api.Models.Usuario", null)
                        .WithMany("UsuarioPerfis")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Api.Models.Clinica", b =>
                {
                    b.Navigation("ClinicaUsuarios");
                });

            modelBuilder.Entity("Api.Models.Usuario", b =>
                {
                    b.Navigation("ClinicaUsuarios");

                    b.Navigation("UsuarioPerfis");
                });
#pragma warning restore 612, 618
        }
    }
}
