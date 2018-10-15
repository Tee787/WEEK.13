using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("********************Task 1*******************");
            Console.WriteLine("*********************************************");

            string[] name = new String[5];

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Please enter a name to the array: ");
                name[i] = Console.ReadLine();
            }

            //Console.WriteLine("*********************************************");
            //Console.WriteLine("********************Task 2*******************");
            //Console.WriteLine("*********************************************");

            //int[] nums = new int[10];

            //Console.WriteLine("Enter");


            //Practise method

            //int[] nums = { 20, 16, 36, 88, 4, 56, 90, 42, 51, 77,
            //                };
        }
    }
}
