using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    public class Klant
    {
        //Fields aanmaken
        private int _idKlant;
        private string _KLvoornaam;
        private string _KLachternaam;
        private string _telefoonnummer;
        private string _emailadres;


        //Properties aanmaken
        public int idKlant
        {
            get { return _idKlant; }
            set { _idKlant = value; }
        }
        public string KLvoornaam
        {
            get { return _KLvoornaam; }
            set { _KLvoornaam = value; }
        }
        public string KLachternaam
        {
            get { return _KLachternaam; }
            set { _KLachternaam = value; }
        }
        public string Telefoonnummer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }
        public string Emailadres
        {
            get { return _emailadres; }
            set { _emailadres = value; }
        }

        //Properties
        public Klant(int idKlant, string KLvoornaam, string KLachternaam, string Telefoonnummer, string Emailadres)
        {
            _idKlant = idKlant;
            _KLvoornaam = KLvoornaam;
            _KLachternaam = KLachternaam;
            _telefoonnummer = Telefoonnummer;
            _emailadres = Emailadres;
        }
        public Klant(string KLvoornaam, string KLachternaam, string Telefoonnummer, string Emailadres)
        {
            _KLvoornaam = KLvoornaam;
            _KLachternaam = KLachternaam;
            _telefoonnummer = Telefoonnummer;
            _emailadres = Emailadres;
        }


        //ToString Method
        public override string ToString()
        {
            return Convert.ToInt16(_idKlant) + " - " + _KLvoornaam.ToString() + " - " + _KLachternaam.ToString() + " - " + _telefoonnummer.ToString() + " - " + _emailadres.ToString();
        }


        

    }
}
