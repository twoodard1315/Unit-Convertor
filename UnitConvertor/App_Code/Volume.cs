using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{
    public class Volume
    {
        private double [] volumeFactors = {1, 1000, 35.195, 3.52, 1.76, 1.137, 4.546};
        //"Liter", "Milliliter - div", "Fluid Ounce - div", "Cup - div", "Pint - div", "Quart - mult", "Gallon - mult"

        public double VolumeConversion(String unit, double num) //convert everything to liters
        {
            switch (unit)
            {
                case ("Liter"):
                    num *= volumeFactors[0];
                    break;

                case ("Milliliter"):
                    num /= volumeFactors[1];
                    break;

                case ("Fluid Ounce"):
                    num /= volumeFactors[2];
                    break;

                case ("Cup"):
                    num /= volumeFactors[3];
                    break;

                case ("Pint"):
                    num /= volumeFactors[4];
                    break;

                case ("Quart"):
                    num *= volumeFactors[5];
                    break;

                case ("Gallon"):
                    num *= volumeFactors[6];
                    break;
            }
            return num;
        }

        public double FinalConversion(String unitOut, double output)
        {
            switch (unitOut)
            {
                case ("Liter"):
                    output *= volumeFactors[0];
                    break;

                case ("Milliliter"):
                    output *= volumeFactors[1];
                    break;

                case ("Fluid Ounce"):
                    output *= volumeFactors[2];
                    break;

                case ("Cup"):
                    output *= volumeFactors[3];
                    break;

                case ("Pint"):
                    output *= volumeFactors[4];
                    break;

                case ("Quart"):
                    output /= volumeFactors[5];
                    break;

                case ("Gallon"):
                    output /= volumeFactors[6];
                    break;
            }

            return output;
        }

    }
}