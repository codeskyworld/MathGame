using System;
using System.Collections;
using System.Collections.Generic;

namespace WebServer.NumberGeneration
{
    public class NumerAndWord
    {

        private readonly ArrayList arlist;

        public NumerAndWord()
        {
            FirstTry firstTry = new FirstTry();
            SecondTry secondTry = new SecondTry();
            ThirdTry thirdTry = new ThirdTry();
            FourthTry fourthTry = new FourthTry();
            FifthTry fifthTry = new FifthTry();

            List<string> firstList = firstTry.FirstTryResult();
            List<string> secondList = secondTry.SecondTryResult();
            List<string> thirdList = thirdTry.ThirdTryResult();
            List<string> fourthList = fourthTry.FourthTryResult();
            List<string> fifthList = fifthTry.FifthTryResult();

            arlist = new ArrayList();
            arlist.Add(firstList);
            arlist.Add(secondList);
            arlist.Add(thirdList);
            arlist.Add(fourthList);
            arlist.Add(fifthList);
        }

        public ArrayList GetNumerAndWord()
        {
            return arlist;
        }
    }
}
