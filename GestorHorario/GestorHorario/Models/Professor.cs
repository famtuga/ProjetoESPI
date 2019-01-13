using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        [Required(ErrorMessage = "Introduza o nome do professor ")]
        [RegularExpression(@"([A-Za-záàâãéèêíóôõúçÁÀÂÃÉÈÍÓÔÕÚÇ\s]+)", ErrorMessage = "Só é aceitavel caracteres alfabeticos ")]
        public string Nome { get; set; }
        public int Idade { get; set;}
        public string Email { get; set; }
        public string Telemovel {get; set;}

        public ICollection<Disciplina> Disciplinas { get; set; }


    }
}
