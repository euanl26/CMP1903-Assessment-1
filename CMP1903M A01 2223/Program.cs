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

            test.oneCardDeal(1);
            test.oneCardDeal(2);
            test.oneCardDeal(3);
            Console.WriteLine("");
            test.multiCardDeal(1, 5);
            test.multiCardDeal(2, 5);
            test.multiCardDeal(3, 5);
        }

    }
}
