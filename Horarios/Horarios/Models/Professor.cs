using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessorId { get; set; }

        [StringLength(80, MinimumLength = 2)]
        [Required(ErrorMessage = "Introduza o nome do professor ")]
        [RegularExpression(@"([A-Za-záàâãéèêíóôõúçÁÀÂÃÉÈÍÓÔÕÚÇ\s]+)", ErrorMessage = "Só é aceitavel caracteres alfabeticos ")]
        public string Nome { get; set; }

        [Range(20,80)]
        public int Idade { get; set; }

        public string Email { get; set; }

        public string Telemovel { get; set; }

        public Disciplina Disciplinas { get; set; }
    }
}
