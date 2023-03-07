using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {
            Testing test = new Testing();
            test.shuffleTest();
            List<Card> shuffledCards = Pack.dealCard(52);
            foreach (Card card in shuffledCards)
            {
                Console.WriteLine(card.Suit);
            }
        }

    }
}
