using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Model
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        public int number { get; set; }
        [StringLength(50)]
        public string position { get; set; }

        public virtual ICollection<Match> match { get; set; }
        public virtual Team team { get; set; }
        public Player() { 
        match = new List<Match>();}
        public override string ToString()
        {
            return $"{Id}.{name}, number: {number}. Position on field: {position}";

        }

    }
}
