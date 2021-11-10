using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            blackjack bj = new blackjack();
            while (true)
            {
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                bj.reset();
                bj.start();
                if (bj.checkBJ())
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Blackjack ez win");
                    continue;
                }
                bool drawing = true;
                while (drawing)
                {
                    Console.WriteLine(bj.playerValue());
                    if (!bj.checkPlayer())
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Bust");
                        break;
                    }
                    Console.WriteLine("Hit/Stand");
                    string answer = Console.ReadLine();
                    if (answer == "Hit")
                    {
                        bj.playerHit();
                    }
                    else if (answer == "Stand")
                    {
                        drawing = false;
                    }
                    else continue;
                }
                if (!bj.checkPlayer())
                {
                    continue;
                }
                bool dealer = true;
                while (dealer)
                {
                    if (bj.dealerValue() < 17)
                    {
                        bj.dealerHit();
                    }
                    else dealer = false;
                }
                if (!bj.checkDealer())
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Dealer bust! ez win");
                    continue;
                }
                if (bj.compare() == 0)
                {
                    Console.WriteLine("Tie");
                }
                else if (bj.compare() == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Win");
                }
                else if (bj.compare() == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Loss");
                }
            }
        }
    }
    class deck
    {
        Random rnd = new Random();
        List<int> cards = new List<int>();
        public void deckReset()
        {
            cards.Clear();
            for (int i = 2; i < 12; i++)
            {
                cards.Add(i);
                if (i == 10)
                {
                    for (int k = 0; k < 12; k++)
                    {
                        cards.Add(i);
                    }
                }
            }
        }
        public int deckDraw()
        {
            return cards[rnd.Next(0, cards.Count)];
        }
    }
    class blackjack  : deck
    {
        List<int> player = new List<int>();
        List<int> dealer = new List<int>();
        public void playerHit()
        {
            player.Add(deckDraw());
        }
        public void dealerHit()
        {
            dealer.Add(deckDraw());
        }
        public void start()
        {
            for(int i = 0; i < 2; i++)
            {
                player.Add(deckDraw());
                dealer.Add(deckDraw());
            }
        }
        public bool checkDealer()
        {
            int value = dealerValue();
            if (value > 21)
            {
                if (dealer.Remove(11))
                {
                    dealer.Add(1);
                    return true;
                }
                return false;
            }
            return true;
        }
        public bool checkPlayer()
        {
            int value = playerValue();
            if (value > 21)
            {
                if (player.Remove(11))
                {
                    player.Add(1);
                    return true;
                }
                return false;
            }
            return true;
        }
        public bool checkBJ()
        {
            int value = playerValue();
            if(value == 21)
            {
                return true;
            }
            return false;
        }
        public int playerValue()
        {
            int value = 0;
            for (int i = 0; i < player.Count; i++)
            {
                value += player[i];
            }
            return value;
        }
        public int dealerValue()
        {
            int value = 0;
            for (int i = 0; i < dealer.Count; i++)
            {
                value += dealer[i];
            }
            return value;
        }
        public void reset()
        {
            deckReset();
            player.Clear();
            dealer.Clear();
        }
        public int compare()
        {
            if (dealerValue() == playerValue())
            {
                return 0;
            }
            else if (dealerValue() < playerValue())
            {
                return 1;
            }
            else return 2;
        }
    }
}
