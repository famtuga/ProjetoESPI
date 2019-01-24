using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class Disciplina
    {
        
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public ICollection<EstudanteDisciplina> EstudanteDisciplina { get; set; }
        public ICollection<HorarioDisciplina> HorarioDisciplinas { get; set; }
       
    }
}
