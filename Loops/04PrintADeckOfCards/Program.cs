using System;

    class Program
    {
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] colors = { "♠", "♥", "♦", "♣" };
            foreach (var card in cards)
            {
                foreach (var color in colors)
                {
                    Console.Write(card);
                    Console.Write(color + "");
                }
            }

        }
    }
