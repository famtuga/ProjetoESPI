using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Models
{
    public class PagingInfo
    {
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public bool Ascending { get; set; } = true;
        public int TotalItems { get; set; }
        public static int ItemsPerPage { get; set; } = 5;
        public int CurrentPage { get; set; }
        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

        public bool HasPreviousPage => (CurrentPage > 1);
        public bool HasNextPage => (CurrentPage < TotalPages);
    }
}
