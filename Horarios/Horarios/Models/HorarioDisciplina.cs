using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class HorarioDisciplina
    {

        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
