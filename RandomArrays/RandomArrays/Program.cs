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
        }
    }
}
