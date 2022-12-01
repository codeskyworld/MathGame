using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Process
{
    public static class ValueConvert
    {
        // Converts an integer or float value into English words
        public static string NumberToWords(string numberReceived)
        {
            bool resultCheckedForInt = ValueCheck.IsValidForInt(numberReceived);
            bool resultCheckedForFloat = ValueCheck.IsValidForFloat(numberReceived);

            if (resultCheckedForInt)
            {
                int number = ValueParse.ParseIntValue(numberReceived);


                bool resultNegativeChecked = ValueCheck.IsNegativeIntValue(number);

                if (resultNegativeChecked)
                {
                    return "The value input is negative!";
                }

                if (number == 0)
                {
                    return "Zero";
                }

                else
                {
                    int[] digitGroups = ValueProcessInt.DivideToFourGroupOfInt(number);
                    string[] groupText = ValueProcessInt.DivideToFourGroupOfWords(digitGroups);
                    string combined = ValueProcessInt.RecombineWord(groupText, number);

                    return combined;
                }

            }
            else if (resultCheckedForFloat)
            {
                float number = ValueParse.ParseFloatValue(numberReceived);

                bool resultNegativeChecked = ValueCheck.IsNegativeFloatValue(number);

                if (resultNegativeChecked)
                {
                    return "The value input is negative!";
                }

                if (number == 0)
                {
                    return "Zero";
                }

                else
                {
                    int numberOfInt = ValueProcessFloat.GetIntlValue(number);
                    float numberOfDecimal = ValueProcessFloat.GetDecimalValue(number);
                    numberOfDecimal = ValueProcessFloat.RoundValue(numberOfDecimal);


                    int[] digitGroups = ValueProcessInt.DivideToFourGroupOfInt(numberOfInt);
                    string[] groupText = ValueProcessInt.DivideToFourGroupOfWords(digitGroups);
                    string wordOfInt = ValueProcessInt.RecombineWord(groupText, numberOfInt);

                    string wordOfDecimal = ValueProcessFloat.DecimalToWords(numberOfDecimal);

                    if (numberOfInt == 0)
                    {
                        return wordOfDecimal;
                    }
                    else if (numberOfDecimal == 0)
                    {
                        return wordOfInt;
                    }
                    else
                    {
                        string combined = wordOfInt + " " + wordOfDecimal;
                        return combined;
                    }  
                }
            }
            else
            {
                return "The input value is meaningless!";
            }
        }

    }
}
