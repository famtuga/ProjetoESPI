using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorario.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required(ErrorMessage = "Introduza o nome do aluno ")]
        [RegularExpression(@"([A-Za-záàâãéèêíóôõúçÁÀÂÃÉÈÍÓÔÕÚÇ\s]+)", ErrorMessage = "Só é aceitavel caracteres alfabeticos ")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Ano { get; set; }
        
        public ICollection<Aluno_Disciplina> Aluno_Disciplina { get; set; }
    }
}
