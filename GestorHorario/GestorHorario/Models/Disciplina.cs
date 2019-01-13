using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public String NomeDisciplina { get; set; }
        public int Ano { get; set; }
        public bool Ativo { get; set; }

        public Professor Professor { get; set; }
        //public Aluno_Disciplina Aluno_Disciplina { get; set; }
        //public Horario Horario { get; set; }

        //public ICollection<Professor> Professors { get; set; }
        public ICollection<Aluno_Disciplina> Aluno_Disciplinas { get; set; }
        public ICollection<Horario_Disciplina> Horario_Disciplinas { get; set; }
    }
}
