using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTVandCalculator
{
    public class Calcul : ICalculateur
    {
        public Calcul(double nombre1, double nombre2)
        {
            Nombre1 = nombre1;
            Nombre2 = nombre2;
        }

        public double Nombre1 { get; set; }
        public double Nombre2 { get; set; }

        public double Adition()
        {
            return Nombre1 + Nombre2;
        }
        public double Soustraction()
        {
            return Nombre1 - Nombre2;
        }
        public double Multiplication()
        {
            return Nombre1 * Nombre2;
        }
        public double Division()
        {
            if (Nombre2 == 0)
            {
                throw new Exception("On ne peut pas diviser par zero"); 
            }
            else
            {
                return Nombre1 / Nombre2;
            }
            
        }
        public int CompareTo(object obj)
        {
            if ((double)obj < Nombre1)
            {
                return -1;
            }

            if ((double)obj == Nombre1)
            {
                return 0;
            }
            return 1;
        }

    }
}
