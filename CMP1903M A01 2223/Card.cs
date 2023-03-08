using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4

        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int _Value, int _Suit)
        {
            if (_Value < 1 || _Value > 13)
            {
                Console.WriteLine("Out of bounds, value must be between 1 and 13.");
            }

            if (_Suit < 1 || _Suit > 4)
            {
                Console.WriteLine("Out of bounds, suit must be between 1 and 4.");
            }

            Value = _Value;
            Suit = _Suit;
        }
    }
}
