using System;

namespace AK.QuestionsCS
{
    public class MaximumProductCalculator
    {
        public int? GetMaximumProduct(int[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.Length == 0)
                throw new ApplicationException("There are no elements in the input array");

            int indexOfGreatest = GetIndexOfMaximum(input);
            int indexOfGreater = GetIndexOfMaximum(input, indexOfGreatest);

            int? maxProd = null;

            try
            {
                checked
                {
                    maxProd = input[indexOfGreatest] * input[indexOfGreater];
                }
            }
            catch(OverflowException ex)
            {
                throw new ApplicationException("Maximum product value exceeds maximum for integer in C#", ex);
            }

            return maxProd;            
        }        

        public int GetIndexOfMaximum(int[] input, int? indexToExclude = null)
        {
            var idxMaximum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] > input[idxMaximum] && i != indexToExclude)
                {
                    idxMaximum = i;
                }
            }
            return idxMaximum;
        }
    }
}
