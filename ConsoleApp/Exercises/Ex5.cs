using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex5
    {
        /*
         * 1- Write a program that reads a text file and displays the number of words.
         */

        public void ReadFiles()
        {
            var path = @"E:\MY DEVELOPMENT WORK\VS Apps\TextFile.txt";

            var file = File.ReadAllLines(path); // Returns an array with first line being at index 0 and so on for each line

            int mainCounter = 0; // Main counter which counts words from multiple lines
            int wordCounter = 0; // Counts word in each line.

            //Main Logic
            for (var i = 0; i < file.Length; i++)
            {
                //Convert each line to string, and each word to wordArray
                var fileString = file[i].ToString();

                //each word to wordArray
                var wordArray = fileString.Split(' ');

                //Update wordCounter
                foreach (var word in wordArray)
                {
                    wordCounter++;
                }

                //Update main counter
                mainCounter = wordCounter;
            }

            Console.WriteLine("This file has {0} words", mainCounter);

        }


        /*
         * 2- Write a program that reads a text file and displays the longest word in the file.
         */

        public void LongestWord()
        {
            var path = @"E:\MY DEVELOPMENT WORK\VS Apps\TextFile.txt";

            var file = File.ReadAllLines(path); // Returns an array with first line being at index 0 and so on for each line

            var mainArray = new List<string>(); //  Store all words in each sentence in one single array

           for (var i = 0; i < file.Length; i++)
           {
                //Convert each line to string, and each word to wordArray
                var fileString = file[i].ToString();

                //each word to wordArray
                var wordArray = fileString.Split(' ');

                foreach(var word in wordArray)
                {
                    mainArray.Add(word); // Append each word in main array
                }
           }

            int wordLength = 0; // Var to track the length of word
            string longestWord = ""; //Var to store the longest word

            foreach (var word in mainArray)
            {
                if (word.Length > wordLength) //Logic to calculate longest word
                {
                    wordLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("The longest word in the file is " + longestWord);
        }
    }
}
