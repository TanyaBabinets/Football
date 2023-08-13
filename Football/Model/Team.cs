using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Football.Model
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        public virtual Country country { get; set; }
        public virtual ICollection<Match> match { get; set; }
        public virtual ICollection<Player> players { get; set; }

        public Team () {
            match = new List<Match>();
            players = new List<Player>();   
                }  
        public override string ToString()
        {
            return $"{name} / {country.Name} ";  
        }

    }
}
