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

            //Convert items to integers and push to the list
            foreach ( var item in stringArray )
            {
                numList.Add(Convert.ToInt32(item));
            }

            //Checker flag
            var flag = "";

            //Comparison logic
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

            //Output based on flag set
            if (flag == "c")
            {
                Console.WriteLine("Consecutive Numbers");
            }
            else if (flag == "nc")
            {
                Console.WriteLine("Non Consecutive Numbers");
            }
        }

        /*
         * 2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. COPIED 100%
         */

        public void Duplicate()
        {
            Console.Write("Enter numbers separated by hyphen: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            string[] numbers = input.Split('-');
            bool hasDuplicate = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (hasDuplicate)
                {
                    Console.WriteLine("Duplicates Detected.");
                    break;
                }
            }
        }


        /*
        * 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
        */

        public void DateAndTime()
        {
            Console.Write("Enter a Time in HH:MM format (i.e. 19:00): ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            string[] numbers = input.Split(":");

            int hh = Convert.ToInt32(numbers[0]);
            int mm = Convert.ToInt32(numbers[1]);

            bool hoursValidator = (hh >= 00 && hh < 24);
            bool minsValidator = (mm >= 00 && mm <= 59);


            if (hoursValidator && minsValidator)
            {
                Console.WriteLine("OK");
            } 
            else
            {
                Console.WriteLine("Invalid Time");
            }
            

        }


        /*
         * 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
         */

        public void NumberOfStudents()
        {
            Console.Write("Please enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided");
            }

            string[] inputWords = input.Split(" ");

            //Main working logic - COPIED
            string pascal = "";

            foreach(string word in inputWords)
            {
                if (word.Length > 0)
                {
                    pascal += char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
            }
            Console.WriteLine("The PascalCase output is " + pascal);

        }


        /*
         *  Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
         */

        public void Vowels()
        {
            Console.Write("Enter an English word of your choice: ");
            var input = Console.ReadLine();

            //Convert input word in an array
            var wordArray = input.ToArray();

            //initialize vowel counter
            int vowelCounter = 0;

            //Logic
            foreach (char word in wordArray)
            {
                if (word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u')
                {
                    vowelCounter++;
                }
            }


            Console.WriteLine("The word has {0} vowels", vowelCounter);
        }


    }

}
