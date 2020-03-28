using System;
using System.Collections.Generic;
using System.Text;

namespace MPDB_ModelsListandLinq.Models
{
    public class Details
    {
        public  static List<Detail> LoadDetails()
        {
            List<Detail> output = new List<Detail>();
            ///Pattern
            //output.Add ( new Detail { DetailId = 1, MassPropAttibutesID = 1, DetailType = "", MaterialCode = "", UnitWeighty = 2, WeightStatus = "", Info = "" });
            output.Add(new Detail { Id = -1223492781, MassPropAttibutesID = null , DetailType = "V", MaterialCode = "A", UnitWeighty = 10, WeightStatus = "E", Info = null });
            output.Add(new Detail { Id = -1206743587, MassPropAttibutesID = null, DetailType = "V", MaterialCode = "A", UnitWeighty = 60, WeightStatus = "E", Info = null });
            output.Add(new Detail { Id = -934717560, MassPropAttibutesID = null, DetailType = "V", MaterialCode = "A", UnitWeighty = 25, WeightStatus = "E", Info = null });
            output.Add(new Detail { Id = -319324710, MassPropAttibutesID = null, DetailType = "D", MaterialCode = "A", UnitWeighty = .5, WeightStatus = "E", Info = null });
            output.Add(new Detail { Id = 1346316534, MassPropAttibutesID = null, DetailType = "D", MaterialCode = "A", UnitWeighty = 20, WeightStatus = "E", Info = null });

            return output;
        }

    }
}
