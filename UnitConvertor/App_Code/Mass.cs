using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{

    
    public class Mass
    {
        private double[] factors = {1, 1000, 454, 28.35};
                                //Gram, Kilogram, Pound, Ounce
        public double GramConversion(String unit, double num)
        {
            switch (unit)
            {
                case ("Gram"):
                    num *= factors[0];
                    break;

                case ("Milligram"):
                    num /= factors[1];
                        break;

                case ("Kilogram"):
                    num *= factors[1];
                    break;

                case ("Pound"):
                    num *= factors[2];
                    break;

                case ("Ounce"):
                    num *= factors[3];
                    break;            
            }

            return num;

        }

        public double FinalConversion(String unitOut, double output)
        {
            switch (unitOut)
            {
                case ("Gram"):
                    output *= factors[0];
                    break;

                case ("Milligram"):
                    output *= factors[1];
                    break;

                case ("Kilogram"):
                    output /= factors[1];
                    break;

                case ("Pound"):
                    output /= factors[2];
                    break;

                case ("Ounce"):
                    output /= factors[3];
                    break;

            }

            return output;
        }
    }
}