using System;


//ref https://youtu.be/Ye3rOxz7-d8

namespace InterfaceTVandCalculator
{
    class Program
    {
        static void Main(string[] args)  
        {
            //Interface Example
            Action<string> affiche = Console.WriteLine;
            Calcul premierCalcul = new Calcul(2.4, 4.5);
            Console.WriteLine("La somme donne : {0:f4} " , premierCalcul.Adition().ToString());
            //Console.WriteLine("This moment included a weight of: {0:f4} ", Weight.ToString());
            
            ICalculateur myObject = new Calcul(4.666, 5600); //In this instruction you can instansiate an Interface but you need to implement the class name
            if (myObject is ICalculateur) //compare
            {
                affiche("myObject is of type ICalculator");
                affiche(myObject.Adition().ToString());
            }

            Television myTV = new Television();

            Console.WriteLine("my tv is : {0}", myTV.Allume);
            Console.WriteLine("The volume is : {0}", myTV.VolumeSonnore);
            

            myTV.Allume = true;
            affiche("The TV is now On");
            myTV.AugmenterSon();
            Console.WriteLine("The volume is now : {0}", myTV.VolumeSonnore);
            myTV.AugmenterSon();
            Console.WriteLine("The volume is now : {0}", myTV.VolumeSonnore);

            for (int i = 0; i < 20; i++)
            {
                myTV.AugmenterSon();
            }

            Console.WriteLine("The volume is now : {0}", myTV.VolumeSonnore);
           

        }
    }
}
