using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class CrewMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cmid { get; set; }
        public int uid { get; set; }
        public string name { get; set; }
        public int range { get; set; }
        public double healthPoints { get; set; }
        public int actionPoints { get; set; }
        public double attack { get; set; }
        public double armour { get; set; }
    }
}
