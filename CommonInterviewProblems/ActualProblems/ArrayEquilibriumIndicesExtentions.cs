using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Personal.CommonInterviewProblems.Algorithms
{
    public static class ArrayEquilibriumIndicesExtentions
    {
        public static List<int> getEquilibriumIndices(this List<int> target)
        {
            if (null == target)
            {
                throw new ArgumentNullException(nameof(target), "target cannot be null");
            }
            if (target.Count <1)
            {
                throw new ArgumentOutOfRangeException(nameof(target), "target cannot be empty");
            }
            if (target.Count == 1)
            {
                return new List<int> { 0 };
            }

            List<int> ep = new List<int>();
            for (int index = 0; index < target.Count(); index++)
            {
                int sumOfFirstHalf = sumOfSubArray(target, 0, index);
                int sumOfSecondHalf = sumOfSubArray(target, index + 1, target.Count - 1);
        
                if (sumOfFirstHalf.Equals(sumOfSecondHalf))
                {
                    ep.Add(index);
                }
            }
            return ep;
        }

        private static int sumOfSubArray(List<int> target, int firstIndex, int lastIndex)
        {
            int i = firstIndex;
            int sum = 0;
            while (i <= lastIndex)
	        {
                sum += target[i];
		        i++;
	        }
	        return sum;
        }
    }
}
