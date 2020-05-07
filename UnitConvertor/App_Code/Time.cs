using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConvertor.App_Code
{
    public class Time
    {
        private double[] timeFactors = {3600, 60, 1, 1000 };
        //hours, minutes, seconds, milliseconds

        public double TimeConversion(string unit, double num) //convert everything to seconds
        {
            switch (unit)
            {
                case ("Hours"):
                    num *= timeFactors[0];
                    break;

                case ("Minutes"):
                    num *= timeFactors[1];
                    break;

                case ("Seconds"):
                    num *= timeFactors[2];
                    break;

                case ("Milliseconds"):
                    num /= timeFactors[3];
                    break;
            }

            return num;
        }

        public double FinalConversion(String unitOut, double output)
        {
            switch (unitOut)
            {
                case ("Hours"):
                    output /= timeFactors[0];
                    break;

                case ("Minutes"):
                    output /= timeFactors[1];
                    break;

                case ("Seconds"):
                    output *= timeFactors[2];
                    break;

                case ("Milliseconds"):
                    output *= timeFactors[3];
                    break;
            }

            return output;
        }
    }
}