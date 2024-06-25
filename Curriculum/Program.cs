using System.Security.Cryptography.X509Certificates;
using static Curriculum.InformazioniCV;

namespace Curriculum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InformazioniCV.CV MioCv = new InformazioniCV.CV();
            MioCv.Informazioni = new InformazioniCV.Informazioni()
            {
                Nome = "Giampaolo",
                Cognome = "Paladino",
                Telefono = "3472582545",
                Email = "example@gmail.com",
            };

            MioCv.StudiEffettuati.Add(new InformazioniCV.Studi
            {
                Qualifica = "Epicode Student",
                Istituto = "Epicode Sede Milano",
                Tipo = "Universitario",
                Dal = new DateTime(2024, 3, 1),
                Al = new DateTime(2024, 9, 20),
            });

            MioCv.Impieghi.Add(new InformazioniCV.Impiego
            {
                Esperienza = new InformazioniCV.Esperienza
                {
                    Azienda = "Tim SPA",
                    TitoloLavoro = "Sviluppatore",
                    Dal = new DateTime(2025, 3, 4),
                    Al = DateTime.Now,
                    Descrizione = "programmatore del sito web",
                    Compiti = "Scrivere tutto il codice",
                }
            });
            Stampa(MioCv);

            static void Stampa(InformazioniCV.CV cv)
            {
                Console.WriteLine("=== CURRICULUM VITAE ===");
                Console.WriteLine("Informazioni Personali:");
                Console.WriteLine($"Nome: {cv.Informazioni.Nome}");
                Console.WriteLine($"Cognome: {cv.Informazioni.Cognome}");
                Console.WriteLine($"Telefono: {cv.Informazioni.Telefono}");
                Console.WriteLine($"Email: {cv.Informazioni.Email}");
                Console.WriteLine();

                Console.WriteLine("Studi Effettuati");
                foreach (var studi in cv.StudiEffettuati)
                {
                    Console.WriteLine($"Qualifica: {studi.Qualifica}");
                    Console.WriteLine($"Istituto: {studi.Istituto}");
                    Console.WriteLine($"Tipo: {studi.Tipo}");
                    Console.WriteLine($"Dal: {studi.Dal.ToShortDateString()}");
                    Console.WriteLine($"Al: {studi.Al.ToShortDateString()}");
                    Console.WriteLine();
                }
                Console.WriteLine("Impieghi");
                foreach (var impiego in cv.Impieghi)
                {
                    Console.WriteLine($"Azienda: {impiego.Esperienza.Azienda}");
                    Console.WriteLine($"Titolo Lavoro: {impiego.Esperienza.TitoloLavoro}");
                    Console.WriteLine($"Dal: {impiego.Esperienza.Dal.ToShortDateString()}");
                    Console.WriteLine($"Al: {impiego.Esperienza.Al.ToShortDateString()}");
                    Console.WriteLine($"Descrizione: {impiego.Esperienza.Descrizione}");
                    Console.WriteLine($"Compiti: {impiego.Esperienza.Compiti}");
                    Console.WriteLine();
                }
            }
        }
    }
}
