﻿// <auto-generated />
using System;
using Horarios.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Horarios.Migrations.HorariosBD
{
    [DbContext(typeof(HorariosBDContext))]
    partial class HorariosBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Horarios.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DisciplinaId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnName("Ano");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("Horarios.Models.Estudante", b =>
                {
                    b.Property<int>("EstudanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EstudanteId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<string>("Email");

                    b.Property<bool>("EstadoEstudante");

                    b.Property<string>("Nome")
                        .HasMaxLength(80);

                    b.Property<int>("NumeroEstudante");

                    b.HasKey("EstudanteId");

                    b.HasIndex("EstudanteId");

                    b.ToTable("Estudante");
                });

            modelBuilder.Entity("Horarios.Models.EstudanteDisciplina", b =>
                {
                    b.Property<int>("EstudanteId");

                    b.Property<int>("DisciplinaId");

                    b.HasKey("EstudanteId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("EstudanteDisciplina");
                });

            modelBuilder.Entity("Horarios.Models.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HorarioId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Datafim");

                    b.Property<DateTime>("Datainicio");

                    b.Property<string>("Descricao");

                    b.Property<bool>("DiaInteiro");

                    b.Property<string>("NomeProva");

                    b.Property<string>("TemaCor");

                    b.HasKey("HorarioId");

                    b.HasIndex("HorarioId");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("Horarios.Models.HorarioDisciplina", b =>
                {
                    b.Property<int>("HorarioId");

                    b.Property<int>("DisciplinaId");

                    b.HasKey("HorarioId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("HorarioDisciplina");
                });

            modelBuilder.Entity("Horarios.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProfessorId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisciplinasDisciplinaId");

                    b.Property<string>("Email")
                        .HasColumnName("Professor_Email");

                    b.Property<int>("Idade")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasMaxLength(80);

                    b.Property<string>("Telemovel")
                        .HasColumnName("Telemovel");

                    b.HasKey("ProfessorId");

                    b.HasIndex("DisciplinasDisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("Horarios.Models.EstudanteDisciplina", b =>
                {
                    b.HasOne("Horarios.Models.Disciplina", "Disciplina")
                        .WithMany("EstudanteDisciplina")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horarios.Models.Estudante", "Estudante")
                        .WithMany("EstudanteDisciplina")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Horarios.Models.HorarioDisciplina", b =>
                {
                    b.HasOne("Horarios.Models.Disciplina", "Disciplina")
                        .WithMany("HorarioDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horarios.Models.Horario", "Horario")
                        .WithMany("HorarioDisciplina")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Horarios.Models.Professor", b =>
                {
                    b.HasOne("Horarios.Models.Disciplina", "Disciplinas")
                        .WithMany("professor")
                        .HasForeignKey("DisciplinasDisciplinaId");
                });
#pragma warning restore 612, 618
        }
    }
}