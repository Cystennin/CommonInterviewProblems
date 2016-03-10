using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Personal.CommonInterviewProblems.DataStructures.Graphs.LinkedLists;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class ArrayUtilities
    {
        public static T[] Subset<T>(this T[] array, int startIndex, int length)
        {
            T[] subset = new T[length];
            Array.Copy(array, startIndex, subset, 0, length);
            return subset;
        }
    }
}
