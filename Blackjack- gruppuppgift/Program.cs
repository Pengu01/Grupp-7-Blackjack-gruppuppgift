using System;
using System.Collections.Generic;

namespace Blackjack__gruppuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            playercard player = new playercard();
            dealer dealer = new dealer();
            int ess;
            Console.WriteLine("Hej och välkommen till Black Jack");
            Console.Write("vänligen skriv in vad ess ska vara värt(1 eller 11):");
            ess= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bra, ess är nu värt" + ess);
            deck bj = new deck();
            Console.WriteLine("då kör vi");
            bool playing = true;
            while (playing)
            {
                    bj.deckAdd();
                    dealer.dealerdraw();
                    player.playerdraw();
                    bj.deckRemove();
            }
        }
    }
    
    class playercard
    {            
        deck bj = new deck();
        List<int> player = new List<int>();
        public void playerdraw()
        {
            player.Add(bj.draw());
        }
    }
    class dealer
    {
        deck bj = new deck();
        List<int> dealer = new List<int>();
        public void dealerdraw()
        {
            dealer.Add(bj.draw());
        }
    }
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