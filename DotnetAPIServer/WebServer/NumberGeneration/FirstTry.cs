using System.Collections.Generic;
using WebServer.Process;

namespace WebServer.NumberGeneration
{
    public class FirstTry
    {
        private int randomNumber1;
        private int randomNumber2;
        public FirstTry()
        {

            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            randomNumber1 = randomNumberGenerator.Number1;
            randomNumber2 = randomNumberGenerator.Number2;
        }

        public List<string> FirstTryResult()
        {
            int result = randomNumber1 + randomNumber2;
     
            string wordOfRandomNumber1 = ValueConvert.NumberToWords(randomNumber1.ToString());
            string wordOfRandomNumber2 = randomNumber2.ToString();
            string wordOfResult = ValueConvert.NumberToWords(result.ToString());

            string[] FirstTryStringArray = { wordOfRandomNumber1, wordOfRandomNumber2,
                        wordOfResult };

            List<string> FirstTryStringList = new List<string>();

            FirstTryStringList.AddRange(FirstTryStringArray);

            return FirstTryStringList;
        }
    }
}
