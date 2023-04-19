using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex3
    {
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

            //Logic 1 - If no one likes your post, it doesn't display anything.
            if (names.Count == 0)
            {
                Console.WriteLine("No Likes yet");
            }

            //Logic 2 - If only one person likes your post, it displays: [Friend's Name] likes your post.
            if (names.Count == 1)
            {
                foreach (var name in names)
                {
                    Console.WriteLine("{0} liked your post", name);
                }
            }

            //Logic 3 - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            if (names.Count == 2)
            {
                // Create new array for storing names
                var twoNames = new List<string>();
                foreach (var name in names)
                {
                    twoNames.Add(name);
                }

                Console.WriteLine("{0} and {1} liked your post." , twoNames[0], twoNames[1]);
            }

            //Logic 4 - - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            if (names.Count > 2)
            {
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
            }



        }



    }
}
