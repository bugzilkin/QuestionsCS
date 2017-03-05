namespace AK.QuestionsCS
{
    public class BinarySearcherRecursive : BinarySearcherBase
    {
        protected override int? BinarySearchBody(int[] array, int x, int start, int end)
        {
            if (start >= end)
                return null;

            int mid = start + (end - start) / 2; // to avoid overflow in case of very long array

            if (array[mid] == x)
                return mid;

            else if ((array[mid] > x))
                return BinarySearchBody(array, x, start, mid);
            else
                return BinarySearchBody(array, x, mid + 1, end);
        }
    }
}
