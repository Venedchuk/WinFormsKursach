using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //team
            BindingSource bSource = new BindingSource();
            bSource.DataSource = teams;
            comboBox1.DataSource = bSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.Text ="";

            //tournmt
            BindingSource bSource2 = new BindingSource();
            bSource2.DataSource = tournam;
            comboBox3.DataSource = bSource2;
            comboBox3.DisplayMember = "Name";

            


            init();
        }
        private void init()
        {


        }
        private Team selectedTeam = null;
        private Tournament selectedTour = null;
        private BindingList<Team> teams = new BindingList<Team>()
        {
            new Team("Динамо","Київ","Вища"),
            new Team("Дніпро", "Дніпро", "Вища"),
            new Team("Ворскла", "Харків", "Вища"),
            new Team("Шахтар", "Донецьк", "Вища"),
            new Team("КримТеплиця", "Крим", "Середня"),
            new Team("ГазМяс", "Одеса", "Середня")
        };
        private BindingList<Tournament> tournam = new BindingList<Tournament>()
        {
            new Tournament("Кубок України",DateTime.Today,"Вища",new BindingList<Team>() { new Team("Динамо","Київ","Вища"), new Team("Дніпро", "Дніпро", "Вища"),new Team("Ворскла", "Харків", "Вища"),new Team("Шахтар", "Донецьк", "Вища") }),
            new Tournament("Кубок Юніорів",DateTime.Today,"Середня",new BindingList<Team>() {new Team("КримТеплиця", "Крим", "Середня"),new Team("ГазМяс", "Одеса", "Середня") })
        };

        private void button1_Click(object sender, EventArgs e)
        {
            teams.Add(new Team(textBox1.Text, textBox2.Text, textBox3.Text));
            //init();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = teams.Single(x => x.Name == comboBox1.Text);
            textBox6.Text = selectedTeam.Name;
            textBox7.Text = selectedTeam.Town;
            textBox5.Text = selectedTeam.League;
            //init();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTour = tournam.Single(x => x.Name == comboBox3.Text);
            BindingSource bSource3 = new BindingSource();
            bSource3.DataSource = selectedTour.Teams;
            listBox2.DataSource = bSource3;
            listBox2.DisplayMember = "Name";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            teams.Single(x => x.Name == selectedTeam.Name).Name = textBox6.Text;
            teams.Single(x => x.Name == selectedTeam.Name).Town = textBox7.Text;
            teams.Single(x => x.Name == selectedTeam.Name).League = textBox5.Text;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = teams;
            comboBox1.DataSource = bSource;
            comboBox1.DisplayMember = "Name";
            //init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tournam;
            listBox1.DataSource = bSource;
            listBox1.DisplayMember = "Name";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tournam.Single(x => x.Name == listBox1.Text).Teams.Add(selectedTeam);
        }

       
    }
}
