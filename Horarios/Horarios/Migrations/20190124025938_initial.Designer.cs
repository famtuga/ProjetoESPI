﻿// <auto-generated />
using System;
using Horarios.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Horarios.Migrations
{
    [DbContext(typeof(HorariosBDContext))]
    [Migration("20190124025938_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Horarios.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Horarios.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnName("Ano");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome");

                    b.Property<int>("ProfessorId");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("Horarios.Models.Estudante", b =>
                {
                    b.Property<int>("EstudanteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<string>("Email");

                    b.Property<bool>("EstadoEstudante");

                    b.Property<string>("Nome")
                        .HasMaxLength(80);

                    b.Property<int>("NumeroEstudante");

                    b.HasKey("EstudanteId");

                    b.ToTable("Estudante");
                });

            modelBuilder.Entity("Horarios.Models.EstudanteDisciplina", b =>
                {
                    b.Property<int>("EstudanteId");

                    b.Property<int>("DisciplinaId");

                    b.Property<int?>("EstudanteId1");

                    b.HasKey("EstudanteId", "DisciplinaId");

                    b.HasIndex("EstudanteId1");

                    b.ToTable("EstudanteDisciplina");
                });

            modelBuilder.Entity("Horarios.Models.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnName("Ano");

                    b.Property<DateTime?>("Datafim")
                        .HasColumnName("Datafim");

                    b.Property<DateTime>("Datainicio")
                        .HasColumnName("Datainicio");

                    b.Property<string>("Descricao")
                        .HasColumnName("Descricao");

                    b.Property<bool>("DiaInteiro")
                        .HasColumnName("DiaInteiro");

                    b.Property<string>("NomeProva")
                        .HasColumnName("NomeProva");

                    b.HasKey("HorarioId");

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

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Horarios.Models.Disciplina", b =>
                {
                    b.HasOne("Horarios.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Horarios.Models.EstudanteDisciplina", b =>
                {
                    b.HasOne("Horarios.Models.Disciplina", "Disciplina")
                        .WithMany("EstudanteDisciplina")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horarios.Models.Estudante", "Estudante")
                        .WithMany("EstudanteDisciplina")
                        .HasForeignKey("EstudanteId1");
                });

            modelBuilder.Entity("Horarios.Models.HorarioDisciplina", b =>
                {
                    b.HasOne("Horarios.Models.Horario", "Horario")
                        .WithMany("HorarioDisciplina")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horarios.Models.Disciplina", "Disciplina")
                        .WithMany("HorarioDisciplinas")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Horarios.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Horarios.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horarios.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Horarios.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}