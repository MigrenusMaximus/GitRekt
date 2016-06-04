using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class Ship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string name { get; set; }
        public List<Position> layout { get; set; }
        public List<Position> airlock { get; set; }
        public Dictionary<CrewMember, Position> crew { get; set; }
    }
}
