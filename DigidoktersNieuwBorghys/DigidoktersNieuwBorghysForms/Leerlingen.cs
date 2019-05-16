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
    public partial class Leerlingen : Form
    {
        public Leerlingen()
        {
            InitializeComponent();
        }

        private void Leerlingen_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            foreach (Leerling ll in _controller.getLeerlingen())
            {
                lstLeerlingen.Items.Add(ll.ToString());
            }
            foreach (Leerling ll in _controller.getLeerlingen())
            {
                cboLeerlingVerwijderen.Items.Add(ll.idLeerling.ToString());
            }


        }

        private void btnKlantAdd_Click(object sender, EventArgs e)
        {
            LeerlingenToevoegen llnvoegtoe = new LeerlingenToevoegen();
            llnvoegtoe.Show();
            Leerlingen lln = new Leerlingen();
            this.Visible = false;
            this.Hide();
        }

        private void btnLeerlingDelete_Click(object sender, EventArgs e)
        {
            Controller _Controller = new Controller();
            Leerling llVerwijder = null;
            foreach (Leerling ll in _Controller.getLeerlingen())
            {
                if (ll.idLeerling == Convert.ToInt16(cboLeerlingVerwijderen.Text))
                {
                    llVerwijder = ll;
                }
            }
            _Controller.deleteLeerling(llVerwijder);

            lstLeerlingen.Items.Clear();
            foreach (Leerling ll in _Controller.getLeerlingen())
            {
                lstLeerlingen.Items.Add(ll.ToString());
            }
        }

        private void cboLeerlingVerwijderen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLeerlingVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void btnLeerlingUpdate_Click(object sender, EventArgs e)
        {
            LeerlingenUpdaten llnupdate = new LeerlingenUpdaten();
            llnupdate.Show();
            Leerlingen ll = new Leerlingen();
            this.Visible = false;
            this.Hide();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Startpagina start = new Startpagina();
            start.Show();
            Leerlingen lln = new Leerlingen();
            this.Visible = false;
            this.Hide();
        }
    }
}
