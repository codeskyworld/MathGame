using System.Collections.Generic;
using WebServer.Process;

namespace WebServer.NumberGeneration
{
    public class ThirdTry
    {
        private int randomNumber1;
        private int randomNumber2;
        public ThirdTry()
        {

            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            randomNumber1 = randomNumberGenerator.Number1;
            randomNumber2 = randomNumberGenerator.Number2;
        }

        public List<string> ThirdTryResult()
        {
            int result = randomNumber1 * randomNumber2;
        
            string wordOfRandomNumber1 = ValueConvert.NumberToWords(randomNumber1.ToString());
            string wordOfRandomNumber2 = randomNumber2.ToString();
            string wordOfResult = ValueConvert.NumberToWords(result.ToString());

            string[] ThirdTryStringArray = { wordOfRandomNumber1, wordOfRandomNumber2,
                        wordOfResult };

            List<string> ThirdTryStringList = new List<string>();

            ThirdTryStringList.AddRange(ThirdTryStringArray);

            return ThirdTryStringList;
        }
    }
}

