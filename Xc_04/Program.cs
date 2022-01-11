using System;
//using System.Collections.Generic;
//using System.Text;

namespace Xc_04
{
    class Gajah
    {

        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gajah g1 = new Gajah() { Name = "Jacinda", EarSize = 33 };
            Gajah g2 = new Gajah() { Name = "Trudo", EarSize = 40 };

            Console.WriteLine("Press 1 for g1, 2 for g2, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling g1.WhoAmI()");
                    g1.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling g2.WhoAmI()");
                    g2.WhoAmI();
                }
                else if (input == '3')
                {
                    Gajah temp = g1;
                   // holder = lloyd;
                    g1 = g2;
                    g2 = temp;
                    Console.WriteLine("References have been swapped");
                }
                
                else return;
                Console.WriteLine();
            }
        }
    }
}
