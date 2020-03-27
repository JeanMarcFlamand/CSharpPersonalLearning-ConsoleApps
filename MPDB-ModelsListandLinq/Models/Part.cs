using System;
using System.Collections.Generic;
using System.Text;

namespace MPDB_ModelsListandLinq.Models
{
    public class Part
    {

        public int Id { get; set; }
        public string PartNumber { get; set; }
        public int DescriptionID { get; set; }
        public string PartType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
