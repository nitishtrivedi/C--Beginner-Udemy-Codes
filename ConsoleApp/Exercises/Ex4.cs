using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex4
    {
        /*
         * 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
         */

        public void Consecutive()
        {
            Console.Write("Enter a few numbers separated by Hyphen(-): ");
            var input = Console.ReadLine();

            var stringArray = input.Split('-');

            //Create list of integers
            var numList = new List<int>();

            foreach ( var item in stringArray )
            {
                numList.Add(Convert.ToInt32(item));
            }

            var flag = "";
            for (var i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i + 1] > numList[i] )
                {
                    flag = "c";
                }
                else if (numList[i + 1] < numList[i])
                {
                    flag = "nc";
                }
            }

            if (flag == "c")
            {
                Console.WriteLine("Consecutive Numbers");
            }
            else if (flag == "nc")
            {
                Console.WriteLine("Non Consecutive Numbers");
            }
        }
    }
}
