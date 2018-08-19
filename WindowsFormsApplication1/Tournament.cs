using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tournament
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string League { get; set; }
        public BindingList<Team> Teams { get; set; }
        public Tournament(string name, DateTime date, string league, BindingList<Team> teams)
        {
            this.Name = name;
            this.Date = date;
            this.League = league;
            this.Teams = teams;
        }

    }
}
