using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Exercises
{
    public class Ex1
    {
        #region Question 1 Exercise 1
        /*
         * 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
         * If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
         * (This logic is used a lot in applications where values entered into input boxes need to be validated.)
         */
        public void Q1_ValInval()
        {
            Console.WriteLine("Enter a number of your choice");

            var input = Console.ReadLine();

            var inputNumber = Convert.ToInt32(input);

            if(inputNumber >= 1 &&  inputNumber <= 10)
            {
                Console.WriteLine("Number is in the range");
            }
            else
            {
                Console.WriteLine("Number is out of range");
            }

            Console.ReadLine(); 

        }
        #endregion

        #region Question 2 Exercise 1
        /*
         * Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        public void Q2_BiggerNumber()
        {
            Console.WriteLine("Enter two numbers of your choice:");

            var num1 = Console.ReadLine();
            var newNum1 = Convert.ToDecimal(num1);
            Console.WriteLine("First Number: " + newNum1);
            var num2 = Console.ReadLine();
            var newNum2 = Convert.ToDecimal(num2);
            Console.WriteLine("Second Number: " + newNum2);

            if (newNum2 > newNum1)
            {
                Console.WriteLine("The bigger number is : " + newNum2);
            }
            else
            {
                Console.WriteLine("The bigger number is : " + newNum1);
            }
        }
        #endregion

        #region Question 3 Exercise 1
        /*
         * 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
         */
        public void Q3_BiggerNumber()
        {
            Console.WriteLine("Landscape or Potrait?");
            Console.WriteLine("Enter the width of the picture");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the picture");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The picture is Landscape Orientation");
            }
            else if (height == width) {
                Console.WriteLine("It is a square picture");
            }
            else
            {
                Console.WriteLine("The picture is Potrait Orientation");
            }
        }
        #endregion

        #region Question 4 Exercise 1
        /*
         * 4- Your job is to write a program for a speed camera. 
         * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
         * Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
         * If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. 
         * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
         * If the number of demerit points is above 12, the program should display License Suspended
         */

        public void Q4_SpeedCam()
        {
            Console.WriteLine("SPEED CAM");
            Console.WriteLine("ENTER THE SPEED LIMIT");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER THE SPEED OF THE CAR");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            //Demerit calculator
            var demeritPointLimit = 12;
            var demeritPoints = (carSpeed - speedLimit) / 5;


            //Condition
            if(carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                if (demeritPoints > demeritPointLimit)
                {
                    Console.WriteLine("LICENSE SUSPENDED....!!!!!!");
                }
                else
                {
                    Console.WriteLine("tHE NUMBER OF DEMERIT POINTS ARE {0}", demeritPoints);
                }
            }

        }

        #endregion
    }
}
