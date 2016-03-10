using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class ReverseAStringIteratively
    {
        public static string Execute(string strToReverse)
        {
            if (null == strToReverse)
            {
                throw new System.ArgumentNullException("strToReverse");
            }
            if (strToReverse.Length <= 1)
            {
                return strToReverse;
            }
            char[] strAsChars = strToReverse.ToCharArray();
            int strlen = strAsChars.Length -1;
            for(int charIndex = 0; charIndex < strlen / 2.0 ; charIndex++)
            {
                char end = strAsChars[strlen - charIndex];
                strAsChars[strlen - charIndex] = strAsChars[charIndex];
                strAsChars[charIndex] = end;
            }
            return new string(strAsChars);
        }
    }
}
