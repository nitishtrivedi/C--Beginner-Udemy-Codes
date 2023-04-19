using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Declared for RefValueTypes 2
    public class person
    {
        public int Age;
    }
    public class RefValueTypes
    {
        
        public void RefValueTypes1()
        {
            /* 
             * VALUE TYPES
             
             In value types, the value of var a will get copied to var b. Then, both act as independent variables. 
            Value changes in b, as shown in below example, will not affect the value of a.
             */


            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b:{1}", a, b)); //Output is a:10, b:11 

            /* 
             * REFERENCE TYPES (Class)
             In reference type, the value of array1 will be changed as per changes in value of array2. Here, the variables are dependant.
            var array1, when initialised, is stored in heap memory with values and memory address. The stack memory stores the address where the array is stored in heap. 
            Then the stack points to the memory location in heap.
            When we initialise array1 = array2, in stack, a new memory is allocated named array2 with the address pointing to the same array i.e. array1
            Hence, they are dependant as they point to same object.
             */

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0;
            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0])); // Output is array1: 0, array2: 0


        }

        public void RefValueTypes2()
        {
            //Value Type
            var number = 1;
            Increment(number);
            Console.WriteLine(number); //Output is 1, because int in INcrement method is value type.

            //Reference Type
            var person = new person() { Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age); //Output is 30. Reference Type
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(person person)
        {
            person.Age += 10;
        }

    }
}
