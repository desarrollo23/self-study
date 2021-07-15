using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Katas
{
    public static class ValidBraces
    {
        public static bool IsValidBraces(string braces)
        {
            var bracesDictionary = new Dictionary<string, string>
            {
                { "{", "}" },
                { "[", "]" },
                { "(", ")" }
            };

            var arrCouplesBraces = new List<string>();

            foreach (var brace in braces)
            {
                if (arrCouplesBraces.Count == 0)
                    arrCouplesBraces.Add(brace.ToString());
                else
                {
                    var lastOpenedBrace = arrCouplesBraces.Last();

                    if (bracesDictionary.ContainsKey(lastOpenedBrace) && bracesDictionary[lastOpenedBrace] == brace.ToString())
                        arrCouplesBraces.RemoveAt(arrCouplesBraces.FindLastIndex(x => x.Equals(lastOpenedBrace)));
                    else
                        arrCouplesBraces.Add(brace.ToString());
                }
            }


            return arrCouplesBraces.Count == 0;
        }
    }
}
