using CatiaMin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CatMinDoNetFrmwrk
{
    class Program
    {
        static void Main(string[] args)
        {
            new CatiaControl();
        }


    internal class CatiaControl
    {
        public CatiaControl()
        {
                try
                {

                    CatiaConnection cc = new CatiaConnection();

                    // Finde Catia Prozess
                    if (cc.IsCatiaLunch())
                    {
                        Console.WriteLine("L'application Catia est en cours d'exécution");

                        //Open a new part
                        cc.CreatePart();
                        Console.WriteLine("CatPart Created!");

                        // Make a sketch
                        cc.CreateBlankSketch();
                        Console.WriteLine("Sketch Created!");

                        // Generate a profile
                        cc.CreateProfile(20, 10);
                        Console.WriteLine("Profile Created!");

                        // Extrude bars
                        cc.CreateExtrusion(300);
                        Console.WriteLine("Extrusion Created");
                    }
                    else
                    {
                        Console.WriteLine("Application Catia en cours d'exécution introuvable");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception Trouvé");
                }
                Console.WriteLine("Fermé cette Fenêtre pour terminé cette application!");
                Console.ReadKey();

            }
        }
    }
}
