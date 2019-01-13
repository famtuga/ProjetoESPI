using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Horario_Disciplina
    {

        public int HorarioId { get; set; }
        public int DisciplinaId { get; set; }
        public string Tipo { get; set; }


        public Horario Horario { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}
