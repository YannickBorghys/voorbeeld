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
    public partial class ProblemenUpdaten : Form
    {
        public ProblemenUpdaten()
        {
            InitializeComponent();
        }

        private void ProblemenUpdaten_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Probleem pr in _controller.getProblemen())
            {
                cboUpdate.Items.Add(pr.idProbleem.ToString());
            }
        }

        private void btnLeerlingUpdateAccept_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            Probleem pr = new Probleem(
               Convert.ToInt16(cboUpdate.Text),
               txtProbleemBeschrijving.Text,
               txtProbleemProgressie.Text
               );
            _controller.updateProbleem(pr);



            txtProbleemBeschrijving.Clear();
            txtProbleemProgressie.Clear();


            Problemen prob = new Problemen();
            prob.Show();
            ProblemenUpdaten update = new ProblemenUpdaten();
            this.Visible = false;
            this.Hide();
        }
    }
}
