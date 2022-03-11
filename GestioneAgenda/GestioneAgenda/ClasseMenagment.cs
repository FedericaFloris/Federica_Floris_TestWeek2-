using GestioneAgenda.Entità;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GestioneAgenda
{
    internal static class ClasseMenagment
    {
        public static void StampaTasksSuFile(ArrayList tasks)
        {
            
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "agenda.txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Tasks tasksDaStampareSuFile in tasks)
                {
                    //sw.WriteLine($"Nome: {personaDaStampareSuFile.Nome} - ");
                    sw.WriteLine(tasksDaStampareSuFile);
                }
            }
        }
        public static void StampaTask(Tasks task)
        {
            Console.WriteLine(task);
        }
        public static void StampaTasks(ArrayList tasks)
        {
            foreach (Tasks task in tasks)
            {
                StampaTask(task);
            }
        }
        internal static Tasks AggiungiTask()
        {
            Tasks task = new Tasks();
            bool verifica;

            Console.WriteLine("Inserisci descrizione del task");
            task.NomeTask = Console.ReadLine();
            Console.WriteLine("Inserisci data del task");
            verifica = DateTime.TryParse(Console.ReadLine(), out var  dataScadenza);
            while (!verifica || dataScadenza < DateTime.Now)
            {
                Console.WriteLine("Inserisci data e giorno non passato del task");
                verifica = DateTime.TryParse(Console.ReadLine(), out  dataScadenza);

            }
            task.DataScadenza = dataScadenza;
            Console.WriteLine("inserisci livello di priorità");
            task.LivelloDiPriorita = Console.ReadLine();


            return task;
        }

        public static void EliminaTask (ArrayList tasks)
        {
            Tasks taskDaCancellare = CercaTask(tasks);
            if(taskDaCancellare != null)
            {
                tasks.Remove(taskDaCancellare);
                Console.WriteLine("Cancellato");
            }
            else
            {
                Console.WriteLine("Task non trovato");
            }
        }
        public static void FiltraTasks(ArrayList tasks)
        {
            Console.WriteLine("Inserisci livello di priorità");
            string livello = Console.ReadLine();
            foreach (Tasks task in tasks)
            {
                if (task.LivelloDiPriorita.Equals(livello))
                {
                    Console.WriteLine($"Nome:{task.NomeTask} \n Data:{task.DataScadenza} \n Livello di Priorità: {task.LivelloDiPriorita}");
                }
            }
                
        }

        public static Tasks CercaTask (ArrayList tasks)
        {
            Console.WriteLine($"inserisci nome task");
            string nome = Console.ReadLine();

            foreach (Tasks task in tasks)
            {
                if (task.NomeTask.Equals(nome))
                {
                    return task;
                }
                            
            }
            return null;
        }

        
    }
}
