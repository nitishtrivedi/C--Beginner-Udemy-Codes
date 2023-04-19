using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex3
    {

        #region Question 1
        /*
         * 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            - If no one likes your post, it doesn't display anything.
            - If only one person likes your post, it displays: [Friend's Name] likes your post.
            - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            Depending on the number of names provided, display a message based on the above pattern.
         */

        public void FaceBookExercise()
        {
            //Declare a list
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                //Main logic
                foreach(var name in input.Split(','))
                {
                    names.Add(name);
                }

            }


            //SWITCH CASE

            switch (names.Count)
            {
                //Logic 1 - If no one likes your post, it doesn't display anything.
                case 0:
                    Console.WriteLine("No Likes yet");
                    break;

                //Logic 2 - If only one person likes your post, it displays: [Friend's Name] likes your post.
                case 1:
                    foreach (var name in names)
                    {
                        Console.WriteLine("{0} liked your post", name);
                    }
                    break;


                //Logic 3 - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
                case 2:
                    // Create new array for storing names
                    var twoNames = new List<string>();
                    foreach (var name in names)
                    {
                        twoNames.Add(name);
                    }

                    Console.WriteLine("{0} and {1} liked your post.", twoNames[0], twoNames[1]);
                    break;

                //Logic 4 - - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
                case > 2:
                    // Create new array for storing names
                    var allNames = new List<string>();

                    //Add names in new list
                    foreach (var name in names)
                    {
                        allNames.Add(name);
                    }

                    //As we want to display two names and the count of the rest of the people, we substract two from the count and display the rest of the count
                    var count = (allNames.Count) - 2;

                    //Display the result
                    Console.WriteLine("{0}, {1} and {2} others liked your post.", allNames[0], allNames[1], count);
                    break;

            }

        }
        #endregion


        #region Question 2
        /*
         * 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console. COPIED
         */

        public void ReverseArray()
        {

            Console.Write("Enter your name: ");
            var input = Console.ReadLine().ToCharArray();

            //Reverse
            Array.Reverse(input);

            //Assign to new string
            var reserveName = new string(input);

            Console.WriteLine($"The reversed name is {reserveName}");


        }



        #endregion


        #region Question 3

        /*
         * 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */

        public void UniqueNumbers()
        {
            //Initialize an empty array
            var numbers = new int[5];

            //Logic
            for (var i = 0; i < 5; i++)
            {
                //Initialize duplicate flag
                bool isNotUnique = true;

                while (isNotUnique)
                {
                    Console.Write("Enter Unique Number: ");
                    var input = Convert.ToInt32(Console.ReadLine());

                    //Check if the entered number is present in the array. If present, display error
                    //IndexOf method compares the array with input, if unique, it returns -1
                    if(Array.IndexOf(numbers, input) != -1)
                    {
                        Console.WriteLine("Number already exists. Try again.");
                    }
                    else
                    {
                        numbers[i] = input;
                        isNotUnique = false;
                    }
                }
                                
            }
            //Sort the array to be displayed
            Array.Sort(numbers);

            //Display the Final output
            Console.Write("The Sorted Unique array is: ");
            foreach (var number in numbers)
            {
                Console.Write(number + ", ");
            }

        }

        #endregion


        #region Question 4
        /*
         * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
         */

        public void UniqueNumbers2()
        {
            //Initialize a list
            var numList = new List<int>();

            //Continuous input
            while (true)
            {
                Console.Write("Enter a number or Type Quit to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    int num = int.Parse(input);
                    if (!numList.Contains(num))
                    {
                        numList.Add(num);
                    }
                }
                                                
            }
            Console.WriteLine("Unique numbers entered are: ");

            foreach (var number in numList)
            {
                Console.Write(number + " , ");
            }

        }

        #endregion


        #region Question 5
        /*
         * 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
         */

        public void ListOfNumbers()
        {
            Console.WriteLine("Enter a list of comma separated numbers: ");
            
            while (true)
            {
                var input = Console.ReadLine();
                var numbers = input.Split(",");
                var numList = new List<int>();

                int count = numbers.Count();

                if(count < 5)
                {
                    Console.WriteLine("Invalid List. Please re-enter comma-separated numbers (list must include more than 5 numbers)");
                    continue;
                }
                else if (count >= 5)
                {
                    //Loop through input to add them in the numList
                    foreach (var number in numbers)
                    {
                        numList.Add(Convert.ToInt32(number));
                    }

                    //Sort the list
                    numList.Sort();

                    //Display 3 smallest numbers
                    Console.WriteLine("The Smallest 3 numbers are: ");
                    foreach (var number in numList.Take(3))
                    {
                        Console.Write(number + ", ");
                    }
                    break;
                }


            }
        }

        #endregion


    }
}
