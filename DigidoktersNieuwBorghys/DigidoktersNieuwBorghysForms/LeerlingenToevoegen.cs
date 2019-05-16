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
    public partial class LeerlingenToevoegen : Form
    {


        private Controller _controller = new Controller();

        public LeerlingenToevoegen()
        {
            InitializeComponent();
        }

        private void btnKlantToevoegenAccept_Click(object sender, EventArgs e)
        {
            // Evaluatie eval = new Evaluatie(txtOnderwerp.Text, Convert.ToDateTime(txtDatum.Text), Convert.ToDouble(txtPunten.Text), Convert.ToDouble(txtTotaal.Text));
            Leerling ll = new Leerling(txtLeerlingVoornaamToevoegen.Text,txtLeerlingAchternaamToevoegen.Text);

            _controller.addLeerling(ll);



            txtLeerlingVoornaamToevoegen.Clear();
            txtLeerlingAchternaamToevoegen.Clear();
           

            Leerlingen leerling = new Leerlingen();
            leerling.Show();
            LeerlingenToevoegen llvoegtoe = new LeerlingenToevoegen();
            this.Visible = false;
            this.Hide();
        }

        private void LeerlingenToevoegen_Load(object sender, EventArgs e)
        {

        }

        private void lblKlantVoornaamToevoegen_Click(object sender, EventArgs e)
        {

        }
    }
}
