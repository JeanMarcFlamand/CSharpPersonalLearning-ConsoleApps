using System;
using System.Collections.Generic;  //to add from blank console project

namespace ConsoleAppforeach001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Firstnames = new List<string>();
            Firstnames.Add("Jean-Marc");
            Firstnames.Add("Jeanne");
            Firstnames.Add("Jennifer");
            Firstnames.Add("Jessica");
            Firstnames.Add("Jill");
            Firstnames.Add("Joanie");
            Firstnames.Add("Jade");
            int v = Firstnames.Count;


            Console.WriteLine("la quantité de noms est de : " + v);
            Console.WriteLine("la quantité de noms est de ::: " + Firstnames.Count);
            foreach (var Firstname in Firstnames)
            {
                Console.WriteLine("Le prémon dans l'Item {0} De la liste est {1} ",
                                 Firstnames.IndexOf(Firstname),
                                  Firstname);
            }
        }
    }
}
