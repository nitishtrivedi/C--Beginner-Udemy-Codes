using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Loops
    {
        public void ForLoops()
        {
            //Display Even Numbers
            for (var i = 1; i <= 10; i++)
            {
                if(i%2  == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Display even numbers in reverse
            for (var i = 10; i >=1;  i--)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ForEachLoops()
        {
            //Task using forLoop
            var name = "Nitish Trivedi";

            for (var i = 0; i<name.Length; i++)
            {
                //Console.WriteLine(name[i]);
            }

            //Same using ForEach loop
            foreach(var chars in name)
            {
                //Console.WriteLine(chars);
            }

            //Main Program
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var num in numbers)
            {
                //Console.WriteLine(num);
            }
        }

        public void WhileLoops()
        {
            while (true)
            {
                Console.Write("Please type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@ECHO: " + input);
                    continue;
                }
                break;
            }
        }

        public void RandomMethod()
        {
            //Generate a random string
            var random = new Random();

            //Decide password length
            const int pwdLen = 10;

            //Create buffer array to store random chars
            var buffer = new char[pwdLen];

            //Loop
            for (var i = 0; i < pwdLen; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            //store buffer in new string
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
