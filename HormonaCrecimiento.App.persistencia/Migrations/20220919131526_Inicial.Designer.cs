﻿// <auto-generated />
using System;
using HormonaCrecimiento.App.persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HormonaCrecimiento.App.persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220919131526_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.PatronesCrecimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("Patrones")
                        .HasColumnType("int");

                    b.Property<float?>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("PatronesCrecimiento");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.SugerenciaTratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("Sugerencias");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.FamiliarAsignado", b =>
                {
                    b.HasBaseType("HormonaCrecimiento.App.dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("FamiliarAsignado");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.Medico", b =>
                {
                    b.HasBaseType("HormonaCrecimiento.App.dominio.Persona");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Especialidad")
                        .HasColumnType("int");

                    b.Property<string>("RegistroRethus")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.Paciente", b =>
                {
                    b.HasBaseType("HormonaCrecimiento.App.dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FamiliarAsignadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.Property<float?>("Latitud")
                        .HasColumnType("real");

                    b.Property<float?>("Longitud")
                        .HasColumnType("real");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.HasIndex("FamiliarAsignadoId");

                    b.HasIndex("HistoriaId");

                    b.HasIndex("MedicoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.PatronesCrecimiento", b =>
                {
                    b.HasOne("HormonaCrecimiento.App.dominio.Paciente", null)
                        .WithMany("PatronesCrecimiento")
                        .HasForeignKey("PacienteId");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.SugerenciaTratamiento", b =>
                {
                    b.HasOne("HormonaCrecimiento.App.dominio.HistoriaClinica", null)
                        .WithMany("Sugerencias")
                        .HasForeignKey("HistoriaClinicaId");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.Paciente", b =>
                {
                    b.HasOne("HormonaCrecimiento.App.dominio.FamiliarAsignado", "FamiliarAsignado")
                        .WithMany()
                        .HasForeignKey("FamiliarAsignadoId");

                    b.HasOne("HormonaCrecimiento.App.dominio.HistoriaClinica", "Historia")
                        .WithMany()
                        .HasForeignKey("HistoriaId");

                    b.HasOne("HormonaCrecimiento.App.dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.Navigation("FamiliarAsignado");

                    b.Navigation("Historia");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.HistoriaClinica", b =>
                {
                    b.Navigation("Sugerencias");
                });

            modelBuilder.Entity("HormonaCrecimiento.App.dominio.Paciente", b =>
                {
                    b.Navigation("PatronesCrecimiento");
                });
#pragma warning restore 612, 618
        }
    }
}
