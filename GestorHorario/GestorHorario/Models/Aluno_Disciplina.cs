using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Aluno_Disciplina
    {
        //public int Aluno_DisciplinaId { get; set; }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}
