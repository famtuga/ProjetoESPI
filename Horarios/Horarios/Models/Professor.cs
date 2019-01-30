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
        [Required(ErrorMessage = "Introduza o nome do professor!")]
        [RegularExpression(@"([A-Za-z áàâãéèêíóôõúçÁÀÂÃÉÈÍÓÔÕÚÇ\s]+)", ErrorMessage = "Só é aceitavel caracteres alfabeticos ")]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Campo Email inválido!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Range(18,80,ErrorMessage ="Campo Idade inválido!")]
        public int Idade { get; set; }

        [RegularExpression(@"(^(91|92|93|96)([\d]{7}))")]
        public string Telemovel { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
