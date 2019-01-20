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
        
        public string NomeProva { get; set;}
        
        
        [DataType(DataType.DateTime)]
        public System.DateTime Datainicio { get; set; }

        public Boolean DiaInteiro { get; set; } 

    
        [DataType(DataType.DateTime)]
        public  Nullable<System.DateTime> Datafim { get; set; }

        public string Descricao { get; set; }

        public string TemaCor { get; set; }

        public ICollection<HorarioDisciplina> HorarioDisciplina { get; set; }

    }

}
