using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class Suggestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sid { get; set; }
        public string text { get; set; }
        public int votes { get; set; }
    }
}
