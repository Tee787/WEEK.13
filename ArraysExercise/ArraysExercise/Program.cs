using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    internal class Program
    {
        public static int randMin = 1;
        public static int randMax = 100;
        public static int arraySize = 50;

        public static Array array { get; private set; }

        private static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("******************Array Exercise****************");
            Console.WriteLine("************************************************");

            int[] randArray = FillArray(new int[arraySize]);
           
            
            Display(randArray);
           
            Array.Sort(randArray);

            Display(randArray);

            IndexArray(randArray);



            Console.WriteLine("Press ENTER exit the application.");
            Console.ReadLine();
        }

        private static int[] FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(randMin, randMax);
            }
            return arr;
        }

        private static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private static int IndexArray(int[] index)
        {
            int index20 = Array.IndexOf(array, 45);
            return Index20;
        }

    }
    //class ArrayIndex
    //{
    //    public static int index;
    //    private static Array array;

    //    static int IndexArray()
    //    {
    //        int index33 = Array.IndexOf(array, 45);
    //        return index33;
    //    }
    //}

}
