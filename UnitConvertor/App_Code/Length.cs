using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{

    /*
     * Miles and Kilometers need to be output in e notation or scientific notation
     */

    public class Length
    {
        private double[] LengthFactor = { 1, 1000, 100, 0.001, 39.37, 3.28, 1.09, 1609 };
        //"Meter", "Millimeter", "Centimeter", "Kilometer", "Inch", "Foot", "Yard", "Mile"

       
        public double MeterConversion(String unitIn, double meterNum) //converts input to meter regardless of output selection
        {
            switch(unitIn)
            {
                case "Meter":
                    meterNum *= LengthFactor[0];
                    break;

                case "Millimeter":
                    meterNum /= LengthFactor[1];
                    break;

                case "Centimeter":
                    meterNum /= LengthFactor[2];
                    break;

                case "Kilometer":
                    meterNum *= LengthFactor[3];
                    break;

                case "Inch":
                    meterNum /= LengthFactor[4];
                    break;

                case "Foot":
                    meterNum /= LengthFactor[5];
                    break;

                case "Yard":
                    meterNum /= LengthFactor[6];
                    break;

                case "Mile":
                    meterNum *= LengthFactor[7];
                    break;
            }

            return meterNum;
        }

        public double FinalConversion(String unitOut, double output) 
        {
            switch (unitOut) 
            {
                case "Meter":
                    output *= LengthFactor[0];
                    break;

                case "Millimeter":
                    output *= LengthFactor[1];
                    break;

                case "Centimeter":
                    output *= LengthFactor[2];
                    break;

                case "Kilometer":
                    output /= LengthFactor[3];
                    break;

                case "Inch":
                    output *= LengthFactor[4];
                    break;

                case "Foot":
                    output *= LengthFactor[5];
                    break;

                case "Yard":
                    output *= LengthFactor[6];
                    break;

                case "Mile":
                    output /= LengthFactor[7];
                    break;                
            }

            return output;
        }

    }
}