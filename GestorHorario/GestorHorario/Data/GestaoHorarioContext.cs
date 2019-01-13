using GestorHorario.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Data
{
    public partial class GestaoHorarioContext : DbContext
    {
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Aluno_Disciplina> Aluno_Disciplina { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Horario_Disciplina> Horario_Disciplina { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=horarios;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.AlunoId);
                


            });

            modelBuilder.Entity<Disciplina>(entity =>
            {
                entity.HasKey(e => e.DisciplinaId);
                
            });

            modelBuilder.Entity<Aluno_Disciplina>()
        .HasKey(ad => new { ad.AlunoId, ad.DisciplinaId });
            modelBuilder.Entity<Aluno_Disciplina>()
                .HasOne(ad => ad.Disciplina)
                .WithMany(d => d.Aluno_Disciplinas)
                .HasForeignKey(ad => ad.DisciplinaId);
            modelBuilder.Entity<Aluno_Disciplina>()
                .HasOne(ad => ad.Aluno)
                .WithMany(a => a.Aluno_Disciplina)
                .HasForeignKey(ad => ad.AlunoId);



       

           

            modelBuilder.Entity<Professor>(entity =>
            {

                entity.HasKey(e => e.ProfessorId);

                entity.HasMany(e => e.Disciplinas).
                WithOne(e => e.Professor);
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.HorarioId);

              
            });

            modelBuilder.Entity<Horario_Disciplina>()
        .HasKey(ad => new { ad.HorarioId, ad.DisciplinaId });
            modelBuilder.Entity<Horario_Disciplina>()
                .HasOne(ad => ad.Horario)
                .WithMany(d => d.Horario_Disciplinas)
                .HasForeignKey(ad => ad.HorarioId);
            modelBuilder.Entity<Horario_Disciplina>()
                .HasOne(ad => ad.Disciplina)
                .WithMany(a => a.Horario_Disciplinas)
                .HasForeignKey(ad => ad.DisciplinaId);


        }

    }
}





   