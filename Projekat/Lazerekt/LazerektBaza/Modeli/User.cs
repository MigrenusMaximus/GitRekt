using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int uid { get; set; }
        public string username { get; set; }
        public string hashedPass { get; set; }
        public int gameid { get; set; }
        public Ship ship { get; set; }
        public int elo { get; set; }
        public Dictionary<Ship, bool> unlockedShips { get; set; }
        public Dictionary<CrewMember, bool> unlockedCrew { get; set; }
    }
}
