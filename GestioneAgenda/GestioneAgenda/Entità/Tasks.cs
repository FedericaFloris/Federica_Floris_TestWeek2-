using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneAgenda.Entità
{
    internal class Tasks

    {

        public string NomeTask { get; set; } //descrizione come dentista,dottore ecc

        public DateTime DataScadenza { get; set; }

        public string LivelloDiPriorita { get; set; }

        public override string ToString()
        {
            return $"Nome: {NomeTask}-Data dell'avvenimeto {DataScadenza}-Livello di priorità: {LivelloDiPriorita}";
        }
    }

   
}
    
