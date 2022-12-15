using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Process
{
    public static class ValueProcessFloat
    {
        private static string[] _smallNumbers = new string[]
    { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
      "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
      "Eighteen", "Nineteen"};

        // Tens number names from twenty upwards
        private static string[] _tens = new string[]
            { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        //Get the int value
        public static int GetIntlValue(float value)
        {
            int result = (int)Math.Truncate(value);
            return result;
        }

        //Get the decimal value
        public static float GetDecimalValue(float value)
        {
            float result = (float)(value - Math.Truncate(value));
            return result;
        }

        //Keep 2 decimal places for the value
        public static float RoundValue(float value)
        {
            float result = (float)Math.Round(value, 2);
            return result;
        }

        // Converts a two-digit group into English words
        public static string DecimalToWords(float twoDigits)
        {   
            int valueDigits = (int)(twoDigits * 100);

            if (valueDigits == 0)
            {
                return "";
            }

            // Initialise the return text
            string groupText = "";

            if (valueDigits % 10 == 0)
            {
                groupText += _smallNumbers[valueDigits/10];
                groupText = "Point " + groupText + " ";
                return groupText;
            }



            // Determine the tens and units
            int tens = valueDigits / 10;
            int units = valueDigits % 10;

            // Tens rules
            if (tens >= 2)
            {
                groupText += _tens[tens];
                if (units != 0)
                {
                    groupText += " " + _smallNumbers[units];
                }
            }
            else if (tens < 2)
                groupText += _smallNumbers[valueDigits];

            groupText = "Point " + groupText + " ";

            return groupText;
        }
    }
}
