using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class Estudante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudanteId { get; set; }

        [StringLength(80, MinimumLength = 2)]
        [Required(ErrorMessage = "Introduza o nome do estudante!")]
        [RegularExpression(@"([A-Za-z áàâãéèêíóôõúçÁÀÂÃÉÈÍÓÔÕÚÇ\s]+)", ErrorMessage = "Só é aceitavel caracteres alfabeticos ")]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Campo Email inválido!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [RegularExpression(@"([\d]{7})", ErrorMessage = "Campo Numero de Estudante inválido!")]
        public int NumeroEstudante { get; set; }

        [Range(1, 3, ErrorMessage = "Campo Ano inválido!")]
        public int Ano { get; set; }

        public bool EstadoEstudante { get; set; }

        
        public ICollection<EstudanteDisciplina> EstudanteDisciplina { get; set; }
    }
}
