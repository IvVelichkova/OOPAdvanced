using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            PrintCardRank();


        }
        public static void PrintAllCardsAndValue()
        {

            var sb = new StringBuilder();
            sb.AppendLine("Card Suits:");
            foreach (var name in Enum.GetValues(typeof(Cards)))
            {
                sb.AppendLine($"Ordinal value: {(int)name}; Name value: {name}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }

        public static void PrintCardRank()
        {
            var sb = new StringBuilder();


            sb.AppendLine("Card Ranks:");
            foreach (var name in Enum.GetValues(typeof(CardRank)))
            {
                sb.AppendLine($"Ordinal value: {(int)name}; Name value: {name}");
            }
            Console.WriteLine(sb.ToString().Trim());


        }
    }
}
