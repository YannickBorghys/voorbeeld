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
    public partial class Sessies : Form
    {
        public Sessies()
        {
            InitializeComponent();
        }

        private void Sessies_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            foreach (Sessie se in _controller.getSessies())
            {
                lstSessies.Items.Add(se.ToString());
            }
        }

        private void lstSessies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKlantAdd_Click(object sender, EventArgs e)
        {
            SessiesToevoegen sesvoegtoe = new SessiesToevoegen();
            sesvoegtoe.Show();
            Sessies ses = new Sessies();
            this.Visible = false;
            this.Hide();
        }

        private void btnSessieDelete_Click(object sender, EventArgs e)
        {
            Controller _Controller = new Controller();
            Sessie seVerwijder = null;
            foreach (Sessie se in _Controller.getSessies())
            {
                if (se.idSessie == Convert.ToInt16(cboSessieVerwijderen.Text))
                {
                    seVerwijder = se;
                }
            }
            _Controller.deleteSessie(seVerwijder);

            lstSessies.Items.Clear();
            foreach (Sessie se in _Controller.getSessies())
            {
                lstSessies.Items.Add(se.ToString());
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Startpagina start = new Startpagina();
            start.Show();
            Sessies ses = new Sessies();
            this.Visible = false;
            this.Hide();
        }
    }
}
