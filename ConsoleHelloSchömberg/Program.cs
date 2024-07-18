using System.Runtime.CompilerServices;

namespace ConsoleHelloSchömberg
{
    internal class Program
    {
        static void Main(string[] args)
        {bool exit=false;
            DoItLong(exit);
            Console.WriteLine("Herzlich willkommen in TaschenRechner, was möchtest du tun? ");
            Console.WriteLine("1. Summe.");
            Console.WriteLine("2. ");
            Console.WriteLine("Herzlich willkommen in TaschenRechner, was möchtest du tun? ");
            Console.WriteLine("Herzlich willkommen in TaschenRechner, was möchtest du tun? ");
            // HelloStadt();
            // summe();
        }


        public static void DoItLong(bool exit) {
            while (exit) { 
            
            }
        
        }
        public static void HelloStadt()
        {
            string[] ar = { "Pforzheim", "Schömberg", "Stutgart", "Ravensburg" };
            int a = ar.Length;
            while (a != 0)
            {
                Console.WriteLine("Hello " + ar[a - 1]);
                a = a - 1;
                Console.ReadLine();
            }

            Console.WriteLine("Druck Enter ");
            Console.ReadLine();
        }

       public static void summe() {
            Console.Write("Gib mir Zahl 1: ");
            string? zahl = Console.ReadLine();
            // string? - > Nullalble (d.h. Vairaible kann null enthalten)
            int zahl1 = Convert.ToInt32(zahl);
            Console.Write("Gib mir Zahl 2: ");
            zahl = Console.ReadLine();
            int zahl2 = Convert.ToInt32(zahl);
            zahl2 = zahl2 + zahl1;
            Console.WriteLine("Summe Zahl1 + Zahl2= " + zahl2);
            Console.ReadLine();
        }

        
    }

}
