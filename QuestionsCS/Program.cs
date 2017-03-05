using System;
using System.Linq;

namespace AK.QuestionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var correctInput = false;
            while (true)
            {
                ShowMenu();
                
                string userInput = Console.ReadLine();
                int parsedUserInput;
                if (Int32.TryParse(userInput, out parsedUserInput))
                {
                    correctInput = true;

                    switch (parsedUserInput)
                    {
                        case 0:
                            Environment.Exit(1);
                            break;
                        case 1:
                            RunTask1();
                            break;
                        case 2:
                            RunTask2();
                            break;
                        case 3:
                            RunTask3();
                            break;
                        case 4:
                            RunTask4();
                            break;
                        default:
                            correctInput = false;
                            break;
                    }
                }
                else
                {
                    correctInput = false;
                }

                if (!correctInput)
                {
                    Console.WriteLine("Input number is incorrect.");
                }

                Console.WriteLine("Press any key to show menu.");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Please select a task to demonstrate: ");
            Console.WriteLine("1: Write a function to find maximum product (multiplication) of two numbers in an array.");
            Console.WriteLine("2: Write a function that reverses the order of the words in a string.");
            Console.WriteLine("3: Implement a non-recursive function to perform a binary search on a sorted array of integers to find the index of a given integer.");
            Console.WriteLine("4: Implement a recursive version of the question #3.");
            Console.WriteLine("0: for exit.");
        }

        private static void RunTask1()
        {
            Console.WriteLine("Please input an array of integers. Elements to be delimeted with ',': ");
            var inputString = Console.ReadLine();

            int[] parsedInput;

            try
            {
                const char delimeter = ',';
                parsedInput = inputString
                    .Split(delimeter)
                    .Select(n => Convert.ToInt32(n))
                    .ToArray();
            }
            catch
            {
                Console.WriteLine("Input string cannot be parsed to an array of integers. Abort the task.");
                return;
            }
                        
            int? maxProd = null;
            var calc = new MaximumProductCalculator();
            try
            {
                maxProd = calc.GetMaximumProduct(parsedInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}.");
            }
            var resultMessage = "Maximum production: " + (maxProd != null ? maxProd.ToString()+"." : "no value.");
            Console.WriteLine(resultMessage);
        }

        private static void RunTask2()
        {
            Console.WriteLine("Please input a string. Words should be delimeted with space.");
            var inputString = Console.ReadLine();

            if(inputString.Length == 0)
            {
                Console.WriteLine("Input is empty. Abort the task.");
                return;
            }

            var calc = new StringReverser();
            try
            {
                var reversedString = calc.Reverse(inputString);
                Console.WriteLine($"Reversed: '{reversedString}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}.");
            }
        }

        private static void RunTask3()
        {
            RunTask3Or4(new BinarySearcherIterative());
        }

        private static void RunTask4()
        {
            RunTask3Or4(new BinarySearcherRecursive());
        }

        private static void RunTask3Or4(IBinarySearcher binarySearcher)
        {
            var array = new int[] { 1, 2, 4, 4, 4, 5, 6, 6, 8, 12, 123, 677 };
            Console.WriteLine($"Here is prepared sorted array: {String.Join(", ", array)}.");
            Console.WriteLine("Please input an integer which index should be found: ");
            var inputString = Console.ReadLine();
            int parsedInput;

            if (!Int32.TryParse(inputString, out parsedInput))
            {
                Console.WriteLine("Cannot parse input as integer. Abort the task.");
                return;
            }

            var calc = new BinarySearcherIterative();
            try
            {
                var index = binarySearcher.BinarySearch(array, parsedInput);
                if (index.HasValue)
                {
                    Console.WriteLine($"Index found: {index}.");
                }
                else
                {
                    Console.WriteLine("Element is not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}.");
            }
        }
    }
}
