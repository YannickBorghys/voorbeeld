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
    public partial class SessiesUpdaten : Form
    {
        public SessiesUpdaten()
        {
            InitializeComponent();
        }

        private void SessiesUpdaten_Load(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Sessie se in _controller.getSessies())
            {
                cboUpdate.Items.Add(se.idSessie.ToString());
            }
        }

        private void btnLeerlingUpdateAccept_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            Sessie se= new Sessie(
               Convert.ToInt16(cboUpdate.Text),
               Convert.ToDateTime(txtLeerlingVoornaam),
               Convert.ToDateTime(txtLeerlingAchternaam)
               );
            _controller.updateSessie(se); 



            txtLeerlingVoornaam.Clear();
            txtLeerlingAchternaam.Clear();


            Sessies ses = new Sessies();
            ses.Show();
            SessiesUpdaten update = new SessiesUpdaten();
            this.Visible = false;
            this.Hide();
        }
    }
}
