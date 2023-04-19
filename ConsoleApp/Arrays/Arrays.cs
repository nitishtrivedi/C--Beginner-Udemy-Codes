using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Arrays
{
    public class Arrays
    {
        public int[] number = new int[3];
        public bool[] flags = new bool[3];

        //Using Object Init Syntax
        public string[] names = new string[6] {"Nitish", "Deepa" , "Ashwin", "Vidhi", "Papu", "Ivy"};

        public void ArraysNumberMethod()
        {
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
        }

        public void ArraysFlagsMethod()
        {
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
        }

        public void SingleDimensionalArrays()
        {
            //Single Dimensional Array
            var singleDimension = new[] { 1, 2, 3, 4, 7, 6, 8, 5, 9 };

            //Length of the array
            Console.WriteLine("Length of this array is: " + singleDimension.Length);

            //IndexOf Method
            var index = Array.IndexOf(singleDimension, 7);
            Console.WriteLine("The index of 7 is " + index);


            //Clear Method - Setting the value to 0 for numbers, FALSE for type Bool and null for type string
            Array.Clear(singleDimension, 0, 2); //Args are 1: Array, 2: Starting index, 3: Length
            Console.WriteLine("Effect of Clear() Method");

            foreach(var n in  singleDimension)
            {
                Console.WriteLine(n);
            }

            //Copy Method - Copy required number of vars from array to a new array
            var newArray = new int[3];
            Array.Copy(singleDimension, newArray, 3);

            Console.WriteLine("Effect of Copy() Method");
            foreach(var n in newArray)
            {
                Console.WriteLine(n);
            }

            //Sort Method - Displays array in sorted way i.e. Ascending order 0-9 or a-z
            Array.Sort(singleDimension);
            Console.WriteLine("Effect of Sort() Method");

            foreach(var n in singleDimension)
            {
                Console.WriteLine(n);
            }

            //Reverse method - Displays array in reverse - also arranges them in descending order
            Array.Reverse(singleDimension);
            Console.WriteLine("Effect of Reverse() method");

            foreach (var n in singleDimension)
            {
                Console.WriteLine(n);
            }

        }

    }
}
