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
    public partial class Klanten : Form
    {
        public Klanten()
        {
            InitializeComponent();
        }

        private void Klanten_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            foreach (Klant kl in _controller.getKlanten())
            {
                lstKlanten.Items.Add(kl.ToString());
            }
            foreach (Klant kl in _controller.getKlanten())
            {
                cboKlantVerwijderen.Items.Add(kl.idKlant.ToString());
            }


        }

        private void lstKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKlantAdd_Click(object sender, EventArgs e)
        {
            KlantenToevoegen klantvoegtoe = new KlantenToevoegen();
            klantvoegtoe.Show();
            Klanten klant = new Klanten();
            this.Visible = false;
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKlantDelete_Click(object sender, EventArgs e)
        {
            Controller _Controller = new Controller();
            Klant klVerwijder = null;
            foreach (Klant kl in _Controller.getKlanten())
            {
                if (kl.idKlant == Convert.ToInt16(cboKlantVerwijderen.Text))
                {
                    klVerwijder = kl;
                }
            }
            _Controller.deleteKlant(klVerwijder);

            lstKlanten.Items.Clear();
            foreach (Klant kl in _Controller.getKlanten())
            {
                lstKlanten.Items.Add(kl.ToString());
            }
        }

        private void btnKlantUpdate_Click(object sender, EventArgs e)
        {
            KlantenUpdaten klantupdate = new KlantenUpdaten();
            klantupdate.Show();
            Klanten klant = new Klanten();
            this.Visible = false;
            this.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Startpagina start = new Startpagina();
            start.Show();
            Klanten klant = new Klanten();
            this.Visible = false;
            this.Hide();
        }
    }
}
