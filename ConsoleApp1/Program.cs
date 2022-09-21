using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("napis neco kokote: ");

            String penis = Console.ReadLine();

            if (penis.ToLower().Contains("martin"))
            {
                Console.Write("naser si");
                Console.ReadKey(true);
                return;

            }

            while (true) {
                Console.WriteLine(penis);
                System.Threading.Thread.Sleep(50);
            }*/

            while (true)
            {
                Console.Write("pravda nebo lez: ");
                String penis = Console.ReadLine();


                if (penis.ToLower().Contains("martin"))
                {
                    Console.Write("lež");
                    Console.ReadKey(true);
                    return;

                }
                else
                {
                    Console.Write("pravda");
                    Console.ReadKey(true);
                    return;
                }
            }
        }
    }
}
