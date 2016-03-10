using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class SubstringImplementation
    {
        public static string MySubString(this string target, int startingPosition, int length)
        {
            validateInputs(target, startingPosition, length);
            StringBuilder sb = new StringBuilder(length);
            for(int index=startingPosition; index < startingPosition + length; index++)
            {
                sb.Append(target[index]);
            }
            return sb.ToString();
        }

        public static void validateInputs(string target, int startingPosition, int length)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            
            if (startingPosition <0)
            {
                throw new ArgumentOutOfRangeException(nameof(startingPosition),
                    "value must not be less than 0");
            }

            if (startingPosition != 0 && startingPosition > target.Length -1)
            {
                throw new ArgumentOutOfRangeException(nameof(startingPosition),
                    $"value of startingPosition must be <= length of target({target.Length})-1");
            }
            if (length <0)
            {
                throw new ArgumentOutOfRangeException(nameof(length),
                    "value must not be less than zero");
            }
            if (startingPosition + length > target.Length)
            {
                throw new ArgumentOutOfRangeException($"value({nameof(startingPosition) + nameof(length)})",
                    $"that value of startingPosition({startingPosition}) + ({length}) cannot be greater than target.Length({target.Length})");
            }
        }
    }
}
