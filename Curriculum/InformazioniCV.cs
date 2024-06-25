﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum
{
    internal class InformazioniCV
    {
        public class Informazioni
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string Telefono { get; set; }
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
            public Esperienza Esperienza { get; set; }
        }

        public class Esperienza
        {
            public string Azienda { get; set; }
            public string TitoloLavoro { get; set; }
            public DateTime Dal { get; set; }
            public DateTime Al { get; set; }
            public string Descrizione { get; set; }
            public string Compiti
            {
                get; set;
            }
        }

        public class CV
        {
            public Informazioni Informazioni { get; set; }
            public List<Studi> StudiEffettuati { get; set; }
            public List<Impiego> Impieghi { get; set; }
            public CV()
            {
                StudiEffettuati = new List<Studi>();
                Impieghi = new List<Impiego>();
            }
        }

       
    }
}
