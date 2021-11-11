using System;
using System.Collections.Generic;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any to start");
            blackjack bj = new blackjack();
            while (true)
            {
                Console.ReadKey();
                Console.ResetColor();
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
                    if (!bj.checkPlayer())
                    {
                        Console.WriteLine("You got: " + bj.playerValue());
                        bj.printCards();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Bust");
                        break;
                    }
                    if (bj.playerA())
                    {
                        int tempValue = bj.playerValue() - 10;
                        Console.WriteLine("You got: " + bj.playerValue() + "/" + tempValue);
                        bj.printCards();
                    }
                    else if (bj.checkPlayer() && !bj.playerA())
                    {
                        Console.WriteLine("You got: " + bj.playerValue());
                        bj.printCards();
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
                    Console.WriteLine("Dealer got: " + bj.dealerValue());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Dealer bust! ez win");
                    continue;
                }
                if (bj.compare() == 0)
                {
                    Console.WriteLine("Dealer got: " + bj.dealerValue());
                    Console.WriteLine("Tie");
                }
                else if (bj.compare() == 1)
                {
                    Console.WriteLine("Dealer got: " + bj.dealerValue());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Win");
                }
                else if (bj.compare() == 2)
                {
                    Console.WriteLine("Dealer got: " + bj.dealerValue());
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
        List<string> special = new List<string>();
        public void deckReset()
        {
            cards.Clear();
            for (int i = 2; i < 12; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    cards.Add(i);
                    if (i == 10)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            cards.Add(i);
                        }
                    }
                }
            }
        }
        public int deckDraw()
        {
            int value = rnd.Next(0, cards.Count-1);
            int cardValue = cards[value];
            cards.RemoveAt(value);
            if (cardValue == 10)
            {
                switch (rnd.Next(0,4))
                {
                    case 0:
                        special.Add("10♦ ");
                        break;
                    case 1:
                        special.Add("Jack♦ ");
                        break;
                    case 2:
                        special.Add("Queen♦ ");
                        break;
                    case 3:
                        special.Add("King♦ ");
                        break;
                }
            }
            return cardValue;
        }
        public string tenValue(int value)
        {
            return special[value];
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
        public bool playerA()
        {
            return player.Contains(11);
        }
        public void printCards()
        {
            int temp = 0;
            for(int i = 0; i < player.Count; i++)
            {
                switch(player[i])
                {
                    case 1:
                        Console.Write("Ace♦ ");
                        break;
                    case 2:
                        Console.Write("2♦ ");
                        break;
                    case 3:
                        Console.Write("3♦ ");
                        break;
                    case 4:
                        Console.Write("4♦ ");
                        break;
                    case 5:
                        Console.Write("5♦ ");
                        break;
                    case 6:
                        Console.Write("6♦ ");
                        break;
                    case 7:
                        Console.Write("7♦ ");
                        break;
                    case 8:
                        Console.Write("8♦ ");
                        break;
                    case 9:
                        Console.Write("9♦ ");
                        break;
                    case 10:
                        Console.Write(tenValue(temp));
                        temp++;
                        break;
                    case 11:
                        Console.Write("Ace♦ ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
