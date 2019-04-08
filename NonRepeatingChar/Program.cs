using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("a"));
            Console.WriteLine(FirstNonRepeatingLetter("stress"));
            Console.WriteLine(FirstNonRepeatingLetter("moonmen"));
            Console.ReadKey();
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var charArray = s.ToCharArray();
            string firstNonRepeatingLetter = "";
            var grouped = s.ToCharArray().GroupBy(x => x);
            for (int i = 0; i < charArray.Length; i++)
            {
                var currentChar = charArray[i];
                var occurences = s.Count(x => x.ToString().ToLower() == currentChar.ToString().ToLower());
                if (occurences == 1)
                {
                    firstNonRepeatingLetter = currentChar.ToString();
                    break;
                }
            }

            return firstNonRepeatingLetter;
        }
    }
}
