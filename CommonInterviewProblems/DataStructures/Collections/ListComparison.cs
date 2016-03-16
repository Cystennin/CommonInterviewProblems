using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.DataStructures.Collections
{
    class ListComparison
    {
        public bool Compare<T>(List<T> listA, List<T> listB)
        {
            if (null == listA)
            {
                throw new ArgumentNullException(nameof(listA));
            }
            if (null == listB)
            {
                throw new ArgumentNullException(nameof(listB));
            }
            if (Object.Equals(listA, listB))
            {
                return true;
            }
            if (listA.Count != listB.Count)
            {
                return false;
            }
            else
            {
                Dictionary<T, int> symbolCountA = new Dictionary<T, int>();
                Dictionary<T, int> symbolCountB = new Dictionary<T, int>();
                for (int index = 0; index < listA.Count; index++)
                {
                    T symbolA = listA[index];
                    T symbolB = listB[index];
                    symbolCountA[symbolA]++;
                    symbolCountB[symbolB]++;
                }
                if (!symbolCountA.Equals(symbolCountB))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
