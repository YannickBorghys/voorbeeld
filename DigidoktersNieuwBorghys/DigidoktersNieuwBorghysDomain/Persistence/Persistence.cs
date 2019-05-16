using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigidoktersNieuwBorghysDomain.Business;
using MySql.Data.MySqlClient;

namespace DigidoktersNieuwBorghysDomain.Persistence
{
    public class Persistence
    {
        //field
        private string _connectionstring;

        //constructor
        public Persistence()
        {
            _connectionstring = "server = localhost; User id=root; Database = digidoktersborghys;Password=Test123";
        }


        //KLANT
        public List<Klant> getKlantenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM klant", conn);

            List<Klant> lijst = new List<Klant>();
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Klant kl = new Klant(Convert.ToInt16(dataReader["idKlant"]), dataReader["KLvoornaam"].ToString(), dataReader["KLachternaam"].ToString(), dataReader["Telefoonnummer"].ToString(), dataReader["Emailadres"].ToString());
                lijst.Add(kl);
            }
            conn.Close();
            return lijst;
        }
        //
        //
        //
        
        //
        //
        //

        //PROBLEEM
        public List<Probleem> getProblemenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM probleem", conn);

            List<Probleem> lijst = new List<Probleem>();
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Probleem pr = new Probleem(Convert.ToInt16(dataReader["idProbleem"]), dataReader["Beschrijving"].ToString(), dataReader["Progressie"].ToString());
                lijst.Add(pr);
            }
            conn.Close();
            return lijst;
        }


        //SESSIE
        public List<Sessie> getSessiesFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sessie", conn);

            List<Sessie> lijst = new List<Sessie>();
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Sessie se = new Sessie(Convert.ToInt16(dataReader["idSessie"]), Convert.ToDateTime(dataReader["Datum"]), Convert.ToDateTime(dataReader["Tijdstip"]));
                lijst.Add(se);
            }
            conn.Close();
            return lijst;
        }


        //LEERLING
        public List<Leerling> getLeerlingenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM leerling", conn);

            List<Leerling> lijst = new List<Leerling>();
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Leerling ll = new Leerling(Convert.ToInt16(dataReader["idLeerling"]), dataReader["LLvoornaam"].ToString(), dataReader["LLachternaam"].ToString());
                lijst.Add(ll);
            }
            conn.Close();
            return lijst;
        }


        

        // UPDATES AND DELETES
        //
        //
        //
        //
        //------------------------------
        public void updateKlant(Klant kl)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" UPDATE klant SET idKlant = @idKlant, KlVoornaam = @KlVoornaam, KlAchternaam = @KlAchternaam,  Telefoonnummer = @Telefoonnummer, Emailadres = @emailadres WHERE idKlant = @idKlant", conn);
            //invullenparameters

            cmd.Parameters.AddWithValue("idKlant", kl.idKlant);
            cmd.Parameters.AddWithValue("KlVoornaam", kl.KLvoornaam);
            cmd.Parameters.AddWithValue("KlAchternaam", kl.KLachternaam);
            cmd.Parameters.AddWithValue("Telefoonnummer", kl.Telefoonnummer);
            cmd.Parameters.AddWithValue("Emailadres", kl.Emailadres);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteKlant(Klant kl)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" DELETE FROM klant WHERE idKlant = @idKlant", conn);
            //invullenparameters
            cmd.Parameters.AddWithValue("idKlant", kl.idKlant);


            conn.Open();
            cmd.ExecuteNonQuery(); //INSERT-query uitvoeren
            conn.Close();
        }


        public void updateProbleem(Probleem pr)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" UPDATE probleem SET idProbleem = @idProbleem, Beschrijving = @Beschrijving, Progressie = @Progressie WHERE idProbleem = @idProbleem", conn);
            //invullenparameters

            cmd.Parameters.AddWithValue("idProbleem", pr.idProbleem);
            cmd.Parameters.AddWithValue("Beschrijving", pr.Beschrijving);
            cmd.Parameters.AddWithValue("Progressie", pr.Progressie);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteProbleem(Probleem pr)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" DELETE FROM probleem WHERE idProbleem = @idProbleem", conn);
            //invullenparameters
            cmd.Parameters.AddWithValue("idProbleem", pr.idProbleem);


            conn.Open();
            cmd.ExecuteNonQuery(); //INSERT-query uitvoeren
            conn.Close();
        }


        public void updateLeerling(Leerling ll)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" UPDATE leerling SET idLeerling = @idLeerling, LLvoornaam = @LLvoornaam, LLachternaam = @LLachternaam WHERE idLeerling = @idLeerling", conn);
            //invullenparameters

            cmd.Parameters.AddWithValue("idLeerling", ll.idLeerling);
            cmd.Parameters.AddWithValue("LLvoornaam", ll.LLvoornaam);
            cmd.Parameters.AddWithValue("LLachternaam", ll.LLachternaam);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteLeerling(Leerling ll)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" DELETE FROM leerling WHERE idLeerling = @idLeerling", conn);
            //invullenparameters
            cmd.Parameters.AddWithValue("idLeerling", ll.idLeerling);


            conn.Open();
            cmd.ExecuteNonQuery(); //INSERT-query uitvoeren
            conn.Close();
        }



        public void updateSessie(Sessie se)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" UPDATE sessie SET idSessie = @idSessie, Datum = @Datum, Tijdstip = @Tijdstip WHERE idSessie = @idSessie", conn);
            //invullenparameters

            cmd.Parameters.AddWithValue("idSessie", se.idSessie);
            cmd.Parameters.AddWithValue("Datum", se.Datum);
            cmd.Parameters.AddWithValue("Tijdstip", se.Tijdstip);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteSessie(Sessie se)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand(" DELETE FROM sessie WHERE idSessie = @idSessie", conn);
            //invullenparameters
            cmd.Parameters.AddWithValue("idSessie", se.idSessie);


            conn.Open();
            cmd.ExecuteNonQuery(); //INSERT-query uitvoeren
            conn.Close();
        }


        public void addKlant(Klant kl)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Klant(KLvoornaam,KLachternaam,Emailadres,Telefoonnummer) VALUES(@KLvoornaam,@KLachternaam,@Emailadres,@Telefoonnummer)", conn);

            cmd.Parameters.AddWithValue("KLvoornaam", kl.KLvoornaam);
            cmd.Parameters.AddWithValue("KLachternaam", kl.KLachternaam);
            cmd.Parameters.AddWithValue("Emailadres", kl.Emailadres);
            cmd.Parameters.AddWithValue("Telefoonnummer", kl.Telefoonnummer);

            conn.Open();

            cmd.ExecuteNonQuery(); //OMDAT HET EEN ACTIEQUERY IS (INSERT INTO)

            conn.Close();


        }
        public void addLeerling(Leerling ll)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Leerling(LLvoornaam,LLachternaam) VALUES(@LLvoornaam,@LLachternaam)", conn);

            cmd.Parameters.AddWithValue("LLvoornaam", ll.LLvoornaam);
            cmd.Parameters.AddWithValue("LLachternaam", ll.LLachternaam);
            

            conn.Open();

            cmd.ExecuteNonQuery(); //OMDAT HET EEN ACTIEQUERY IS (INSERT INTO)

            conn.Close();


        }
        public void addProbleem(Probleem pr)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Probleem(Progressie,Beschrijving) VALUES(@Progressie,@Beschrijving)", conn);

            cmd.Parameters.AddWithValue("Progressie", pr.Progressie);
            cmd.Parameters.AddWithValue("Beschrijving", pr.Beschrijving);
            

            conn.Open();

            cmd.ExecuteNonQuery(); //OMDAT HET EEN ACTIEQUERY IS (INSERT INTO)

            conn.Close();


        }
        public void addSessie(Sessie se)
        {
            MySqlConnection conn = new MySqlConnection(_connectionstring);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Sessie(Tijdstip,Datum) VALUES(@Tijdstip,@Datum)", conn);

            cmd.Parameters.AddWithValue("Tijdstip", se.Tijdstip);
            cmd.Parameters.AddWithValue("Datum", se.Datum);
            

            conn.Open();

            cmd.ExecuteNonQuery(); //OMDAT HET EEN ACTIEQUERY IS (INSERT INTO)

            conn.Close();


        }











    }
}
