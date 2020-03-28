using System;
using System.Collections.Generic;
using System.Text;

namespace MPDB_ModelsListandLinq.Models
{
    public class Descriptions
    {
        

        public static List<Description> LoadDescription()
        {
            List<Description> output = new List<Description>();
            ///Pattern
            //output.Add(new Description { Id = 1, DescriptionText = "" });
            output.Add(new Description { Id = -1068171605, DescriptionText = "Access Door" });
            output.Add(new Description { Id = 793684169, DescriptionText = "Accelerometer" });
            output.Add(new Description { Id = -757252251, DescriptionText = "Accent Light, Mid" });
            output.Add(new Description { Id = 2014896834, DescriptionText = "Access Cover" });
            output.Add(new Description { Id = -1995703618, DescriptionText = "Access Door Fuel Pump" });
            output.Add(new Description { Id = 926660589, DescriptionText = "Access Panel" });
            output.Add(new Description { Id = -1408994876, DescriptionText = "Beam" });
            output.Add(new Description { Id = 1667505583, DescriptionText = "Blanket" });
            output.Add(new Description { Id = 1407305575, DescriptionText = "Blind Rivet" });
            output.Add(new Description { Id = -581841266, DescriptionText = "Bolt" });
            output.Add(new Description { Id = -1608133906, DescriptionText = "Bracket Angle Assy" });
            output.Add(new Description { Id = 630123212, DescriptionText = "Bracket Assy" });
            output.Add(new Description { Id = -254783256, DescriptionText = "Bulkhead" });
            output.Add(new Description { Id = -671213707, DescriptionText = "Check Valve" });
            output.Add(new Description { Id = 1625378496, DescriptionText = "Cover" });
            output.Add(new Description { Id = 28852566, DescriptionText = "Cover Plate" });
            output.Add(new Description { Id = -1795342958, DescriptionText = "Ducts" });
            output.Add(new Description { Id = 1996374698, DescriptionText = "Engine Pump" });
            output.Add(new Description { Id = -1082235376, DescriptionText = "External Power Socket" });
            output.Add(new Description { Id = -1796266527, DescriptionText = "Fitting Assy" });
            output.Add(new Description { Id = 1827295441, DescriptionText = "Fuel Pump" });
            output.Add(new Description { Id = -6897633, DescriptionText = "Light" });
            output.Add(new Description { Id = 182165364, DescriptionText = "Light Bubble" });
            output.Add(new Description { Id = 1683707841, DescriptionText = "Nutplate Assy" });
            output.Add(new Description { Id = -1365862628, DescriptionText = "Panel" });
            output.Add(new Description { Id = -560322533, DescriptionText = "Plate Assy" });
            output.Add(new Description { Id = -679698650, DescriptionText = "Pump" });
            output.Add(new Description { Id = 857109475, DescriptionText = "Valve" });
            output.Add(new Description { Id = -998972681, DescriptionText = "Rivet" });
            output.Add(new Description { Id = -1210290215, DescriptionText = "Rivet Head - Titanium Alloy" });
            output.Add(new Description { Id = -934924744, DescriptionText = "Washer" });

            return output;
        }

    }

    //public static List<Detail> LoadDetails()
    //{
    //    List<Detail> output = new List<Detail>();
    //    ///Pattern
    //    //output.Add ( new Detail { DetailId = 1, MassPropAttibutesID = 1, DetailType = "", MaterialCode = "", UnitWeighty = 2, WeightStatus = "", Info = "" });
    //    output.Add(new Detail { Id = -1223492781, MassPropAttibutesID = null, DetailType = "V", MaterialCode = "A", UnitWeighty = 10, WeightStatus = "E", Info = null });
    //    output.Add(new Detail { Id = -1206743587, MassPropAttibutesID = null, DetailType = "V", MaterialCode = "A", UnitWeighty = 60, WeightStatus = "E", Info = null });
    //    output.Add(new Detail { Id = -934717560, MassPropAttibutesID = null, DetailType = "V", MaterialCode = "A", UnitWeighty = 25, WeightStatus = "E", Info = null });
    //    output.Add(new Detail { Id = -319324710, MassPropAttibutesID = null, DetailType = "D", MaterialCode = "A", UnitWeighty = .5, WeightStatus = "E", Info = null });
    //    output.Add(new Detail { Id = 1346316534, MassPropAttibutesID = null, DetailType = "D", MaterialCode = "A", UnitWeighty = 20, WeightStatus = "E", Info = null });

    //    return output;
    //}
}
