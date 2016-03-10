using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class ReverseAStringRecursively
    {
        private static string result = String.Empty;
        public static string Execute(string strToReverse)
        {
            return reverse(strToReverse);
        }

        private static string reverse(string strToReverse)
        {
            int len = strToReverse.Length -1;
            if (len < 1)
            {
                return strToReverse;
            }
            string subString = strToReverse.Substring(1, len - 1);
            string reversedSubString = reverse(subString);
            reversedSubString = strToReverse.Substring(len, 1) + reversedSubString;
            reversedSubString = reversedSubString + strToReverse.Substring(0, 1);
            return reversedSubString;
        }
    }
}
