using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Team
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string League { get; set; }
        public Team(string name, string town, string league)
        {
            this.Name = name;
            this.Town = town;
            this.League = league;
        }

    }
}
