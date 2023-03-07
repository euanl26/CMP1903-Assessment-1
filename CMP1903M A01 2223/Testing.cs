using System;
namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public void shuffleTest(int typeOfShuffle)
        {
            Pack.shuffleCardPack(typeOfShuffle);
            Card oneCardDeal = Pack.deal();
            Console.WriteLine($"One Card deal, Shuffle type {typeOfShuffle}. Suit: {oneCardDeal.Suit} Value: {oneCardDeal.Value}");
        }
    }

}
