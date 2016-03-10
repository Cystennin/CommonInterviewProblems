using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems
{
    public static class FindMostFrequentIntegerInAnArray
    {
        public static T findMostFrequentInteger<T>(T[] arrayToAnalyze)
        {
            if (null == arrayToAnalyze)
            {
                throw new System.ArgumentNullException("arrayToAnalyze");
            }
            if (arrayToAnalyze.Length == 0)
            {
                throw new System.ArgumentOutOfRangeException("arrayToAnalyze", "Must have at least one element.");
            }
            T keyForMostFrequentInt = default(T);
            int countForMostFrequentInt = 0;
            SortedDictionary<T, int> valueBucket = new SortedDictionary<T, int>();
            for (int index = 0; index < arrayToAnalyze.Length; index++)
            {
                T val = arrayToAnalyze[index];
                int count = 0;
                if (valueBucket.ContainsKey(val))
                {
                    count = valueBucket[val] +1;
                    valueBucket[val] = count;

                }
                else
                {
                    valueBucket.Add(val, 1);
                    count = 1;
                }
                if (count > countForMostFrequentInt)
                {
                    countForMostFrequentInt = count;
                    keyForMostFrequentInt = val;
                }
            }
            return keyForMostFrequentInt;
        }
    }
}
