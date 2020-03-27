using System;
using System.Collections.Generic;
using System.Text;

namespace MPDB_ModelsListandLinq.Models
{
    class Parts
    {

        public static List<Part> LoadParts()
        {
            List<Part> output = new List<Part>();
            ///Pattern
            //output.Add(new Part { Id = 1, PartNumber = "", DescriptionID = 1, PartType = "", CreatedBy = "", CreationDate =Convert.ToDateTime( "2020/03/05") });
            output.Add(new Part { Id = -1223492781, PartNumber = "PartE", DescriptionID = -1365862628, PartType = "D", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = -1206743587, PartNumber = "PartC", DescriptionID = -1795342958, PartType = "D", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = -934717560, PartNumber = "PartA", DescriptionID = -581841266, PartType = "D", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = -319324710, PartNumber = "PartD", DescriptionID = -1365862628, PartType = "D", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = 170219779, PartNumber = "AssyA", DescriptionID = -1796266527, PartType = "A", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = 1346316534, PartNumber = "PartB", DescriptionID = -998972681, PartType = "D", CreatedBy = "", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = 1401459433, PartNumber = "AssyB", DescriptionID = -1796266527, PartType = "A", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });
            output.Add(new Part { Id = 1580138173, PartNumber = "AssyC", DescriptionID = 630123212, PartType = "A", CreatedBy = "7JTF", CreationDate = Convert.ToDateTime("2020/03/05") });


            //


            return output;
    }
        
        
        
    }
}
