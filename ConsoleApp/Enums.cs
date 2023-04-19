using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Declare enum when you have multiple constants.
    //Instead declaring multiple constants, declare Enum

    //Declare Enums at namespace level

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Enums
    {
        public void EnumMethods()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //Convert Enum to int

            //implementing enum as a cast
            var methodId = 3; //Data received from somewhere else
            Console.WriteLine((ShippingMethod)methodId); //Convert int to Enum

            //Convert Enum to String
            Console.WriteLine(method.ToString());

            //Convert string to Enum
            var methodName = "Express string";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); 
            //Parse is used to convert the string to some other data type
            //Enum.Parse return type is object, hence we need to cast the object to target i.e. ShippingMethod
        }
    }
}
