using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class CompareWithinMargin
    {
        //public static int CloseCompare(double a, double b, double margin = 0)
        //{
        //    if (a > b && margin < Math.Abs(a - b))
        //        return 1;
        //    else if (a < b && margin < Math.Abs(a - b))
        //        return -1;



        //    return 0;
        //}

        public static int CloseCompare(double a, double b, double e = 0) => Math.Abs(a - b) <= e ? 0 : a.CompareTo(b);
    }
}
