using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigidoktersNieuwBorghysDomain.Business;

namespace DigidoktersNieuwBorghysForms
{
    public partial class Startpagina : Form
    {
        public Startpagina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void btnKlantenStart_Click(object sender, EventArgs e)
        {
            Klanten klanten = new Klanten();
            klanten.Show();
            Startpagina start = new Startpagina();
            this.Visible = false;
            this.Hide();
        }

        private void btnLeerlingenStart_Click(object sender, EventArgs e)
        {
            Leerlingen leerlingen = new Leerlingen();
            leerlingen.Show();
            Startpagina start = new Startpagina();
            this.Visible = false;
            this.Hide();
        }

        private void btnSessiesStart_Click(object sender, EventArgs e)
        {
            Sessies sessies = new Sessies();
            sessies.Show();
            Startpagina start = new Startpagina();
            this.Visible = false;
            this.Hide();
        }

        private void btnProblemenStart_Click(object sender, EventArgs e)
        {
            Problemen problemen = new Problemen();
            problemen.Show();
            Startpagina start = new Startpagina();
            this.Visible = false;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
