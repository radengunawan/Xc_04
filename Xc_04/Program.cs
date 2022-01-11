using System;
//using System.Collections.Generic;
//using System.Text;

namespace Xc_04
{
    class Gajah
    {

        public int EarSize;
        public string Name;
        //public string message1;
        //public string message2;

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

        public void DengerSuara (string chat, Gajah dariSiapa)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(dariSiapa.Name +" ngomong gini: "+chat);
        }

        public void ngomongKe (Gajah keSiapa)
        {
            //keSiapa.DengerSuara(pesan, this);
            Console.WriteLine("Hallo, this is "+ this.Name);
            Console.WriteLine("I am talking to "+keSiapa.Name);
            Console.WriteLine("My ear size is " + this.EarSize + " while yours is " + keSiapa.EarSize);

            if (this.EarSize > keSiapa.EarSize)
            {
                Console.WriteLine("My ear size is " + Math.Abs(this.EarSize - keSiapa.EarSize) + " more than you");
            }
            else
            {
                Console.WriteLine("My ear size is " + Math.Abs(this.EarSize - keSiapa.EarSize) + " less than you");
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Gajah g1 = new Gajah() { Name = "Ahmed", EarSize = 25 };
            Gajah g2 = new Gajah() { EarSize = 40, Name = "Xavier" };

            Console.WriteLine("Press 1 for g1, 2 for g2, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling g1.WhoAmI()");
                    g1.WhoAmI();
                    //g1.DengerSuara("Haloha", g2);
                    //g1.ngomongKe(g2, "Hi, gua Jacin (g1), apa kabar lu dro?");

                    g1.ngomongKe(g2);
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling g2.WhoAmI()");
                    g2.WhoAmI();
                    // g2.DengerSuara("lovin' it",g1);
                    g2.ngomongKe(g1);
                }
                else if (input == '3')
                {
                    Gajah temp = g1;
                   
                    g1 = g2;
                    g2 = temp;
                    Console.WriteLine("References have been swapped");
                }

                else if (input == '4')
                {
                    g1 = g2;
                    g1.EarSize = 4211;
                    g1.WhoAmI();

                }


                else return;
                Console.WriteLine();
            }
        }
    }
}

/*
 Objects use references to talk to each other

 */