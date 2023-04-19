using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Strings
    {
        public void StringsMethod()
        {
            var firstName = "Nitish";
            var lastName = "Trivedi";

            var fullName = firstName+ " " + lastName;

            //String Methods

            //String.Format
            var myFullName = string.Format("My name is {0} {1}",firstName, lastName);

            //String.Join
            var names = new string[3] { "Chinu", "Papu", "Ivy" };
            var formattedNames = string.Join(", ", names);

            //Verbatim Strings
            var text = "Hi Nitish \nLook into the following Paths \nc:\\folder1\\folder2 \nc:\\folder3\\folder4"; //Normal method without Verbatim
            var verbatimText = @"Hi Nitish
                                Look into the following Paths
                                c:\folder1\folder2
                                c:\folder3\folder4";

            Console.WriteLine(verbatimText);



        }
    }
}
