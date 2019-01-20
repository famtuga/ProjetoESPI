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
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroEstudante { get; set; }
        public int Ano { get; set; }
        public bool EstadoEstudante { get; set; }

        
        public ICollection<EstudanteDisciplina> EstudanteDisciplina { get; set; }
    }
}
