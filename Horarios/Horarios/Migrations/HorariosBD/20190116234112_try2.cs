using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Horarios.Migrations.HorariosBD
{
    public partial class try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.DisciplinaId);
                });

            migrationBuilder.CreateTable(
                name: "Estudante",
                columns: table => new
                {
                    EstudanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NumeroEstudante = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    EstadoEstudante = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudante", x => x.EstudanteId);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    HorarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeProva = table.Column<string>(nullable: true),
                    Datainicio = table.Column<DateTime>(nullable: false),
                    DiaInteiro = table.Column<bool>(nullable: false),
                    Datafim = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    TemaCor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.HorarioId);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    Email = table.Column<int>(nullable: false),
                    Professor_Email = table.Column<string>(nullable: true),
                    Telemovel = table.Column<string>(nullable: true),
                    DisciplinasDisciplinaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.ProfessorId);
                    table.ForeignKey(
                        name: "FK_Professor_Disciplina_DisciplinasDisciplinaId",
                        column: x => x.DisciplinasDisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstudanteDisciplina",
                columns: table => new
                {
                    EstudanteId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudanteDisciplina", x => new { x.EstudanteId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_EstudanteDisciplina_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudanteDisciplina_Estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "Estudante",
                        principalColumn: "EstudanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorarioDisciplina",
                columns: table => new
                {
                    HorarioId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioDisciplina", x => new { x.HorarioId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_HorarioDisciplina_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioDisciplina_Horario_HorarioId",
                        column: x => x.HorarioId,
                        principalTable: "Horario",
                        principalColumn: "HorarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplina_DisciplinaId",
                table: "Disciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudante_EstudanteId",
                table: "Estudante",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudanteDisciplina_DisciplinaId",
                table: "EstudanteDisciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_HorarioId",
                table: "Horario",
                column: "HorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioDisciplina_DisciplinaId",
                table: "HorarioDisciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_DisciplinasDisciplinaId",
                table: "Professor",
                column: "DisciplinasDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_ProfessorId",
                table: "Professor",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudanteDisciplina");

            migrationBuilder.DropTable(
                name: "HorarioDisciplina");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Estudante");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Disciplina");
        }
    }
}
