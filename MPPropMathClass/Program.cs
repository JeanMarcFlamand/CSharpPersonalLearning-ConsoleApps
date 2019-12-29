using System;


namespace MPPropMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double Qty = 2.0;
            double Weight = 2.235;
            double Momentx;
            double WeightWXarm;
            double? Xarm = null;
            // double? Xarm = 32.58;
            

            Momentx = MPMath.Moment(Qty, Weight, Xarm);

            WeightWXarm = MPMath.WeightWArm(Qty, Weight, Xarm);

         
            Console.WriteLine("Le moment est de: {0:f4} ", Momentx.ToString());

            if (WeightWXarm != 0)
            {
                Console.WriteLine("This moment included a weight of: {0:f4} ", Weight.ToString());

            }
            else
            {
                Console.WriteLine("This weight : {0:f4} has no center of gravity.", Weight.ToString());
            }
            
        }
    }
}
