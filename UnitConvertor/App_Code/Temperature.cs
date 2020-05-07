using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{
    public class Temperature
    {
        public double TempConversion(string unit, double num) // convert everything to celsius
        {
            double holder = num;
            switch (unit)
            {
                case ("Celsius"):
                    num *= 1;
                    break;

                case ("Fahrenheit"):
                    num = (holder - 32) * (5.0 / 9.0);
                    break;

                case ("Kelvin"):
                    num = num - 273.15;
                    break;
            }

            return num;
        }

        public double FinalConversion(string unitOut, double output)
        {
            switch (unitOut)
            {
                case ("Celsius"):
                    output *= 1;
                    break;

                case ("Fahrenheit"):
                    output = ((output * (9.0 / 5.0)) + 32);
                    break;

                case ("Kelvin"):
                    output = output + 273.15;
                    break;
            }
            return output;
        }
    }
}