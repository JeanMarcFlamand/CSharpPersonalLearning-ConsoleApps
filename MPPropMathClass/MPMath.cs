using System;
using System.Collections.Generic;
using System.Text;

namespace MPPropMathClass
{
    static class MPMath
    {
        // Calculete a moment if only if the arm is not null. If arm is null moment return 0
        public static double  Moment(double qty, double weight,double? arm)
        {

            if (arm.HasValue)
            {
                
                return qty * weight * (double) arm;
            }
            else
            {
                return 0;
            }

        }

        // Calculete Total Weight moment if only if the arm is not null. If arm is null moment return 0
        public static double WeightWArm(double qty, double weight, double? arm)
        {

            if (arm.HasValue)
            {

                return qty * weight;
            }
            else
            {
                return 0;
            }

        }
    }
}
