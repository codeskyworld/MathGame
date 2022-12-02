using System.Collections.Generic;
using WebServer.Process;

namespace WebServer.NumberGeneration
{
    public class SecondTry
    {
        private int randomNumber1;
        private int randomNumber2;
        public SecondTry()
        {

            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            randomNumber1 = randomNumberGenerator.Number1;
            randomNumber2 = randomNumberGenerator.Number2;
        }

        public List<string> SecondTryResult()
        {
            if (randomNumber1 < randomNumber2)
            {
                int temp = randomNumber2;
                randomNumber2 = randomNumber1;
                randomNumber1 = temp;
            }
            int result = randomNumber1 - randomNumber2;

            string wordOfRandomNumber1 = ValueConvert.NumberToWords(randomNumber1.ToString());
            string wordOfRandomNumber2 = randomNumber2.ToString();
            string wordOfResult = ValueConvert.NumberToWords(result.ToString());

            string[] SecondTryStringArray = { wordOfRandomNumber1, wordOfRandomNumber2,
                        wordOfResult };

            List<string> SecondTryStringList = new List<string>();

            SecondTryStringList.AddRange(SecondTryStringArray);

            return SecondTryStringList;
        }
    }
}
