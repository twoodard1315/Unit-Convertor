using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{
    public class Speed

    {
        private double[] speedFactors = {3.6, 1, 2.24, 3.28}; //meters per second is default 
                                        // Kilometer per second, meter per second, miles per hour, feet per second
        public double SpeedConversion(String unit, double num) //convert everything to meters per second
        {       
            switch(unit)
            {
                case ("Kilometers per Second"):
                    num /= speedFactors[0];
                    break;

                case ("Meters per Second"):
                    num *= speedFactors[1];
                    break;

                case ("Miles per Hour"):
                    num /= speedFactors[2];
                    break;

                case ("Feet per Second"):
                    num /= speedFactors[3];
                    break;
            }      
            
            return num;
        }

        public double FinalConversion(String unitOut, double output)
        {
            switch (unitOut)
            {
                case ("Kilometers per Hour"):
                    output *= speedFactors[0];
                    break;

                case ("Meters per Second"):
                    output *= speedFactors[1];
                    break;

                case ("Miles per Hour"):
                    output *= speedFactors[2];
                    break;

                case ("Feet per Second"):
                    output *= speedFactors[3];
                    break;
            }

            return output;        
        }
    }
}