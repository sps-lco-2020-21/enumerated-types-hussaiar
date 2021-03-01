using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumLibrary;   // this uses the enumlibrary namespace.

namespace EnumConsole
{
    public enum Cards
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum Suits
    {
        Hearts = 1,
        Diamonds = 2,
        Spades = 3,
        Clubs = 4
    }
    class Card
    {
        Suits _suit;
        Cards _card;
        string _TwoLetters;
        public Card(Suits s, Cards c)   // this is a constructor which allows you to pass inputs into the class.
        {
            _suit = s;
            _card = c;
        }

        public Card(string s)
        {
            _TwoLetters = s;   // allows user to input 2 letters for Question 4B.
        }
        public Suits OutputSuit()
        {
            return(_suit);
        }
        public Cards OutputCard()
        {
            return (_card);
        }

    }
        
     







    class Program
    {
        static void Main(string[] args)
        {
            List<Cards> TheCards = new List<Cards> {Cards.Two, Cards.Two, Cards.Three, Cards.Four,Cards.Jack, Cards.Four, Cards.Five, Cards.Six,Cards.Seven  }; // list of the cards referenced through the enum
            Card Card1 = new Card(Suits.Hearts, Cards.Jack);
            
            

            Console.ReadKey();
        }


        static void LongestRun(List<Cards> TheCards)
        {
            int RunLength=1;
            List<int> RunLengths = new List<int> { };
            List<int> NumericalOfCards = new List<int> { };
            foreach(Cards x in TheCards)
            {
                NumericalOfCards.Add((int)x);    // converts the list passed in into a list of integers which reference the corresponding values in the enum.
            }
            int LastCard = 0;
            foreach (int y in NumericalOfCards)
            {
              

                if (y== LastCard+1)
                {
                    RunLength++;
                }
                else
                {
                    RunLengths.Add(RunLength);
                    RunLength = 1;
                }
                
                LastCard = y;

            }
            RunLengths.Add(RunLength);
            Console.WriteLine("The longest run is " + RunLengths.Max());
        }




        
    }
}
