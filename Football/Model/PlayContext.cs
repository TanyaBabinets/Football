using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Football.Model
{
    public class PlayContext:DbContext
    {
       public PlayContext() : base ("DbFootball"){}
        public DbSet<Team> team { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Player> player { get; set; }
        public DbSet<Match> match { get; set; }

       
        public void AddTeam(Team temp)
        {

            team.Add(temp);

            SaveChanges();
        }
        
        public void AddPlayer(Player temp)
        {

            player.Add(temp);

            SaveChanges();
        }

        public Country GetCountry(string a)
            {
                foreach (var item in country)
                {
                    if (item.Name.ToLower() == a.ToLower())
                        return item;
                }


                return null;
            }

        public List<Team> GetTeams()
        { 
            var list = new List<Team>();
            foreach (var item in team.ToList())
            {
                Entry(item).Reference("country").Load();
                list.Add(item);
                
            }
            return list;
        }
        public Team GetTeam(Team a)
        {
           a= team.Find(a.Id);
             Entry(a).Reference("country").Load();

            return a;
        }






    }
}
