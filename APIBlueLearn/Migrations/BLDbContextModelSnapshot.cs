﻿// <auto-generated />
using System;
using APIBlueLearn.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIBlueLearn.Migrations
{
    [DbContext(typeof(BLDbContext))]
    partial class BLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIBlueLearn.Model.Agricultores", b =>
                {
                    b.Property<int>("IdAgricultor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAgricultor"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorIdJugador")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAgricultor");

                    b.HasIndex("JugadorIdJugador");

                    b.ToTable("Agricultores");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Campos", b =>
                {
                    b.Property<int>("IdCampo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCampo"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreCampo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tamano")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCampo");

                    b.ToTable("Campos");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Cosechas", b =>
                {
                    b.Property<int>("IdCosechas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCosechas"));

                    b.Property<int>("CantidadRecogida")
                        .HasColumnType("int");

                    b.Property<int?>("CultivosIdCultivo")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCosecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCultivo")
                        .HasColumnType("int");

                    b.Property<int>("IdTemporada")
                        .HasColumnType("int");

                    b.Property<int?>("TemporadasIdTemporada")
                        .HasColumnType("int");

                    b.HasKey("IdCosechas");

                    b.HasIndex("CultivosIdCultivo");

                    b.HasIndex("TemporadasIdTemporada");

                    b.ToTable("Cosechas");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Cultivos", b =>
                {
                    b.Property<int>("IdCultivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCultivo"));

                    b.Property<int?>("CamposIdCampo")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int?>("EstadoCultivoIdEstadoCultivo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPlantacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCampo")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoCultivo")
                        .HasColumnType("int");

                    b.HasKey("IdCultivo");

                    b.HasIndex("CamposIdCampo");

                    b.HasIndex("EstadoCultivoIdEstadoCultivo");

                    b.ToTable("Cultivos");
                });

            modelBuilder.Entity("APIBlueLearn.Model.DescripcionMonitoreo", b =>
                {
                    b.Property<int>("IdDescripcionMonitoreo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDescripcionMonitoreo"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDescripcionMonitoreo");

                    b.ToTable("DescripcionMonitoreo");
                });

            modelBuilder.Entity("APIBlueLearn.Model.EstadoCultivo", b =>
                {
                    b.Property<int>("IdEstadoCultivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoCultivo"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.HasKey("IdEstadoCultivo");

                    b.ToTable("EstadoCultivo");
                });

            modelBuilder.Entity("APIBlueLearn.Model.EstadoOperacion", b =>
                {
                    b.Property<int>("IdEstadoOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoOperacion"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.HasKey("IdEstadoOperacion");

                    b.ToTable("EstadoOperacion");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Etapa", b =>
                {
                    b.Property<int>("IdEtapa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEtapa"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.HasKey("IdEtapa");

                    b.ToTable("Etapa");
                });

            modelBuilder.Entity("APIBlueLearn.Model.EtapaAprendizaje", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<int?>("AgricultoresIdAgricultor")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int?>("EtapaIdEtapa")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInit")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAgricultor")
                        .HasColumnType("int");

                    b.Property<int>("IdEtapa")
                        .HasColumnType("int");

                    b.HasKey("IdEstado");

                    b.HasIndex("AgricultoresIdAgricultor");

                    b.HasIndex("EtapaIdEtapa");

                    b.ToTable("EtapaAprendizaje");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Jugador", b =>
                {
                    b.Property<int>("IdJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJugador"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<int>("Puntaje")
                        .HasColumnType("int");

                    b.HasKey("IdJugador");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Logro", b =>
                {
                    b.Property<int>("IdLogro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLogro"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("IdLogro");

                    b.ToTable("Logro");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Monitoreo", b =>
                {
                    b.Property<int>("IdMonitoreo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMonitoreo"));

                    b.Property<int?>("CultivosIdCultivo")
                        .HasColumnType("int");

                    b.Property<int?>("DescripcionMonitoreoIdDescripcionMonitoreo")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaMonitoreo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCultivo")
                        .HasColumnType("int");

                    b.Property<int>("IdDescripcionMonitoreo")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdMonitoreo");

                    b.HasIndex("CultivosIdCultivo");

                    b.HasIndex("DescripcionMonitoreoIdDescripcionMonitoreo");

                    b.ToTable("Monitoreo");
                });

            modelBuilder.Entity("APIBlueLearn.Model.OperacionesCultivo", b =>
                {
                    b.Property<int>("IdOperacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOperacion"));

                    b.Property<int?>("AgricultoresIdAgricultor")
                        .HasColumnType("int");

                    b.Property<int?>("CultivosIdCultivo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int?>("EstadoOperacionIdEstadoOperacion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaOperacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAgricultor")
                        .HasColumnType("int");

                    b.Property<int>("IdCultivo")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoOperacion")
                        .HasColumnType("int");

                    b.HasKey("IdOperacion");

                    b.HasIndex("AgricultoresIdAgricultor");

                    b.HasIndex("CultivosIdCultivo");

                    b.HasIndex("EstadoOperacionIdEstadoOperacion");

                    b.ToTable("OpeCultivos");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Partida", b =>
                {
                    b.Property<int>("IdPartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPartida"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int>("IdLogro")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorIdJugador")
                        .HasColumnType("int");

                    b.Property<int?>("LogroIdLogro")
                        .HasColumnType("int");

                    b.Property<string>("NombrePartida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PuntajePartida")
                        .HasColumnType("int");

                    b.HasKey("IdPartida");

                    b.HasIndex("JugadorIdJugador");

                    b.HasIndex("LogroIdLogro");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Temporadas", b =>
                {
                    b.Property<int>("IdTemporada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTemporada"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Temporada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTemporada");

                    b.ToTable("Temporadas");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Agricultores", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorIdJugador");

                    b.Navigation("Jugador");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Cosechas", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Cultivos", "Cultivos")
                        .WithMany()
                        .HasForeignKey("CultivosIdCultivo");

                    b.HasOne("APIBlueLearn.Model.Temporadas", "Temporadas")
                        .WithMany()
                        .HasForeignKey("TemporadasIdTemporada");

                    b.Navigation("Cultivos");

                    b.Navigation("Temporadas");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Cultivos", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Campos", "Campos")
                        .WithMany()
                        .HasForeignKey("CamposIdCampo");

                    b.HasOne("APIBlueLearn.Model.EstadoCultivo", "EstadoCultivo")
                        .WithMany()
                        .HasForeignKey("EstadoCultivoIdEstadoCultivo");

                    b.Navigation("Campos");

                    b.Navigation("EstadoCultivo");
                });

            modelBuilder.Entity("APIBlueLearn.Model.EtapaAprendizaje", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Agricultores", "Agricultores")
                        .WithMany()
                        .HasForeignKey("AgricultoresIdAgricultor");

                    b.HasOne("APIBlueLearn.Model.Etapa", "Etapa")
                        .WithMany()
                        .HasForeignKey("EtapaIdEtapa");

                    b.Navigation("Agricultores");

                    b.Navigation("Etapa");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Monitoreo", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Cultivos", "Cultivos")
                        .WithMany()
                        .HasForeignKey("CultivosIdCultivo");

                    b.HasOne("APIBlueLearn.Model.DescripcionMonitoreo", "DescripcionMonitoreo")
                        .WithMany()
                        .HasForeignKey("DescripcionMonitoreoIdDescripcionMonitoreo");

                    b.Navigation("Cultivos");

                    b.Navigation("DescripcionMonitoreo");
                });

            modelBuilder.Entity("APIBlueLearn.Model.OperacionesCultivo", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Agricultores", "Agricultores")
                        .WithMany()
                        .HasForeignKey("AgricultoresIdAgricultor");

                    b.HasOne("APIBlueLearn.Model.Cultivos", "Cultivos")
                        .WithMany()
                        .HasForeignKey("CultivosIdCultivo");

                    b.HasOne("APIBlueLearn.Model.EstadoOperacion", "EstadoOperacion")
                        .WithMany()
                        .HasForeignKey("EstadoOperacionIdEstadoOperacion");

                    b.Navigation("Agricultores");

                    b.Navigation("Cultivos");

                    b.Navigation("EstadoOperacion");
                });

            modelBuilder.Entity("APIBlueLearn.Model.Partida", b =>
                {
                    b.HasOne("APIBlueLearn.Model.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorIdJugador");

                    b.HasOne("APIBlueLearn.Model.Logro", "Logro")
                        .WithMany()
                        .HasForeignKey("LogroIdLogro");

                    b.Navigation("Jugador");

                    b.Navigation("Logro");
                });
#pragma warning restore 612, 618
        }
    }
}
