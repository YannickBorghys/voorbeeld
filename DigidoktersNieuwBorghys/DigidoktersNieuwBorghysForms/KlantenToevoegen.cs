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
    public partial class KlantenToevoegen : Form
    {

        private Controller _controller = new Controller();


        public KlantenToevoegen()
        {
            InitializeComponent();
        }

        private void KlantenToevoegen_Load(object sender, EventArgs e)
        {

        }

        private void btnKlantToevoegenAccept_Click(object sender, EventArgs e)
        {
            // Evaluatie eval = new Evaluatie(txtOnderwerp.Text, Convert.ToDateTime(txtDatum.Text), Convert.ToDouble(txtPunten.Text), Convert.ToDouble(txtTotaal.Text));
            Klant kl = new Klant(txtKlantVoornaamToevoegen.Text, txtKlantAchternaamToevoegen.Text, txtKlantTelefoonnummerToevoegen.Text, txtKlantEmailadresToevoegen.Text);

            _controller.addKlant(kl);


            
            txtKlantVoornaamToevoegen.Clear();
            txtKlantAchternaamToevoegen.Clear();
            txtKlantEmailadresToevoegen.Clear();
            txtKlantTelefoonnummerToevoegen.Clear();

            Klanten klant = new Klanten();
            klant.Show();
            KlantenToevoegen klantvoegtoe = new KlantenToevoegen();
            this.Visible = false;
            this.Hide();


        }

        
    }
}
