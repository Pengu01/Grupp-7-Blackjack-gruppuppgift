﻿using System;
using System.Collections.Generic;
/*
Class deck kommer ha metoderna draw, deckAdd och deckRemove. gör så att man kan resetta decken enkelt och dra kort som man vill
*/

{
    class Program
    {
        static void Main(string[] args)
        {
            int ess;
            Console.WriteLine("Hej och välkommen till Black Jack");
            Console.Write("vänligen skriv in vad ess ska vara värt(1 eller 11):");
            ess= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bra, ess är nu värt" + ess);
            Console.WriteLine("då kör vi");
            Console.WriteLine("Hello!");
        }
    }
    
    class AIcard
    {
        List<int> bot = new List<int>();
        public void botdeck()
        {
            int cardvalue = 0;
            int kortvärde = 0;
            for (int botkort = 0; botkort < 52; botkort++)
            {
                for (kortvärde = 0; kortvärde < 16;)
                {
                    kortvärde++;
                }

                if (cardvalue < 16)
                {
                    Console.WriteLine("jag tar ett kort");
                }

                if ( kortvärde == 16 || kortvärde < 16)
                {
                    Console.WriteLine("Jag står över");
                }
            }
        }
    }
    
    class playercard
    {
        List<int> player = new List<int>();
        public void playerdeck()
        {

        }
    }
    //E
    class deck
    {
        List<int> cards = new List<int>();
        public void deckAdd()
        {
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(i);
                }
            }
        }
        public int draw()
        {
            Random rnd = new Random();
            return cards[rnd.Next(0, cards.Count)];
        }
        public void deckRemove()
        {
            cards.Clear();
        }
        public void addEss(int ess)
        {
            for(int i = 0; i < 4; i++)
            {
                cards.Add(ess);
            }
        }
    }
}

 /*class Program
    {
        static void Main(string[] args)
        {
            const int GROUP_SIZE = 4;
            const int GROUP_AMOUNT = 8;

           string[] cardArray =
             {
             2♥, 2♦, 2♠, 2♣, 3♥, 3♦, 3♠, 3♣, 4♥, 4♦, 4♠, 4♣, 5♥, 5♦, 5♠, 5♣, 6♥, 6♦, 6♠, 6♣, 7♥, 7♦, 7♠, 7♣, 8♥, 8♦, 8♠, 8♣, 9♥, 9♦, 9♠, 9♣, 10♥, 10♦, 10♠, 10♣, Knekt♥, Knekt♦, Knekt♠, Knekt♣, Dam♥, Dam♦, Dam♠, Dam♣, Kung♥, Kung♦, Kung♠, Kung♣, Ess♥, Ess♦, Ess♠, Ess♣
            };

            List<string> cards = new List<string>();

            for (int i = 0; i < cardArray Length; i++)
            {
                cards.Add(cardArray[i]);

            }
          

            Random random = new Random();
            
            for (int i = 1; i < GROUP_AMOUNT + 1; i++)
            {
                Console.WriteLine("group" + i + ":");

                for (int j = 0; j < GROUP_SIZE; j++)
                {
                    if (students.Count == 0)
                    {
                        Console.WriteLine("finns inga kort kvar");
                        break;

                    }
                    int localValue = random.Next(0, cards.Count);
                    Console.WriteLine(cards[localValue]);

                    cards.RemoveAt(localValue);

                }
                Console.Write("\n");
            }
            Console.WriteLine("tryck på valfri tangent för att lämna");
            Console.ReadKey();
        }


    }
}
*/

/*
// När man väljer om Ess ska vara 1 eller 11
string Ess;

if (Console.ReadLine(Ess))
{
    Console.WriteLine("Vill du Ess ska vara 1 eller 11?");
    if (Console.ReadLine("1"))
    {
    //read string Ess sedan tar den och convert till int och tar Ess och då blir Essets värde 1
        Convert.ToInt32(string Ess);
        int Ess = 1;
    }
    else if (Console.ReadLine("11"))
    {
        Convert.ToInt32(string Ess);
        int Ess = 11;
    }
    Console.WriteLine(Ess)
}
//B
*/
