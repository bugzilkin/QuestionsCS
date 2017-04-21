# QuestionsCS

It's a repository with answers for programming skills testing.

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Questions are the following:

1.    Write a function to find maximum product (multiplication) of two numbers in an array.
For example: array = [5, 2, 8, 14], max product result = 14 * 8 = 112.

2.    Write a function that reverses the order of the words in a string.
For example, your function should transform the string "Do or do not, there is no try." to "try.no is there not, do or Do".
Assume that all words are space delimited and treat punctuation the same as letters.

3.    Implement a non-recursive function to perform a binary search on a sorted array of integers to find the index of a given integer.
Comment on the efficiency of this search, and compare it with other search methods.

4.    Implement a recursive version of the question #3 and explain the pros and cons.

5.    What are virtual methods? Why are they useful? Please provide an example.

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Answers are the following:

1. Please see MaximumProductCalculator class, GetMaximumProduct() method.

2. Please see StringReverser class, Reverse() method. Standard Frameworks methods String.Split(), Array.Reverse(), String.Join() are used.

3. Please see classes BinarySearcherIterative and BinarySearcherBase.
Microsoft .NET Framework provides build-in methods for binary search, e.g. BinarySearch<T>(T[] array, T value).
But I think to use this method is to easy for testing task and I implemented my own.

Here are answers on task questions:
Binary search can be used only in case of sorted data. Initial time to sort the data sometimes is comparable to use linear search.
Complexity of this algorithm is O(log2(n)). If number of elements is not big, it's worth to use linear search.

Linear search is very simple to implement. It's practical for small arrays or for not ordered data. Complexity of this algorithm is O(n).
If number of elements is big and one needs to find many given elements in the same data, binary search can be more effective.

Interpolation search is affective for big amounts of data and when data is uniformly distributed. Complexity of this algorithm is O(log2(log2(n))).
If data is distributed in such way that values increase exponentially, the performance of the algorithm can be O(n).
Interpolation search can be used not only in case of sorted data: if an approximating function for data distribution can be calculated,
one can use interpolation search.

Also there are several other algorithms/methods for search: Exponential search, Ternary search, Golden-section search.
Worth to mention Hash tables - widely used data structure for data storing, searching, manipulation. 

4. Please see BinarySearcherRecursive and BinarySearcherBase classes. IBinarySearcher interface was introduced to use two impelmetations
of binary search in main Program class. Recursive method can throw StackOverflow exception if search process is very long.
Also in some papers it's stated that recursive implementation of an algorithm in most of cases is slower than implementation with iterations.
For someone this method seems to be easier to implement and understand, but it's subjective.

5. Virtual methods help to use one of the OOP principles - polymorphism. Base classes may define and implement virtual methods,
and derived classes can override them, which means they provide their own definition and implementation.
CLR defines in run-time what actual implementation of the method to be used: for virtual methods it's the most derived implementation.
For example, virual methods are useful for "Template method" design pattern implementation.
It's very important to understand the difference between overriding virtual methods and hiding methods with "new" keyword in C#. 
