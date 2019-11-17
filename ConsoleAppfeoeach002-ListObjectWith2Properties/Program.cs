using System;
using System.Collections.Generic;

namespace ConsoleAppfeoeach002_ListObjectWith2Properties
{
    public class FullName : IEquatable<FullName>
    {
        public String FisrtName { get; set; }
        public String LastName { get; set; }

        public override string ToString()
        {
            return "First Name: " + FisrtName + "   Last Name: " + LastName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            FullName objAsPart = obj as FullName;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
      
        public bool Equals(FullName other)
        {
            if (other == null) return false;
            return (this.LastName.Equals(other.LastName));
        }
        // Should also override == and != operators.
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of names.
            List<FullName> FullNames = new List<FullName>();
            FullNames.Add(new FullName { FisrtName = "Jean-Marc", LastName = "Flamand" });
            FullNames.Add(new FullName { FisrtName = "Jeanne", LastName = "Tremblay" });
            FullNames.Add(new FullName { FisrtName = "Jennifer", LastName = "Tremblay Flamand" });
            FullNames.Add(new FullName { FisrtName = "Jessica", LastName = "Tremblay Flamand" });
            FullNames.Add(new FullName { FisrtName = "Jill", LastName = "Tremblay Flamand" });
            FullNames.Add(new FullName { FisrtName = "Joanie", LastName = "Tremblay Flamand" });
            FullNames.Add(new FullName { FisrtName = "Jeade", LastName = "Tremblay Flamand" });

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (FullName aFullName in FullNames)
            {
                Console.WriteLine(aFullName);
            }
        }
    }
}
