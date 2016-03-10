using Raven.Personal.CommonInterviewProblems.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.Algorithms
{
    public static class BinarySearchOfSortedArray<T> where T: IComparable
    {
        private static readonly log4net.ILog logger = LogHelper.GetLoggerForThisClass();

        public static int Execute(T itemToFind, T[] arrayToSearch)
        {
            logger.Info($"Searching for {itemToFind.ToString()} in {arrayToSearch}");
            int startpoint = (arrayToSearch.Length / 2);
            int index = Find(itemToFind, arrayToSearch, 0, arrayToSearch.Length -1);
            return index;
        }

        private static int Find(T itemToFind, T[] arrayToSearch, int left, int right)
        {
            int len = right - left + 1;
            int index = left + len / 2;
            T value = arrayToSearch[index];
            int comparison = value.CompareTo(itemToFind);
            if (comparison == 0)
            {
                return index;
            }
            switch (comparison)
            {
                case -1:
                {
                    if (right - index == 0)
                    {
                        break;
                    }
                    return Find(itemToFind, arrayToSearch, index + 1, right);
                }
                case 1:
                {
                    if (index - left == 0)
                    {
                        break;
                    }
                    return Find(itemToFind, arrayToSearch, left, index - 1);
                }
            }

            return -1;
        }
    }
}
