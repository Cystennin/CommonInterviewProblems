using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class BinarySearchOfUnsortedArray<T>
    {
        public static int Execute(T itemToFind, T[] arrayToSearch)
        {
            int index = Find(itemToFind, arrayToSearch, 0);
            return index;
        }

        private static int Find(T itemToFind, T[] arrayToSearch, int startIndex)
        {
            int len = arrayToSearch.Length - 1;
            if (0 == len)
            {
                if (arrayToSearch[0].Equals(itemToFind))
                {
                    return startIndex;
                }
                else
                {
                    return -1;
                }
            }

            int halfwayIndex = (len / 2) + 1;
            T[] firstHalf = arrayToSearch.Subset(0, halfwayIndex);
            int firstHalfResult = Find(itemToFind, firstHalf, 0);
            if (firstHalfResult >= 0)
            {
                return firstHalfResult;
            }

            int remainder = len - halfwayIndex +1;
            T[] secondHalf = arrayToSearch.Subset(halfwayIndex, remainder);
            int secondHalfResult = Find(itemToFind, secondHalf, halfwayIndex);
            if (secondHalfResult >= 0)
            {
                return secondHalfResult;
            }
            return -1;
        }
    }
}
