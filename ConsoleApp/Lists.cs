using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Lists
    {
        //SYNTAX
        //var numbers = new List<int>();

        //AVAILABLE METHODS
        /*
         * Add(), - Add object to the list
         * AddRange(), - To add list of objects
         * Remove(), - to remove one object from list
         * RemoveAt(), - to remove object at the given index
         * IndexOf(), - to get the index of a given object
         * Contains(), - tells us if list has the given object
         * Count() - count of objects
         */
        public void ListsMethod()
        {
            var numbers = new List<int>() { 1, 2, 3, 4};

            //ADD METHOD
            numbers.Add(1);
            Console.WriteLine("Add() Method Output: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //ADD RANGE METHOD
            numbers.AddRange(new int[3] {5, 6, 7});
            Console.WriteLine("AddRange() Method Output: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            
            //INDEX OF METHOD
            Console.WriteLine("IndexOf() Method Output: " + numbers.IndexOf(1));
            Console.WriteLine("LastIndexOf() Method Output: " + numbers.LastIndexOf(1));

            //COUNT METHOD
            Console.WriteLine("Count() Method: " + numbers.Count);

            //REMOVE METHOD
            numbers.Remove(1);
            Console.WriteLine("Remove() Method:");

            foreach(var number in numbers)
            {
                //Console.WriteLine(number);
            }

            //remove all 1s in the list

            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }


            //CLEAR METHOD
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
