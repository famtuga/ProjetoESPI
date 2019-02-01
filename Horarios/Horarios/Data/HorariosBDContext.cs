using Horarios.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Data
{
    public class HorariosBDContext : IdentityDbContext<ApplicationUser>
    {
        public HorariosBDContext(DbContextOptions<HorariosBDContext> options) : base(options) { }
        public virtual DbSet<Estudante> Estudante { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<EstudanteDisciplina> EstudanteDisciplina { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<HorarioDisciplina> HorarioDisciplina { get; set; }
        public virtual DbSet<TipoProva> TipoProva { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EstudanteDisciplina>().HasKey(new string[] { "EstudanteId", "DisciplinaId" });
            modelBuilder.Entity<HorarioDisciplina>().HasKey(new string[] { "HorarioId", "DisciplinaId" });

            modelBuilder.Entity<Disciplina>(entity =>
            {

                entity.HasOne(d => d.Professor)
                   .WithMany(p => p.Disciplinas)
                   .HasForeignKey(p => p.ProfessorId);


                entity.HasMany(ed => ed.HorarioDisciplinas)
                    .WithOne(e => e.Disciplina)
                    .HasForeignKey(bc => bc.HorarioId);

                entity.HasMany(ed => ed.EstudanteDisciplina)
                    .WithOne(d => d.Disciplina)
                    .HasForeignKey(e => e.EstudanteId);

                entity.Property(e => e.Nome).HasColumnName("Nome");

                entity.Property(e => e.Ano).HasColumnName("Ano");

            });

            

                modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.HorarioId);


                entity.HasOne(d => d.TipoProva)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(p => p.TipoProvaID);

                entity.HasMany(ed => ed.HorarioDisciplina)
                .WithOne(d => d.Horario)
                .HasForeignKey(ed => ed.DisciplinaId);

                entity.Property(e => e.NomeProva).HasColumnName("NomeProva");

                entity.Property(e => e.Datainicio).HasColumnName("Datainicio");

                entity.Property(e => e.DiaInteiro).HasColumnName("DiaInteiro");

                entity.Property(e => e.Datafim).HasColumnName("Datafim");

                entity.Property(e => e.TipoProvaID).HasColumnName("TipoProvaID");

                entity.Property(e => e.Ano).HasColumnName("Ano");
            });


            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(e => e.ProfessorId);

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorId");

                entity.Property(e => e.Nome).HasColumnName("Nome");

                entity.Property(e => e.Idade).HasColumnName("Idade");

                entity.Property(e => e.Idade).HasColumnName("Email");

                entity.Property(e => e.Telemovel).HasColumnName("Telemovel");
            });
        }
    }
}
