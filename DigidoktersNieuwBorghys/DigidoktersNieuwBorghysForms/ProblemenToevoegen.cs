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
    public partial class ProblemenToevoegen : Form
    {

        private Controller _controller = new Controller();
        public ProblemenToevoegen()
        {
            InitializeComponent();
        }

        private void ProblemenToevoegen_Load(object sender, EventArgs e)
        {

        }

        private void btnProbleemToevoegenAccept_Click(object sender, EventArgs e)
        {
            // Evaluatie eval = new Evaluatie(txtOnderwerp.Text, Convert.ToDateTime(txtDatum.Text), Convert.ToDouble(txtPunten.Text), Convert.ToDouble(txtTotaal.Text));
            Probleem pr = new Probleem(txtProbleemBeschrijvingToevoegen.Text, txtProbleemProgressieToevoegen.Text);

            _controller.addProbleem(pr);



            txtProbleemBeschrijvingToevoegen.Clear();
            txtProbleemProgressieToevoegen.Clear();


            Problemen prob = new Problemen();
            prob.Show();
            ProblemenToevoegen prvoegtoe = new ProblemenToevoegen();
            this.Visible = false;
            this.Hide();
        }
    }
}
