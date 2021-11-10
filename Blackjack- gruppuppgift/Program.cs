using System;

namespace Blackjack__gruppuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Du får välja vad ess är värt
            int ess;
            //du kan ha max 11 kort på handen, om du har otur, innan du når till värdet 21
            int spelarekort1=0;
            int spelarekort2=0;
            int spelarekort3=0;
            int spelarekort4=0;//4
            int spelarekort5=0;
            int spelarekort6=0;
            int spelarekort7=0;
            int spelarekort8=0;//12
            int spelarekort9=0;
            int spelarekort10=0;
            int spelarekort11=0;//21
            int playercardvalue=spelarekort1+spelarekort2+spelarekort3+spelarekort4+spelarekort5+spelarekort6+spelarekort7+spelarekort8+spelarekort9+spelarekort10+spelarekort11; 
            int botkort1=0;
            int botkort2=0;
            int botkort3=0;
            int botkort4=0;
            int botkort5=0;
            int botkort6=0;
            int botkort7=0;
            int botkort8=0;
            int botkort9=0;
            int botkort10=0;
            int botkort11=0;
            Console.WriteLine("Hej och välkommen till Black Jack");
            Console.Write("vänligen skriv in vad ess ska vara värt(1 eller 11):");
            ess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bra, ess är nu värt" + ess);
            Console.WriteLine("då kör vi");
            deck deck=new deck();
            //spelare och bot får två kort
            int spelarekort1=deck
        }
    }

    class AIcard
    {
         
        public void botdeck()
        {
            bot 
            
            int cardvalue = 0;
            //sammanlagda värdet på korten
            
            for (int botkort = 0; botkort < 52; botkort++)
            {
                for (cardvalue = 0; cardvalue < 16;)
                {
                    cardvalue++;
                }

                if (cardvalue < 16)
                {
                    Console.WriteLine("jag tar ett kort");
                }

                if (cardvalue == 16 || cardvalue < 16)
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
            for (int i = 0; i < 4; i++)
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

            string[] studentArray =
             {
             "Abdalaziz", "Johannes", "Eliyah", "Ebba", "Ossian", "Adam",
             "Gabriel", "Ahmad", "Mukhtar", "Hugo", "Yayhe", "Alexander",
             "Theo", "Albin", "John", "Leo", "Benjamin", "Erik", "Omar",
             "Ajob", "Emil", "Jim", "Viggo", "Hassan", "Abd", "Noah",
             "Sebastian", "Alfons", "Romeo", "Annie", "Gvidas", "Samir"
            };
            List<string> students = new List<string>();

            for (int i = 0; i < studentArray.Length; i++)
            {
                students.Add(studentArray[i]);

            }
            Console.WriteLine("antal elever i listan " + students.Count);

            Random random = new Random();
            
            for (int i = 1; i < GROUP_AMOUNT + 1; i++)
            {
                Console.WriteLine("group" + i + ":");

                for (int j = 0; j < GROUP_SIZE; j++)
                {
                    if (students.Count == 0)
                    {
                        Console.WriteLine("Alla elever har fått en grupp");
                        break;

                    }
                    int localValue = random.Next(0, students.Count);
                    Console.WriteLine(students[localValue]);

                    students.RemoveAt(localValue);

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
