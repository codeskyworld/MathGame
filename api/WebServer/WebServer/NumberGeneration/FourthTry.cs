﻿using System.Collections.Generic;
using WebServer.Process;

namespace WebServer.NumberGeneration
{
    public class FourthTry
    {
        private int randomNumber1;
        private int randomNumber2;
        public FourthTry()
        {

            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            randomNumber1 = randomNumberGenerator.Number1;
            randomNumber2 = randomNumberGenerator.Number2;
        }

        public List<string> FourthTryResult()
        {
            int result = randomNumber1 * randomNumber2;

            string wordOfResult = ValueConvert.NumberToWords(result.ToString());
            string wordOfRandomNumber2 = randomNumber2.ToString();
            string wordOfRandomNumber1 = ValueConvert.NumberToWords(randomNumber1.ToString());

            string[] FourthTryStringArray = { wordOfResult, wordOfRandomNumber2,
                wordOfRandomNumber1 };

            List<string> FourthTryStringList = new List<string>();

            FourthTryStringList.AddRange(FourthTryStringArray);

            return FourthTryStringList;
        }
    }
}
