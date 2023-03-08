using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        //Array to hold the deck of cards
        private static Card[] pack;

        //Method to initialise the pack of cards and add each of the 52 cards.
        public static void addCards()
        {
            pack = new Card[52];
            int index = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    pack[index]= new Card(value, suit);
                    index++;
                }
            }
        }

        //Method to shuffle the pack of cards based on the type of shuffle specified.
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Ensures one complete pack of cards is used.
            if (pack.Length != 52)
            {
                Console.WriteLine("The pack of cards is incomplete or there is more than one pack. Please try again.");
            }

            Random r = new Random();
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                //Fisher-Yates shuffle
                for (int i = pack.Length-1; i > 0; i--)
                {
                    //Picks a random card from the pack to swap with the last card in the pack.
                    int j = r.Next(i + 1);
                    Card lastValue = pack[i];
                    pack[i] = pack[j];
                    pack[j] = lastValue;
                }
            }
            else if (typeOfShuffle == 2)
            {
                //Riffle shuffle
                List<Card> tempPack = new List<Card>();
                //Interleave the top and bottom halves of the deck.
                for (int i = 0; i < 26; i++)
                    {
                       for (int j = 26; j < 52; j++)
                       {
                           tempPack.Add(pack[i]);
                           tempPack.Add(pack[j]);
                       } 
                    }
                //Repeat the interleaving process ten times.
                for (int counter = 0; counter < 10; counter++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        for (int j = 26; j < 52; j++)
                        {
                            tempPack.Add(tempPack[i]);
                            tempPack.Add(tempPack[j]);
                        }
                    }
                }
                //Update the pack with the new shuffled pack.
                pack = tempPack.ToArray();
            }
            else if (typeOfShuffle == 3)
            {
                return false;
            }
            else
            {
                Console.WriteLine("An invalid shuffle type was chosen and as a result the pack was not shuffled.");
                return false;
            }
            return true;

        }
        //Method to deal one card from the top of the pack.
        public static Card deal()
        {
            //Deals one card
            Card topCard = pack[0];
            pack = pack.Skip(1).ToArray();
            return topCard;

        }
        //Method to deal multiple cards from the pack, specified by "amount".
        public static List<Card> dealCard(int amount)
        {
            //Initalises the list for the dealt cards.
            List <Card> dealtCards = new List<Card>();

            for (int i = 0; i < amount; i++)
            {
                Card tempCard = deal();
                dealtCards.Add(tempCard);
            }
            return dealtCards;
        }
    }
}
