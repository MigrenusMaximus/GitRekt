using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class Position
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int xPos { get; set; }
        public int yPos { get; set; }
    }
}
