using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    public class Leerling
    {
        //Fields aanmaken
        private int _idLeerling;
        private string _LLvoornaam;
        private string _LLachternaam;


        //Properties aanmaken
        public int idLeerling
        {
            get { return _idLeerling; }
            set { _idLeerling = value; }
        }
        public string LLvoornaam
        {
            get { return _LLvoornaam; }
            set { _LLvoornaam = value; }
        }
        public string LLachternaam
        {
            get { return _LLachternaam; }
            set { _LLachternaam = value; }
        }

        //Properties
        public Leerling(int idLeerling, string LLvoornaam, string LLachternaam)
        {
            _idLeerling = idLeerling;
            _LLvoornaam = LLvoornaam;
            _LLachternaam = LLachternaam;
        }
        public Leerling(string LLvoornaam, string LLachternaam)
        {

            _LLvoornaam = LLvoornaam;
            _LLachternaam = LLachternaam;
        }

        //ToString Method
        public override string ToString()
        {
            return Convert.ToInt16(_idLeerling) + " - " + _LLvoornaam.ToString() + " - " + _LLachternaam.ToString();
        }
    }
}
