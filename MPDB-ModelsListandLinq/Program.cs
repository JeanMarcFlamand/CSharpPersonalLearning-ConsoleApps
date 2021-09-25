using MPDB_ModelsListandLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MPDB_ModelsListandLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the  list of parts
            List<Part> parts = Parts.LoadParts();

            Console.WriteLine("Part Table");
            foreach (var part in parts)
            {
                
                Console.WriteLine($"{part.Id} {part.PartNumber} {part.DescriptionID} {part.CreatedBy}" +
                    $" {part.CreationDate.ToShortDateString()} .");
                
            }
            Console.WriteLine("END" + "\r\n");

            //Display the List of Detail Table
            List<Detail> details = Details.LoadDetails();

            Console.WriteLine("Detail Table");
            foreach (var detail in details)
            {
                
                Console.WriteLine($"{detail.Id} , {detail.MassPropAttibutesID} ," +
                    $" { detail.DetailType} , { detail.MaterialCode} , {detail.UnitWeighty.ToString("0.00")} , " +
                    $" {detail.WeightStatus} , {detail.Info} .");
                
            }
            Console.WriteLine("END" + "\r\n");


            //Display the List of Description
            List<Description> descriptions = Descriptions.LoadDescription();
            Console.WriteLine("Description Table");
            foreach (var description in descriptions)
            {
                Console.WriteLine($"{description.Id} , {description.DescriptionText}");
            }
            Console.WriteLine("END" + "\r\n");

            ////LinQ list the part with the description
            Console.WriteLine("Part and Description");
            var partdescription =
                from part in parts
                join description in descriptions
                on part.DescriptionID  equals  description.Id 
                select new { part.PartNumber, Description  = description.DescriptionText };

            foreach (var item in partdescription)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("END" + "\r\n");
        }
    }
}
