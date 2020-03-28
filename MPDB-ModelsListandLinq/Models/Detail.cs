using System;
using System.Collections.Generic;
using System.Text;

namespace MPDB_ModelsListandLinq.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int? MassPropAttibutesID { get; set; }
        public string DetailType { get; set; }
        public string MaterialCode { get; set; }
        public double UnitWeighty { get; set; }
        public string WeightStatus { get; set; }
        public string Info { get; set; }
    }
}
