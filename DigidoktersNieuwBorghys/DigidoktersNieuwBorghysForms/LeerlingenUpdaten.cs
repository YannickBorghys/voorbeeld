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
    public partial class LeerlingenUpdaten : Form
    {
        public LeerlingenUpdaten()
        {
            InitializeComponent();
        }

        private void LeerlingenUpdaten_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Leerling ll in _controller.getLeerlingen())
            {
                cboUpdate.Items.Add(ll.idLeerling.ToString());
            }
        }

        private void cboUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLeerlingUpdateAccept_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            Leerling ll = new Leerling(
               Convert.ToInt16(cboUpdate.Text),
               txtLeerlingVoornaam.Text,
               txtLeerlingAchternaam.Text
               );
            _controller.updateLeerling(ll);



            txtLeerlingVoornaam.Clear();
            txtLeerlingAchternaam.Clear();
            

            Leerlingen lln = new Leerlingen();
            lln.Show();
            LeerlingenUpdaten update = new LeerlingenUpdaten();
            this.Visible = false;
            this.Hide();
        }
    }
}
