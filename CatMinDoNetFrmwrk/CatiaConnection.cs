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

        Part MyPart;
        Sketches MySketches;

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

        public Boolean CreatePart()
        {
            INFITF.Documents catDocuments1 = Hsp_catiaApp.Documents;
            Hsp_catiaPartDoc = catDocuments1.Add("Part") as MECMOD.PartDocument;
            MyPart = Hsp_catiaPartDoc.Part;

            return true;
        }

        public void CreateBlankSketch()
        {
            // Factories for creating model elements (Std and Hybrid)
            SF = (ShapeFactory)MyPart.ShapeFactory;
            HSF = (HybridShapeFactory)MyPart.HybridShapeFactory;

            // Select and rename geometric set
            HybridBodies catHybridBodies1 = MyPart.HybridBodies;
            HybridBody catHybridBody1;
            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometry Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Aucun ensemble géométrique trouvé ! " + Environment.NewLine +
                    "Créez une PIÈCE manuellement et assurez-vous que « Ensemble géométrique » est activé.",
                    "Échec", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            catHybridBody1.set_Name("Profile");

            // Place the new sketch in the selected geometric set on an offset plane
            MySketches = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = MyPart.OriginElements;
            HybridShapePlaneOffset hybridShapePlaneOffset1 = HSF.AddNewPlaneOffset(
                (Reference)catOriginElements.PlaneYZ, 90.000000, false);
            hybridShapePlaneOffset1.set_Name("Offset plane");
            catHybridBody1.AppendHybridShape(hybridShapePlaneOffset1);
            MyPart.InWorkObject = hybridShapePlaneOffset1;
            MyPart.Update();

            HybridShapes hybridShapes1 = catHybridBody1.HybridShapes;
            Reference catReference1 = (Reference)hybridShapes1.Item("Offset plane");

            Hsp_catiaSktech = MySketches.Add(catReference1);

            // Create axis system in sketch 
            CreateAxisSystem();

            // Update part
            MyPart.Update();
        }

        private void CreateAxisSystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            Hsp_catiaSktech.SetAbsoluteAxisData(arr);
        }

        public void CreateProfile(Double b, Double h)
        {
            // Renommer l'esquisse
            Hsp_catiaSktech.set_Name("rectangle");

            // Dessiner un rectangle dans le croquis
            // Open sketch
            Factory2D catFactory2D1 = Hsp_catiaSktech.OpenEdition();

            // Create a rectangle

            // first the points
            Point2D catPoint2D1 = catFactory2D1.CreatePoint(-50, 50);
            Point2D catPoint2D2 = catFactory2D1.CreatePoint(50, 50);
            Point2D catPoint2D3 = catFactory2D1.CreatePoint(50, -50);
            Point2D catPoint2D4 = catFactory2D1.CreatePoint(-50, -50);

            // then the lines
            Line2D catLine2D1 = catFactory2D1.CreateLine(-50, 50, 50, 50);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            Line2D catLine2D2 = catFactory2D1.CreateLine(50, 50, 50, -50);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            Line2D catLine2D3 = catFactory2D1.CreateLine(50, -50, -50, -50);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            Line2D catLine2D4 = catFactory2D1.CreateLine(-50, -50, -50, 50);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D1;

            // Leaving Sketcher
            Hsp_catiaSktech.CloseEdition();
            // Update part
            MyPart.Update();
        }

        public void CreateExtrusion(Double l)
        {
            // Define main body in process
            MyPart.InWorkObject = MyPart.MainBody;

            // Create Pad Extrusion
            Pad catPad1 = SF.AddNewPad(Hsp_catiaSktech, l);

            // Rename the Pad
            catPad1.set_Name("Extrusion");

            // Part Actuatilsation
            MyPart.Update();
        }

    }
}
