using System;
using System.Collections;

namespace GestioneAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****AGENDA****");
            ArrayList listaTasks = new ArrayList();

            bool continua = true;

            while (continua)
            {
                int scelta = SchermoMenu();

                switch (scelta)
                {
                    case 1:
                        ClasseMenagment.StampaTasks(listaTasks);
                        break;
                    case 2:
                        listaTasks.Add(ClasseMenagment.AggiungiTask());
                        break;
                    case 3:
                        ClasseMenagment.EliminaTask(listaTasks);
                        break;
                    case 4:
                        ClasseMenagment.FiltraTasks(listaTasks);
                        break;
                    default: 
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }
            ClasseMenagment.StampaTasksSuFile(listaTasks);
        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Visualizza gli impegni");
            Console.WriteLine("2. Aggiungi un nuovo impegno");
            Console.WriteLine("3. Rimuovi un impegno");
            Console.WriteLine("4. Filtra gli impegni per livello di priorità(basso,medio,alto");
            Console.WriteLine("Qualsiasi altro valore per uscire");
            Console.WriteLine("Scegli un opzione");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;
        }
    }
}
