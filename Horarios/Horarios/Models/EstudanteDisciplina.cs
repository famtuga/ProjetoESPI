using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class EstudanteDisciplina
    {
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
