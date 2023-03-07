using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {

        private static Card[] pack;

        static Pack()
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

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            Random r = new Random();
            //Shuffles the pack based on the type of shuffle]
            if (typeOfShuffle == 1)
            {
                //Fisher-Yates shuffle
                for (int i = 51; i > 0; i--)
                {
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
                for (int counter = 0; counter < 5; counter++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        for (int j = 26; j < 52; j++)
                       {
                           tempPack.Add(pack[i]);
                           tempPack.Add(pack[j]);
                       } 
                    }
                }
                pack = tempPack.ToArray();
            }
            else
            {
                //Invalid shuffle type
                return false;
            }
            return true;

        }
        public static Card deal()
        {
            //Deals one card
            Card topCard = pack[0];
            pack = pack.Skip(1).ToArray();
            return topCard;

        }
        public static List<Card> dealCard(int amount)
        {
            List <Card> dealtCards = new List<Card>();
            //Deals the number of cards specified by 'amount'
            for (int i = 0; i < amount; i++)
            {
                Card tempCard = deal();
                dealtCards.Add(tempCard);
            }
            return dealtCards;
        }
    }
}
