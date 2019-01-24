using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class HorarioDisciplina
    {
        [ForeignKey("FK_HorarioID")]
        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
        [ForeignKey("FK_DisciplinaID")]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
