using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPower
{
    public class Card:IComparable<Card>
    {
        CardRank cardRank;
        Suit suitCard;
        
        public Card(string rank,string suit)
        {
           this. SuitCard = (Suit)Enum.Parse(typeof(Suit),suit);
            this.CardRanks = (CardRank)Enum.Parse(typeof(CardRank),rank);
           
        }

        public CardRank CardRanks
        {
            get { return this.cardRank; }
            set { this.cardRank = value; }
        }

        public Suit SuitCard
        {
            get
            {
                return this.suitCard; 
                
            }
            set { this.suitCard = value; }
        }

        public int Power
        {
            get { return (int) this.CardRanks + (int) this.SuitCard; }
            set { this.Power = value; }
        }

        public string Name
        {
            get { return $"{this.CardRanks} of {this.SuitCard}"; }
            set { this.Name = value; }
        }


        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {

            
            return
                $"Card name: {this.Name}; Card power: {this.Power}";
        }

        
    }
}
