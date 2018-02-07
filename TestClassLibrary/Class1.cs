using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary; 

namespace TestClassLibrary
{
    public class Class1
    {
        public double AddNumbers(double valueA, double valueB)
        {
            double Output = valueA + valueB;
            if (Output > 10)
            {
                Output = 10; 
            }
            return Output; 
        }

        public string Greeting(string sName)
            {
                string sOutput = "Hello, Welcome " + sName + "!";
                return sOutput; 
            }


        // Method for Bank Holiday output.

        public bool checkBankHoliday(DateTime inputDate)
        {
            bool validBankHoliday = false;

            // New Years Day

            if ((inputDate.Day == 01) && (inputDate.Month == 01) && (inputDate.Year == 2014))
            {
                validBankHoliday = true;
            }

            // Valentines Day

            else if ((inputDate.Day == 14) && (inputDate.Month == 02) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // St Patricks Day

            else if ((inputDate.Day == 17) && (inputDate.Month == 03) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // April Fools Day

            else if ((inputDate.Day == 01) && (inputDate.Month == 04) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // St Georges Day

            else if ((inputDate.Day == 23) && (inputDate.Month == 04) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // Halloween

            else if ((inputDate.Day == 31) && (inputDate.Month == 10) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // Bonfire Night

            else if ((inputDate.Day == 05) && (inputDate.Month == 11) && (inputDate.Year == 2014))
            {
                validBankHoliday = false;
            }

            // Christmas Day

            else if ((inputDate.Day == 25) && (inputDate.Month == 12) && (inputDate.Year == 2014))
            {
                validBankHoliday = true;
            }

            // Boxing Day

            else if ((inputDate.Day == 26) && (inputDate.Month == 12) && (inputDate.Year == 2014))
            {
                validBankHoliday = true;
            }

            return validBankHoliday;


        }



     }
}
