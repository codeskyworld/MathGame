using System;
using System.Collections.Generic;
using WebServer.Process;

namespace WebServer.NumberGeneration
{
    public class FifthTry
    {
        private int randomNumber1;
        private int randomNumber2;
        private int randomNumber3;
        private int randomNumber4;
        public FifthTry()
        {

            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            randomNumber1 = randomNumberGenerator.Number1;
            randomNumber2 = randomNumberGenerator.Number2;
            randomNumber3 = randomNumberGenerator.Number3;
            randomNumber4 = randomNumberGenerator.Number4;
        }

        public List<string> FifthTryResult()
        {
            if (randomNumber3 < randomNumber4)
            {
                int temp = randomNumber3;
                randomNumber3 = randomNumber4;
                randomNumber4 = temp;
            }
            double result = Convert.ToDouble((randomNumber1 + randomNumber2) * (randomNumber3 - randomNumber4))/4;

            string wordOfRandomNumber1 = ValueConvert.NumberToWords(randomNumber1.ToString());
            string wordOfRandomNumber2 = randomNumber2.ToString();
            string wordOfRandomNumber3 = ValueConvert.NumberToWords(randomNumber3.ToString());
            string wordOfRandomNumber4 = ValueConvert.NumberToWords(randomNumber4.ToString());
            string wordOfResult = ValueConvert.NumberToWords(result.ToString());

            string[] FifthTryStringArray = { wordOfRandomNumber1, wordOfRandomNumber2, wordOfRandomNumber3, wordOfRandomNumber4, wordOfResult };                      

            List<string> FifthTryStringList = new List<string>();

            FifthTryStringList.AddRange(FifthTryStringArray);

            return FifthTryStringList;
        }
    }
}
