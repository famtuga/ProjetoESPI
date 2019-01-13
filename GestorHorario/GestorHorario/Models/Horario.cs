using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Horario
    {
        public int HorarioId { get; set; }

        [Display(Name = "Data De Inicio para a prova")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = false)]
        [DataType(DataType.DateTime)]
        public DateTime Datainicio { get; set; }

        [Display(Name = "Data Final da Prova")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = false)]
        [DataType(DataType.DateTime)]
        public DateTime Datafim { get; set; }

        public int Ano { get; set; }

        public ICollection<Horario_Disciplina> Horario_Disciplinas { get; set; }

    }
}
