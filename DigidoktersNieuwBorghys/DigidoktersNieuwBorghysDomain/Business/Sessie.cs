using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    public class Sessie
    {
        //Fields
        private int _idSessie;
        private DateTime _datum;
        private DateTime _tijdstip;

        //
        public int idSessie
        {
            get { return _idSessie; }
            set { _idSessie = value; }
        }
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public DateTime Tijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }

        public Sessie(int idSessie, DateTime datum, DateTime Tijdstip)
        {
            _idSessie = idSessie;
            _datum = datum;
            _tijdstip = Tijdstip;
        }
        public Sessie(DateTime datum, DateTime Tijdstip)
        {

            _datum = datum;
            _tijdstip = Tijdstip;
        }


        public override string ToString()
        {
            return Convert.ToInt16(_idSessie) + " - " + Convert.ToDateTime(_datum) + " " + Convert.ToDateTime(_tijdstip);
        }
    }
}
