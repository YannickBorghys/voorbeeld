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
    public partial class Problemen : Form
    {
        public Problemen()
        {
            InitializeComponent();
        }

        private void Problemen_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            foreach (Probleem pr in _controller.getProblemen())
            {
                lstProblemen.Items.Add(pr.ToString());
            }
            foreach (Probleem pr in _controller.getProblemen())
            {
                cboProbleemVerwijderen.Items.Add(pr.idProbleem.ToString());
            }
        }

        private void btnKlantAdd_Click(object sender, EventArgs e)
        {
            ProblemenToevoegen prbvoegtoe = new ProblemenToevoegen();
            prbvoegtoe.Show();
            Problemen prb = new Problemen();
            this.Visible = false;
            this.Hide();
        }

        private void btnProbleemDelete_Click(object sender, EventArgs e)
        {
            Controller _Controller = new Controller();
            Probleem prVerwijder = null;
            foreach (Probleem pr in _Controller.getProblemen())
            {
                if (pr.idProbleem == Convert.ToInt16(cboProbleemVerwijderen.Text))
                {
                    prVerwijder = pr;
                }
            }
            _Controller.deleteProbleem(prVerwijder);

            lstProblemen.Items.Clear();
            foreach (Probleem pr in _Controller.getProblemen())
            {
                lstProblemen.Items.Add(pr.ToString());
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Startpagina start = new Startpagina();
            start.Show();
            Problemen prb = new Problemen();
            this.Visible = false;
            this.Hide();
        }

        private void btnProbleemUpdate_Click(object sender, EventArgs e)
        {
            ProblemenUpdaten update = new ProblemenUpdaten();
            update.Show();
            Problemen prb = new Problemen();
            this.Visible = false;
            this.Hide();
        }
    }
}
