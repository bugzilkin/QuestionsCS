using System;

namespace AK.QuestionsCS
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            const char delimeter = ' ';
            var parsedInput = input.Split(delimeter);

            Array.Reverse(parsedInput);

            return String.Join(delimeter.ToString(), parsedInput);
        }
    }
}
