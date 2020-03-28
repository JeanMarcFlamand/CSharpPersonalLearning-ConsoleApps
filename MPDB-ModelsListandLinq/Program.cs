using MPDB_ModelsListandLinq.Models;
using System;
using System.Collections.Generic;

namespace MPDB_ModelsListandLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the  list of parts
            List<Part> listofParts = Parts.LoadParts();

            Console.WriteLine("Part Table");
            foreach (var part in listofParts)
            {
                
                Console.WriteLine($"{part.Id} {part.PartNumber} {part.DescriptionID} {part.CreatedBy}" +
                    $" {part.CreationDate.ToShortDateString()} .");
                
            }
            Console.WriteLine("END" + "\r\n");

            //Display the List of Detail Table
            List<Detail> listOfDetails = Details.LoadDetails();

            Console.WriteLine("Detail Table");
            foreach (var detail in listOfDetails)
            {
                
                Console.WriteLine($"{detail.Id} , {detail.MassPropAttibutesID} ," +
                    $" { detail.DetailType} , { detail.MaterialCode} , {detail.UnitWeighty.ToString("0.00")} , " +
                    $" {detail.WeightStatus} , {detail.Info} .");
                
            }
            Console.WriteLine("END" + "\r\n");


            //Display the List of Description
            List<Description> listofDescription = Descriptions.LoadDescription();
            Console.WriteLine("Description Table");
            foreach (var description in listofDescription)
            {
                Console.WriteLine($"{description.Id} , {description.DescriptionText}");
            }
            Console.WriteLine("END" + "\r\n");
        }
    }
}
