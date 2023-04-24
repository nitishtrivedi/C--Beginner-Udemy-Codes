using System;
using Math = ConsoleApp.Math;
using Arrays = ConsoleApp.Arrays;
using ConsoleApp.Exercises;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declare the below if Methods from Methods Class needs to be run
            //Methods methods = new Methods();
            var ex = new Ex5();
            ex.LongestWord();
        }
    }

    class Methods
    {
        public void Summarizer()
        {
            Console.WriteLine("Enter a string to summarize it: ");
            var input = Console.ReadLine();

            Console.WriteLine("Enter the maximum length: ");
            var maxLength = Convert.ToInt32(Console.ReadLine());

            //Reading static method from Strings class that we created
            var summary = StringUtility.SummarizeText(input, maxLength);

            Console.WriteLine(summary);
        }
    }

}