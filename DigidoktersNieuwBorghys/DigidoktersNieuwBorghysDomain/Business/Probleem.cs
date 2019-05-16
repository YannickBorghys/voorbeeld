using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    public class Probleem
    {
        //Fields
        private int _idProbleem;
        private string _beschrijving;
        private string _progressie;

        //Properties
        public int idProbleem
        {
            get { return _idProbleem; }
            set { _idProbleem = value; }
        }
        public string Beschrijving
        {
            get { return _beschrijving; }
            set { _beschrijving = value; }
        }
        public string Progressie
        {
            get { return _progressie; }
            set { _progressie = value; }
        }


        public Probleem(int idProbleem, string beschrijving, string progressie)
        {
            _idProbleem = idProbleem;
            _beschrijving = beschrijving;
            _progressie = progressie;
        }
        public Probleem(string beschrijving, string progressie)
        {
            _beschrijving = beschrijving;
            _progressie = progressie;
        }



        public override string ToString()
        {
            return Convert.ToInt16(_idProbleem) + " - " + _beschrijving.ToString() + " - " + _progressie.ToString();
        }
    }
}
