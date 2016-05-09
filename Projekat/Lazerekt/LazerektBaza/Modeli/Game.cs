using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int gid { get; set; }
        public int playerOneUid { get; set; }
        public int playerTwoUid { get; set; }
        public int attackerUid { get; set; }
        public Ship currentShip { get; set; }
        public Map<CrewMember, Position> playerOneCrew { get; set; }
        public Map<CrewMember, Position> playerTwoCrew { get; set; }
        public int round { get; set; }
        public int turn { get; set; }
        public int playerOneWins { get; set; }
    }
}
