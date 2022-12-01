using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Process
{
    public static class ValueProcessInt
    {
        private static string[] _smallNumbers = new string[]
            { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
      "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
      "Eighteen", "Nineteen"};

        // Tens number names from twenty upwards
        private static string[] _tens = new string[]
            { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        // Scale number names for use during recombination
        private static string[] _scaleNumbers = new string[] { "", "Thousand", "Million", "Billion" };


        // Convert each three-digit group to words
        public static string RecombineWord(string[] groupText, int number)
        {


            // Recombine the three-digit groups
            string combined = groupText[0];
            bool appendAnd;

            int[] digitGroups = DivideToFourGroupOfInt(number);

            // Determine whether an 'and' is needed
            appendAnd = (digitGroups[0] > 0) && (digitGroups[0] < 100);

            // Process the remaining groups in turn, smallest to largest
            for (int i = 1; i < 4; i++)
            {
                // Only add non-zero items
                if (digitGroups[i] != 0)
                {
                    // Build the string to add as a prefix
                    string prefix = groupText[i] + " " + _scaleNumbers[i];

                    if (combined.Length != 0)
                    {
                        prefix += appendAnd ? " and " : ", ";
                    }

                    // Opportunity to add 'and' is ended
                    appendAnd = false;

                    // Add the three-digit group to the combined string
                    combined = prefix + combined;
                }
            }
            return combined;
        }


        // Convert each three-digit group to number
        public static int[] DivideToFourGroupOfInt(int number)
        {

            // Ensure a positive number to extract from
            int positive = Math.Abs(number);

            // Array to hold four three-digit groups
            int[] digitGroups = new int[4];

            // Extract the three-digit groups
            for (int i = 0; i < 4; i++)
            {
                digitGroups[i] = positive % 1000;
                positive /= 1000;
            }

            return digitGroups;
        }


        // Convert each group number to words
        public static string[] DivideToFourGroupOfWords(int[] digitGroups)
        {
            string[] groupText = new string[4];

            for (int i = 0; i < 4; i++)
            {
                groupText[i] = ThreeDigitGroupToWords(digitGroups[i]);
            }

            return groupText;
        }


        // Converts a three-digit group into English words
        private static string ThreeDigitGroupToWords(int threeDigits)
        {
            // Initialise the return text
            string groupText = "";

            // Determine the hundreds and the remainder
            int hundreds = threeDigits / 100;
            int tensUnits = threeDigits % 100;

            // Hundreds rules
            if (hundreds != 0)
            {
                groupText += _smallNumbers[hundreds] + " Hundred";

                if (tensUnits != 0)
                {
                    groupText += " and ";
                }
            }

            // Determine the tens and units
            int tens = tensUnits / 10;
            int units = tensUnits % 10;

            // Tens rules
            if (tens >= 2)
            {
                groupText += _tens[tens];
                if (units != 0)
                {
                    groupText += " " + _smallNumbers[units];
                }
            }
            else if (tens < 2 && tensUnits != 0)
                groupText += _smallNumbers[tensUnits];

            return groupText;
        }
    }
}
