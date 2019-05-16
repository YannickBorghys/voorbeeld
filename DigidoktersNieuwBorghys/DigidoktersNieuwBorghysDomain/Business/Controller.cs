using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigidoktersNieuwBorghysDomain.Business
{
    public class Controller
    {
        private Persistence.Persistence _Persistence;
        private Overzicht _Overzicht;

        public Controller()
        {
            _Persistence = new Persistence.Persistence();
            _Overzicht = new Overzicht();
            _Overzicht.Klanten = _Persistence.getKlantenFromDB();
            _Overzicht.Leerlingen = _Persistence.getLeerlingenFromDB();
            _Overzicht.Problemen = _Persistence.getProblemenFromDB();
            _Overzicht.Sessies = _Persistence.getSessiesFromDB();
        }

        //methods
        public List<Leerling> getLeerlingen()
        {
            return _Overzicht.Leerlingen;
        }
        public List<Sessie> getSessies()
        {
            return _Overzicht.Sessies;
        }
        public List<Probleem> getProblemen()
        {
            return _Overzicht.Problemen;
        }
        public List<Klant> getKlanten()
        {
            return _Overzicht.Klanten;
        }





        //DELETES
        //
        public void deleteKlant(Klant kl)
        {
            _Overzicht.deleteKlant(kl);
            _Persistence.deleteKlant(kl);
        }
        public void deleteLeerling(Leerling ll)
        {
            _Overzicht.deleteLeerling(ll);
            _Persistence.deleteLeerling(ll);
        }
        public void deleteProbleem(Probleem pr)
        {
            _Overzicht.deleteProbleem(pr);
            _Persistence.deleteProbleem(pr);
        }
        public void deleteSessie(Sessie se)
        {
            _Overzicht.deleteSessie(se);
            _Persistence.deleteSessie(se);
        }

        //

        //

        public void updateKlant(Klant kl)
        {
            _Overzicht.updateKlant(kl);
            _Persistence.updateKlant(kl);
        }
        public void updateSessie(Sessie se)
        {
            _Overzicht.updateSessie(se);
            _Persistence.updateSessie(se);
        }
        public void updateLeerling(Leerling ll)
        {
            _Overzicht.updateLeerling(ll);
            _Persistence.updateLeerling(ll);
        }
        public void updateProbleem(Probleem pr)
        {
            _Overzicht.updateProbleem(pr);
            _Persistence.updateProbleem(pr);
        }


        public void addKlant(Klant kl)
        {
            _Overzicht.addKlant(kl);
            _Persistence.addKlant(kl);
        }
        public void addLeerling(Leerling ll)
        {
            _Overzicht.addLeerling(ll);
            _Persistence.addLeerling(ll);
        }
        public void addProbleem(Probleem pr)
        {
            _Overzicht.addProbleem(pr);
            _Persistence.addProbleem(pr);
        }
        public void addSessie(Sessie se)
        {
            _Overzicht.addSessie(se);
            _Persistence.addSessie(se);
        }



    }
}
