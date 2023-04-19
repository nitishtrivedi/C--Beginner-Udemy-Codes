using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex2
    {
        /*
         * 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
         */

        public void DivByThree()
        {
            var counter = 0; //INitialise counter

            for(var i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    counter++; // Increment counter
                }
            }
            Console.WriteLine("The count is: " + counter);
        }


        /*
         * 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
         */

        public void EnterAnumber()
        {
            //Initialise Sum of all numbers
            var sum = 0;

            //LOOP
            while (true)
            {
                Console.Write("Enter a Number(Press ok to Exit): ");
                var input = Console.ReadLine();

                if(input.ToLower() == "ok")
                {
                    break;
                }
                sum+= Convert.ToInt32(input);
            }

            Console.WriteLine("The Sum of all numbers is: {0}", sum);
        }

        /*
         * 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */

        public void Factorial()
        {
            Console.Write("Enter a number to display its factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (var i = input; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial {0}! is: {1}", input, factorial);
        }

        /*
         * 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         * COPIED
         */

        public void RandomExercise()
        {
            //Initialise Random Object
            var random = new Random();

            //Generate Random number between range
            var number = random.Next(1, 10);
            //Console.WriteLine(number);

            //Operation logic
            for(var i = 3; i >= 0; i--)
            {
                Console.Write("Enter a number to guess: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("You guessed it right. The correct number was {0}", number);
                    return;
                }
                else
                {
                    Console.WriteLine("Oops. Wrong guess. Please try again. You have {0} attempts.", i);
                }
            }
            Console.WriteLine("Sorry. You have exhausted maximum number of attempts. The correct number was {0}", number);
        }


        /*
         * 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         * COPIED
         */

        public void LargestNumber()
        {
            //Take user input
            Console.Write("Enter numbers of your choice, separated by a Comma: ");
            var input = Console.ReadLine();

            //Create an array of inputs
            string[] inpputArrayString = input.Split(",");

            //Convert each string in array to number
            double[] inputNumbers = new double[inpputArrayString.Length];

            for(var i = 0; i < inpputArrayString.Length; i++)
            {
                inputNumbers[i] = double.Parse(inpputArrayString[i]);
            }

            //Find Largest number in the array
            double max = inputNumbers[0];
            for(var i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] > max)
                {
                    max = inputNumbers[i];
                }
            }
            Console.WriteLine("The largest number is {0}", max);
        }

    }
}
