using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class ChristmasTree
    {
        public static string Print(int height)
        {
            if (height == 0) return string.Empty;

            StringBuilder sb = new StringBuilder();

            int count = 0;
            for (int index = 1; index <= height; index++)
            {
                sb.Append(' ', height - index);
                sb.Append('*', height - (height - index) + count);
                sb.Append(' ', height - index);
                sb.Append("\n");

                count++;
            }

            return sb.ToString().Substring(0, sb.Length -1);
        }
    }
}
