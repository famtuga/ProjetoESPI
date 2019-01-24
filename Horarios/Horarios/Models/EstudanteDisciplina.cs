using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class EstudanteDisciplina
    {
        [ForeignKey("FK_EstudanteID")]
        public int EstudanteId { get; set; }

        [ForeignKey("FK_DisciplinaID")]
        public int DisciplinaId { get; set; }

        public Estudante Estudante { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
