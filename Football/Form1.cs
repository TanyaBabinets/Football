using Football.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Football
{
    public partial class Form1 : Form
    {
        PlayContext db = null;
        public Form1()
        {
            InitializeComponent();
            using (db = new PlayContext())
            {
                listBox1.DataSource = db.GetTeams();
                listBox2.DataSource = db.player.ToList();
               comboBox3.DataSource = db.team.ToList();
                comboBox2.DataSource = db.team.ToList();
                comboBox1.DataSource = db.team.ToList();
            }



        }
        public List<Team> getList1()
        {
            using (PlayContext db = new PlayContext())
            {
                return db.team.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//list of teams
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)//list of players
        {
           
        }

        private void button1_Click(object sender, EventArgs e)//ADD TEAM
        {
           
                using (db = new PlayContext())
                {
                    Team teams = new Team();
                    teams.name = textBox1nameTeam.Text;
                teams.country = db.GetCountry(textBox2Country.Text);
                if (teams.country == null)
                {
                    Country country2 = new Country();
                    country2.Name = textBox2Country.Text;
                    db.country.Add(country2);
                    db.SaveChanges();
                    teams.country = db.GetCountry(textBox2Country.Text);
                }              
                 
                 
                    db.AddTeam(teams);

                    listBox1.DataSource = db.team.ToList();
              
                comboBox3.DataSource = db.team.ToList();
                comboBox2.DataSource = db.team.ToList();
                comboBox1.DataSource = db.team.ToList();

                textBox1nameTeam.Text = string.Empty;
                    textBox2Country.Text = string.Empty;
                    textBox6MatchDate.Text = string.Empty;
                    
                }
            }

        private void button2_Click(object sender, EventArgs e)//add PLAYER
        {
            using (db = new PlayContext())
            {
                Player players = new Player();
                players.name = textBox3Player.Text;
                players.number = Convert.ToInt32(textBox4Number.Text);
                players.position = textBox5Position.Text;
                db.SaveChanges();

                db.AddPlayer(players);
                
                listBox2.DataSource = db.player.ToList();

                textBox3Player.Text = string.Empty;
                textBox4Number.Text = string.Empty;
                textBox5Position.Text = string.Empty;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //teams combo box
        {
            //comboBox1.DataSource = db.team.ToList();
            //comboBox1.SelectedIndex = 0;       
            //Player player = new Player();
            //player.team= (Team)comboBox1.SelectedItem;
           

        }

        private void button3_Click(object sender, EventArgs e)//LOAD RESULTs
        {
            using (db = new PlayContext())
            {
                Match match = new Match();
                DateTime date = DateTime.Parse(textBox6MatchDate.Text);
                match.date = date;
                match.scoreTeam1= Convert.ToInt32(textBox1.Text);
                match.scoreTeam2 = Convert.ToInt32(textBox2.Text);
                                  
                 match.team_One = db.GetTeam((Team)comboBox2.SelectedItem);
               match.team_Two = db.GetTeam((Team)comboBox3.SelectedItem);
                db.match.Add(match);
                db.SaveChanges();

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox6MatchDate.Text = string.Empty;

            }



        
        }
        
    }
}

