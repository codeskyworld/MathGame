using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebServer.Process
{
    public static class ValueCheck
    {
        //Check whether the value is valid for int type
        public static bool IsValidForInt(string value)
        {
            Regex r = new Regex(@"^[0-9]+$");
            return r.Match(value).Success;
        }

        //Check whether the value is valid for float type
        public static bool IsValidForFloat(string value)
        {
            Regex r = new Regex(@"^[0-9.]+$");
            return r.Match(value).Success;
        }

        public static bool IsNegativeIntValue(int value)
        {
            return (value < 0);
        }

        public static bool IsNegativeFloatValue(float value)
        {
            return (value < 0);
        }

    }
}
