using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public void oneCardDeal(int typeOfShuffle)
        {
            Pack.addCards();
            Pack.shuffleCardPack(typeOfShuffle);
            Card oneCardDeal = Pack.deal();
            Console.WriteLine($"One Card deal, Shuffle type {typeOfShuffle}. Suit: {oneCardDeal.Suit} Value: {oneCardDeal.Value}");
        }

        public void multiCardDeal(int typeOfShuffle, int amount)
        {
            Pack.addCards();
            Pack.shuffleCardPack(typeOfShuffle);
            List<Card> cards = Pack.dealCard(amount);
            Console.WriteLine($"{amount} card deal, Shuffle type {typeOfShuffle}");
            foreach (Card card in cards)
            {
                Console.WriteLine($"Suit: {card.Suit} Value: {card.Value}");
            } 

        }
    }

}
