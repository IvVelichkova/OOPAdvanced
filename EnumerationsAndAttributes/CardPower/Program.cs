using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPower
{
    class Program
    {
        static void Main(string[] args)
        {
            ComprareCards();

        }
        
        private static void ComprareCards()
        {
            Card cardfirst = CreateCard();
            Card cardSecond = CreateCard();
            if (cardfirst.Power.CompareTo(cardSecond.Power) >0)
            {
                Console.WriteLine(cardfirst);
            }
            else
            {
                Console.WriteLine(cardSecond);
            }
        }
        
        private static Card CreateCard()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card card = new Card(rank, suit);
            return card;
        }
    }
}
