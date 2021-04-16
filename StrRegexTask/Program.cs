using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



namespace StrRegexTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> strFormat = new List<string>();
            Console.WriteLine("Enter a number of lines to be read: ");
            int num = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < num; i++)
            {
                Console.Write($"{i + 1}\n");
                string inputStr = Console.ReadLine();
                // Regex inputStrRegex  = new Regex(@"\w+\S[^//]");
                // MatchCollection result = inputStrRegex.Matches(inputStr);
                // string newre = (string)result;
                //string result = inputStrRegex.Match(inputStrRegex(inputStr));

                string[] inputPieces = inputStr.Split(new char[]);
                strFormat.Add(inputPieces[i]);
            }

            foreach (var item in strFormat)
            {
                Console.Write(item);
            }

        }
    }
}
