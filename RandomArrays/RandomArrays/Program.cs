using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrays
{    
    class Program
    {
        static int randMin = 1;
        static int randMax = 100;
        static int arraySize = 50;
        static void Main(string[] args)
        {
            int[] randArray = FillArray(new int[arraySize]);

            Display(randArray);
            /* Display the sorted array */
            Console.WriteLine("******* Sorted Array *******");
            Array.Sort(randArray);
            Display(randArray);
            /* Exit message */
            Console.WriteLine("Press ENTER exit the application.");
            Console.ReadLine();
        }

        /* Method to populate an array with random numbers */
        static int[] FillArray(int[] arr)
        {
            Random rand = new Random();//Create a random to use
            /* Using the Length property in the loop */
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(randMin, randMax);
            }
            return arr;//Retrun the array
        }

        /* Method to display the contents of the array */
        static void Display(int[] arr)
        {
            /* Using the Length property in the loop */
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    
}
