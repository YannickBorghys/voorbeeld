using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    class Overzicht
    {
        //fields
        private List<Leerling> _leerlingen;
        private List<Klant> _klanten;
        private List<Sessie> _sessies;
        private List<Probleem> _problemen;
        //property
        public List<Leerling> Leerlingen
        {
            get { return _leerlingen; }
            set { _leerlingen = value; }
        }
        public List<Klant> Klanten
        {
            get { return _klanten; }
            set { _klanten = value; }
        }
        public List<Sessie> Sessies
        {
            get { return _sessies; }
            set { _sessies = value; }
        }
        public List<Probleem> Problemen
        {
            get { return _problemen; }
            set { _problemen = value; }
        }
        //Constructor
        public Overzicht()
        {
            _leerlingen = new List<Leerling>();
            _klanten = new List<Klant>();
            _problemen = new List<Probleem>();
            _sessies = new List<Sessie>();
        }




        //DELETES
        public void deleteKlant(Klant kl)
        {
            _klanten.Remove(kl);
        }
        public void deleteSessie(Sessie se)
        {
            _sessies.Remove(se);
        }
        public void deleteProbleem(Probleem pr)
        {
            _problemen.Remove(pr);
        }
        public void deleteLeerling(Leerling ll)
        {
            _leerlingen.Remove(ll);
        }



        //
        public void updateKlant(Klant kl)
        {
            foreach (Klant k in _klanten)
            {
                if (k.idKlant == kl.idKlant)
                {
                    k.idKlant = kl.idKlant;
                    k.KLvoornaam = kl.KLvoornaam;
                    k.KLachternaam = kl.KLachternaam;

                    k.Telefoonnummer = kl.Telefoonnummer;
                    k.Emailadres = kl.Emailadres;
                }
            }
        }
        public void updateSessie(Sessie se)
        {
            foreach (Sessie s in _sessies)
            {
                if (s.idSessie == se.idSessie)
                {
                    s.idSessie = se.idSessie;
                    s.Datum = se.Datum;
                    s.Tijdstip = se.Tijdstip;


                }
            }
        }
        public void updateProbleem(Probleem pr)
        {
            foreach (Probleem p in _problemen)
            {
                if (p.idProbleem == pr.idProbleem)
                {
                    p.idProbleem = pr.idProbleem;
                    p.Beschrijving = pr.Beschrijving;
                    p.Progressie = pr.Progressie;


                }
            }
        }
        public void updateLeerling(Leerling ll)
        {
            foreach (Leerling l in _leerlingen)
            {
                if (l.idLeerling == ll.idLeerling)
                {
                    l.idLeerling = ll.idLeerling;
                    l.LLvoornaam = ll.LLvoornaam;
                    l.LLachternaam = ll.LLachternaam;


                }
            }
        }



        public void addKlant(Klant kl)
        {
            _klanten.Add(kl);
        }
        public void addLeerling(Leerling ll)
        {
            _leerlingen.Add(ll);
        }
        public void addProbleem(Probleem pr)
        {
            _problemen.Add(pr);
        }
        public void addSessie(Sessie se)
        {
            _sessies.Add(se);
        }
    }
}
