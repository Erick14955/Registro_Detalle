﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_Detalle.DAL;

namespace Registro_Detalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210301163317_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Registro_Detalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionPermisos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermisosId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisosId = 1,
                            DescripcionPermisos = "Con este permiso es posible modificar el precio",
                            Nombre = "Descuento",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisosId = 2,
                            DescripcionPermisos = "Con este permiso es posible vender",
                            Nombre = "Vende",
                            VecesAsignado = 0
                        },
                        new
                        {
                            PermisosId = 3,
                            DescripcionPermisos = "Con este permiso es posible comprar",
                            Nombre = "Compra",
                            VecesAsignado = 0
                        });
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("RolID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsAsignado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolID");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionRol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Permisos", b =>
                {
                    b.HasOne("Registro_Detalle.Entidades.Permisos", "permiso")
                        .WithMany()
                        .HasForeignKey("PermisosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permiso");
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("Registro_Detalle.Entidades.Roles", null)
                        .WithMany("Detalle")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Registro_Detalle.Entidades.Roles", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
