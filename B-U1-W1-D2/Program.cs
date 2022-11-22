using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B_U1_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV curriculum = new CV();

            // INFORMAZIONI PERSONALI
            curriculum.InformazioniPersonali = new InformazioniPersonali();
            curriculum.InformazioniPersonali.Nome = "Stefano";
            curriculum.InformazioniPersonali.Cognome = "Laguda";
            curriculum.InformazioniPersonali.Telefono = 3270914072;
            curriculum.InformazioniPersonali.Email = "lagudadev@gmail.com";

            // STUDI EFFETTUATI
            curriculum.StudiEffettuati = new Studi();
            curriculum.StudiEffettuati.Qualifica = "Diploma Scuola Superiore";
            curriculum.StudiEffettuati.Istituto = "Liceo";
            curriculum.StudiEffettuati.Tipo = "Scientifico";
            curriculum.StudiEffettuati.Dal = new DateTime(2009,9,12);
            curriculum.StudiEffettuati.Al = new DateTime(2013, 6, 12);

            // IMPIEGHI
            curriculum.Impieghi = new Impiego();
            Esperienza esperienza1 = new Esperienza();
            esperienza1.Azienda = "Tabaccheria Punti Servizi";
            esperienza1.JobTitle = "Cassiere/Commesso/Tuttofare";
            esperienza1.Dal = new DateTime(2013, 1, 3);
            esperienza1.Al = new DateTime(2019, 6, 16);
            esperienza1.Descrizione = "Distribuivo fumo tra i vecchietti, facevo perdere le giocate del lotto ai malati di gioco e costringevo la gente a pagare le bollette";
            esperienza1.Compiti = "Addetto alle macchine del lotto, gestione degli ordini e dello storico dei tabacchi e commesso simpatico";

            Esperienza esperienza2 = new Esperienza();
            esperienza2.Azienda = "Yacht Ludi";
            esperienza2.JobTitle = "Operaio/Impiegato";
            esperienza2.Dal = new DateTime(2021, 9, 1);
            esperienza2.Al = new DateTime(2022, 9, 23);
            esperienza2.Descrizione = "Marinaio, ormeggiatore e cameriere";
            esperienza2.Compiti = "Salvaguardare la barca, aiutare il comandante con le sue operazioni e servire gli ospiti presenti";
           
            
            curriculum.Impieghi.Esperienza.Add(esperienza1);
            curriculum.Impieghi.Esperienza.Add(esperienza2);


            curriculum.StampaDettagliCVSuSchermo(curriculum);
            Console.ReadLine();
        }

        public class CV
        {
            public InformazioniPersonali InformazioniPersonali;
            public Studi StudiEffettuati;
            public Impiego Impieghi;
            public void StampaDettagliCVSuSchermo(CV curriculum)
            {
                Console.WriteLine($"Cv di {curriculum.InformazioniPersonali.Nome} {curriculum.InformazioniPersonali.Cognome}");
                Console.WriteLine("");
                Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
                Console.WriteLine($"Nome: {curriculum.InformazioniPersonali.Nome}");
                Console.WriteLine($"Cognome: {curriculum.InformazioniPersonali.Cognome}");
                Console.WriteLine($"Email: {curriculum.InformazioniPersonali.Email}");
                Console.WriteLine($"Telefono: {curriculum.InformazioniPersonali.Telefono}");
                Console.WriteLine("++++ FINE Informazioni Personali: ++++");
                Console.WriteLine("");
                Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
                Console.WriteLine($"Istituto: {curriculum.StudiEffettuati.Istituto}");
                Console.WriteLine($"Qualifica: {curriculum.StudiEffettuati.Qualifica}");
                Console.WriteLine($"Tipo: {curriculum.StudiEffettuati.Tipo}");
                Console.WriteLine($"Dal: {curriculum.StudiEffettuati.Dal.ToString("dd/M/yyyy")} al {curriculum.StudiEffettuati.Al.ToString("dd/M/yyyy")}");
                Console.WriteLine("++++ FINE Studi e Formazione: ++++");
                Console.WriteLine("");
                Console.WriteLine("++++ INIZIO Esperienze Professionali: ++++");

                foreach (Esperienza item in curriculum.Impieghi.Esperienza)
                {
                    Console.WriteLine($"Presso: {item.Azienda}");
                    Console.WriteLine($"Tipo di lavoro: {item.JobTitle}");
                    Console.WriteLine($"Compito: {item.Compiti}");
                    Console.WriteLine($"Dal {item.Dal.ToString("dd/M/yyyy")} al {item.Al.ToString("dd/M/yyyy")}");
                }

                Console.WriteLine("++++ FINE Esperienze Professionali: ++++");
            }

        }

        public class InformazioniPersonali 
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }

            public double Telefono { get; set; }

            public string Email { get; set; }
        }

        public class Studi 
        {
            public string Qualifica { get; set; }

            public string Istituto { get; set; }

            public string Tipo { get; set; }

            public DateTime Dal { get; set; }

            public DateTime Al { get; set; }
        }

        public class Impiego 
        {
            public List<Esperienza> Esperienza = new List<Esperienza>(); // Aggiungere Lista
        }

        public class Esperienza 
        {
            public string Azienda { get; set; }

            public string JobTitle { get; set; }

            public DateTime Dal { get; set; }

            public DateTime Al { get; set; }

            public string Descrizione { get; set; }

            public string Compiti { get; set; }
        }


    }
}
