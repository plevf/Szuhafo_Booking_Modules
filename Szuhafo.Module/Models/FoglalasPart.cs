using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szuhafo.Module.Models
{
    public class FoglalasPart : ContentPart
    {
        public string Nev { get; set; }
        public string Email { get; set; }
        public DateTime? Erkezes { get; set; }
        public DateTime? Tavozas { get; set; }
    }
}
