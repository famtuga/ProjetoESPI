using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class Disciplina
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DisciplinaId { get; set; }

        [Required(ErrorMessage = "Campo Nome inválido!")]
        public string Nome { get; set; }

        [Range(1,3,ErrorMessage = "Campo Ano inválido!")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="Campo Ano inválido!")]
        public int Ano { get; set; }

        [ForeignKey("FK_ProfessorId")]
        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public ICollection<EstudanteDisciplina> EstudanteDisciplina { get; set; }
        public ICollection<HorarioDisciplina> HorarioDisciplinas { get; set; }
       
    }
}
