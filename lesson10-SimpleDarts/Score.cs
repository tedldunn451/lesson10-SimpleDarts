using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson10_SimpleDarts
{
    public class Score
    {
        public static int CalculateScore(int value, int specialScore)
        {
            // specialScore of 0 is an inner bullseye hit
            if (specialScore == 0)
                return 50;
            // specialScore of 1 is an outer bullseye hit
            else if (specialScore == 1)
                return 25;
            // specialScore of 2 is an outer band hit (x2 score)
            else if (specialScore == 2)
                return value * 2;
            // specialScore of 3 is an inner bank hit (x3 score)
            else if (specialScore == 3)
                return value * 3;
            // any other value for specialScore is just a regular hit
            else
                return value;
        }
    }
}