using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szuhafo.Module.ViewModels
{
    public class FoglalasPartViewModel
    {
        [Required]
        public string Nev { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime? Erkezes { get; set; }
        [Required]
        public DateTime? Tavozas { get; set; }
    }
}
