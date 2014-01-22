using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalToOrdinal
{
    class Program
    {
        static string[] ordSuffixList = new string[4] 
        {
            "st", "nd", "rd", "th"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(CardinalToOrdinal(4));
            Console.Write("\n\nPress any key to Exit... ");
            Console.ReadKey(true);
        }

        static string CardinalToOrdinal(int cardNum)
        {
            string numStr = cardNum.ToString();
            int numStrLen = numStr.Length;
            int lastTwoDigits = 0;

            if (numStr.Length > 1)
            {
                lastTwoDigits = int.Parse(numStr[numStrLen - 2].ToString() + numStr[numStrLen - 1].ToString());
            }
            else
            {
                lastTwoDigits = int.Parse(numStr[numStrLen - 1].ToString());
            }

            if (numStr.EndsWith("1") && lastTwoDigits != 11)
            {
                numStr += "st";
            }
            else if (numStr.EndsWith("2") && lastTwoDigits != 12)
            {
                numStr += "nd";
            }
            else if (numStr.EndsWith("3") && lastTwoDigits != 13)
            {
                numStr += "rd";
            }
            else
            {
                numStr += "th";
            }

            return numStr;
        }
    }
}
