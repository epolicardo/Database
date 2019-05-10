﻿// <auto-generated />
using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190501232223_materias")]
    partial class materias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Database.Models.Archivos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ruta");

                    b.HasKey("Id");

                    b.ToTable("Archivos");
                });

            modelBuilder.Entity("Database.Models.Asistencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlumnoId");

                    b.Property<int?>("CursoId");

                    b.Property<DateTime>("Fecha");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("Database.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MateriaId");

                    b.Property<int?>("ProfesorId");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Database.Models.CursosAlumnos", b =>
                {
                    b.Property<int>("AlumnoId");

                    b.Property<int>("CursoId");

                    b.HasKey("AlumnoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("CursosAlumnos");
                });

            modelBuilder.Entity("Database.Models.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlumnoId");

                    b.Property<int>("Calificacion");

                    b.Property<int?>("CursoId");

                    b.Property<DateTime>("Fecha");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Database.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Database.ModelsData.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Database.Models.Asistencia", b =>
                {
                    b.HasOne("Database.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("Database.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("Database.Models.Curso", b =>
                {
                    b.HasOne("Database.ModelsData.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId");

                    b.HasOne("Database.Models.Profesor", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("Database.Models.CursosAlumnos", b =>
                {
                    b.HasOne("Database.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Database.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Database.Models.Notas", b =>
                {
                    b.HasOne("Database.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("Database.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");
                });
#pragma warning restore 612, 618
        }
    }
}
