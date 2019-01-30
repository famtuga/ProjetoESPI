using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models.ViewModels
{
    public class TipoProvasViewModel
    {
        public PagingInfo PagingInfo { get; set; } = new PagingInfo();
        public IEnumerable<TipoProva> TipoProvas;
    }
}
