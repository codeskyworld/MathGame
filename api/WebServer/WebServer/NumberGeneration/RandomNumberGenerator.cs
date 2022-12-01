using System;

namespace WebServer.NumberGeneration
{
    public class RandomNumberGenerator
    {
        private readonly int randomNumber1;
        private readonly int randomNumber2;
        private readonly int randomNumber3;
        private readonly int randomNumber4;
        private readonly int randomNumber5;

        Random rnd = new Random();
        public RandomNumberGenerator()
        {
            randomNumber1 = rnd.Next(1, 101);
            randomNumber2 = rnd.Next(1, 101);
            randomNumber3 = rnd.Next(1, 101);
            randomNumber4 = rnd.Next(1, 101);
        }

        public int Number1
        {
            get { return randomNumber1; }
        }

        public int Number2
        {
            get { return randomNumber2; }
        }

        public int Number3
        {
            get { return randomNumber3; }
        }

        public int Number4
        {
            get { return randomNumber4; }
        }
    }
}
