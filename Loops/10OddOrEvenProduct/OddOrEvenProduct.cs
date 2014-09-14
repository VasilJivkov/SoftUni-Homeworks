using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitedNumbers = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < splitedNumbers.Length; i++)
            {
                int tempNumber = int.Parse(splitedNumbers[i]);
                bool isOdd = (i + 1) % 2 != 0;
                bool isEven = (i + 1) % 2 == 0;

                if (isOdd)
                {
                    oddProduct *= tempNumber;
                }
                if (isEven)
                {
                    evenProduct *= tempNumber;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("The product is {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Odd product is {0}", oddProduct);
                Console.WriteLine("Even product is {0}", evenProduct);
            }
        }
    }
}
