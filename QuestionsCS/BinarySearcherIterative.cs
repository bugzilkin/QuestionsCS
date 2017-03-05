namespace AK.QuestionsCS
{
    public class BinarySearcherIterative : BinarySearcherBase
    {
        protected override int? BinarySearchBody(int[] array, int x, int start, int end)
        {
            while (start < end)
            {
                int mid = start + (end - start) / 2; // to avoid overflow in case of very long array

                if (x <= array[mid])
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            if (array[end] == x)
            {
                return end;
            }

            return null;
        }
    }
}
