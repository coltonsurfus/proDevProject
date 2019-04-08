using System;
namespace ProDevProject
{
    public class Calculations
    {
        public Calculations()
        {
            
        }

        public double calc(int weight, double percent)
        {
            double calculatedWeight = weight * percent;
            calculatedWeight = 5 * (double)Math.Round(calculatedWeight / 5.0);
            return calculatedWeight;
        }
    }
}
