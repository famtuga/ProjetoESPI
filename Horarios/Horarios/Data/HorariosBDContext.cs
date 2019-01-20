using Horarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Data
{
    public class HorariosBDContext : DbContext
    {
        public virtual DbSet<Estudante> Estudante { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<EstudanteDisciplina> EstudanteDisciplina { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<HorarioDisciplina> HorarioDisciplina { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Database=Horario;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudante>(entity =>
            {
                entity.HasIndex(e => e.EstudanteId);

                entity.Property(e => e.EstudanteId).HasColumnName("EstudanteId");
                
            });


            modelBuilder.Entity<Disciplina>()
       .HasMany(d => d.professor)
       .WithOne(p => p.Disciplinas);

            modelBuilder.Entity<Disciplina>(entity =>
            {
                entity.HasIndex(e => e.DisciplinaId);

                entity.Property(e => e.DisciplinaId).HasColumnName("DisciplinaId");

                entity.Property(e => e.Nome).HasColumnName("Nome");

                entity.Property(e => e.Ano).HasColumnName("Ano");

            });


            //many to many
            modelBuilder.Entity<EstudanteDisciplina>()
         .HasKey(ed => new { ed.EstudanteId, ed.DisciplinaId });
            modelBuilder.Entity<EstudanteDisciplina>()
                .HasOne(ed => ed.Disciplina)
                .WithMany(d => d.EstudanteDisciplina)
                .HasForeignKey(ed => ed.DisciplinaId);
            modelBuilder.Entity<EstudanteDisciplina>()
                .HasOne(ed => ed.Estudante)
                .WithMany(e => e.EstudanteDisciplina)
                .HasForeignKey(bc => bc.EstudanteId);



            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasIndex(e => e.HorarioId);

                entity.Property(e => e.HorarioId).HasColumnName("HorarioId");

                //entity.Property(e => e.NomeProva).HasColumnName("NomeProva");

                //entity.Property(e => e.Datainicio).HasColumnName("Datainicio");

                //entity.Property(e => e.DiaInteiro).HasColumnName("DiaInteiro");

                //entity.Property(e => e.Datafim).HasColumnName("Datafim");

                //entity.Property(e => e.Descricao).HasColumnName("Descricao");

                //entity.Property(e => e.Temacor).HasColumnName("Ano");
            });



            //many to many
            modelBuilder.Entity<HorarioDisciplina>()
         .HasKey(ed => new { ed.HorarioId, ed.DisciplinaId });
            modelBuilder.Entity<HorarioDisciplina>()
                .HasOne(ed => ed.Disciplina)
                .WithMany(d => d.HorarioDisciplinas)
                .HasForeignKey(ed => ed.DisciplinaId);
            modelBuilder.Entity<HorarioDisciplina>()
                .HasOne(ed => ed.Horario)
                .WithMany(e => e.HorarioDisciplina)
                .HasForeignKey(bc => bc.HorarioId);


            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasIndex(e => e.ProfessorId);

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorId");

                entity.Property(e => e.Nome).HasColumnName("Nome");

                entity.Property(e => e.Idade).HasColumnName("Idade");

                entity.Property(e => e.Idade).HasColumnName("Email");

                entity.Property(e => e.Telemovel).HasColumnName("Telemovel");


            });



        }
    }
}
