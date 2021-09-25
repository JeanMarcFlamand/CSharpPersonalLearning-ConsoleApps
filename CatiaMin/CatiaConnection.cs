using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using HybridShapeTypeLib;
using INFITF;
using MECMOD;
using PARTITF;

namespace CatiaMin
{
    class CatiaConnection
    {
        INFITF.Application Hsp_catiaApp;
        MECMOD.PartDocument Hsp_catiaPartDoc;
        MECMOD.Sketch Hsp_catiaSktech;

        ShapeFactory SF;
        HybridShapeFactory HSF;

        public bool IsCatiaLunch()
        {
            try
            {
                object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject(
                    "CATIA.Application");
                Hsp_catiaApp = (INFITF.Application)catiaObject;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
            


    }
}
