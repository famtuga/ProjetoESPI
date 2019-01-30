using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class Horario
    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HorarioId { get; set; }

        [Required(ErrorMessage = "Campo nome da disciplina inválido!")]
        public string NomeProva { get; set;}
        
        [Required(ErrorMessage = "Campo Data Inicio inválido!")]
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Inicio inválido!")]
        public DateTime Datainicio { get; set; }

        public bool DiaInteiro { get; set; } 
    
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Fim inválido!")]
        public DateTime? Datafim { get; set; }

        [Required(ErrorMessage = "Campo Tipo de Prova inválido!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Ano inválido!")]
        [Range(1, 3, ErrorMessage = "Campo Ano inválido!")]
        public int Ano { get; set; }

        public ICollection<HorarioDisciplina> HorarioDisciplina { get; set; }

    }

}
