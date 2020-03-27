using MPDB_ModelsListandLinq.Models;
using System;
using System.Collections.Generic;

namespace MPDB_ModelsListandLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Part> ListofParts = Parts.LoadParts();

            foreach (var part in ListofParts)
            {
                Console.WriteLine($"{part.Id} {part.PartNumber} {part.DescriptionID} {part.CreatedBy}" +
                    $" {part.CreationDate.ToShortDateString()}");
            }
        }
    }
}
