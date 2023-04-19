using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public enum Seasons
    {
        Summer,
        Winter,
        Rainy
    }
    public class Season
    {
        public void SeasonMethod()
        {
            var season = Seasons.Winter;

            switch (season)
            {
                case Seasons.Summer:
                    Console.WriteLine("It is Summertime");
                    break;
                //case Seasons.Winter:
                //    Console.WriteLine("Its cold and chilly");
                //    break;
                //case Seasons.Rainy:
                //    Console.WriteLine("Its Raining");
                //    break;
                case Seasons.Rainy:
                case Seasons.Winter:
                    Console.WriteLine("Promotion example");
                    break;
                default:
                    Console.WriteLine("Default Case");
                    break;
            }
        }
    }
}
