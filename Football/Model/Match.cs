using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Model
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime date { get; set; }       
        public virtual Team team_One { get; set; }
       public virtual Team team_Two { get; set; }
        public int scoreTeam1 { get; set; }
        public int scoreTeam2 { get; set; }
        public virtual ICollection<Player> player { get; set; }

        public Match() { player = new List<Player>(); }
    } 
}
