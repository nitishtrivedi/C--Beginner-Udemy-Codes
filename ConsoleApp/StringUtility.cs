using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                //Logic
                var words = text.Split(" ");
                var totalChars = 0; //COunter for summary mechanism
                var summaryList = new List<string>();

                foreach (var word in words)
                {
                    summaryList.Add(word);
                    totalChars += word.Length + 1;
                    if (totalChars > maxLength)
                    {
                        break;
                    }
                }
                var summary = String.Join(" ", summaryList) + "...";
                return summary;
            }
        }
    }
}
