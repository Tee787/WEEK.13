﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string array with 3 elements having the same value.
            String[] strings = { "the", "quick", "brown", "fox", "jumps",
                            "over", "the", "lazy", "dog", "in", "the",
                            "barn" };

            // Display the elements of the array.
            Console.WriteLine("The array contains the following values:");
            for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i++)
                Console.WriteLine("   [{0,2}]: {1}", i, strings[i]);

            // Search for the first occurrence of the duplicated value.
            String searchString = "the";
            int index = Array.IndexOf(strings, searchString);
            Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.",
                              searchString, index);

            // Search for the first occurrence of the duplicated value in the last section of the array.
            index = Array.IndexOf(strings, searchString, 4);
            Console.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.",
                              searchString, index);

            // Search for the first occurrence of the duplicated value in a section of the array.
            int position = index + 1;
            index = Array.IndexOf(strings, searchString, position, strings.GetUpperBound(0) - position + 1);
            Console.WriteLine("The first occurrence of \"{0}\" between index {1} and index {2} is at index {3}.",
                              searchString, position, strings.GetUpperBound(0), index);
        }
    }
}
