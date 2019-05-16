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
    
    public partial class SessiesToevoegen : Form
    {private Controller _controller = new Controller();
        public SessiesToevoegen()
        {
            InitializeComponent();
        }

        private void SessiesToevoegen_Load(object sender, EventArgs e)
        {

        }

        private void btnSessieToevoegenAccept_Click(object sender, EventArgs e)
        {
            // Evaluatie eval = new Evaluatie(txtOnderwerp.Text, Convert.ToDateTime(txtDatum.Text), Convert.ToDouble(txtPunten.Text), Convert.ToDouble(txtTotaal.Text));
            Sessie se = new Sessie(Convert.ToDateTime(txtSessieToevoegen),Convert.ToDateTime(txtSessie2Toevoegen));

            _controller.addSessie(se);



            txtSessieToevoegen.Clear();
            txtSessie2Toevoegen.Clear();
           

            Sessies ses = new Sessies();
            ses.Show();
            SessiesToevoegen sesvoegtoe = new SessiesToevoegen();
            this.Visible = false;
            this.Hide();
        }
    }
}
