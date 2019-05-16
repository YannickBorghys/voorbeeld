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
    public partial class KlantenUpdaten : Form
    {
        public KlantenUpdaten()
        {
            InitializeComponent();
        }

        private void btnKlantUpdateAccept_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            Klant kl = new Klant(
               Convert.ToInt16(cboUpdate.Text),
               txtKlantVoornaam.Text,
               txtKlantAchternaam.Text,
               txtKlantTelefoonnummer.Text,
               txtKlantEmail.Text);
            _controller.updateKlant(kl);
            


            txtKlantVoornaam.Clear();
            txtKlantAchternaam.Clear();
            txtKlantTelefoonnummer.Clear();
            txtKlantEmail.Clear();

            Klanten klant = new Klanten();
            klant.Show();
            KlantenUpdaten klantupdate = new KlantenUpdaten();
            this.Visible = false;
            this.Hide();
        }

        private void KlantenUpdaten_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            
            foreach (Klant kl in _controller.getKlanten())
            {
                cboUpdate.Items.Add(kl.idKlant.ToString());
            }
        }
    }
}
