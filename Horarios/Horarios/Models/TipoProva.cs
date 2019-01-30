using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class TipoProva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoProvaID { get; set; }

        [Required(ErrorMessage = "Introduza o nome da prova!")]
        [StringLength(80, MinimumLength = 2,ErrorMessage ="Nome de prova inválido!")]
        public string Nome { get; set; }


        [StringLength(200,ErrorMessage ="Campo Descrição demasiado grande!")]
        public string Descricao { get; set; }
    }
}
