using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Process
{
    public static class ValueParse
    {
        //Parse int value and return
        public static int ParseIntValue(string value)
        {
            Int32.TryParse(value, out int intValue);
            return intValue;
        }

        //Parse float value and return
        public static float ParseFloatValue(string value)
        {
            float.TryParse(value, out float floatValue);
            return floatValue;
        }
    }
}
