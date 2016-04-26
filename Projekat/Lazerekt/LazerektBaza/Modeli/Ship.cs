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
        public List<Postion> layout { get; set; }
        public List<Postion> airlock { get; set; }
        public Map<CrewMember, Position> crew { get; set; }
    }
}
