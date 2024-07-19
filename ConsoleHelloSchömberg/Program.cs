using System.Runtime.CompilerServices;

namespace ConsoleHelloSchömberg
{
    internal class Program
    {
        static void Main(string[] args)
        {   //bool exit=false;
            //Lotto();
            // TaschenRechner(exit);
            // HelloStadt();
            // summe();
            //SorrtirenArr();
            SummeArr();
        }

        public static void SummeArr() { 
        Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("ConsoleArray2");
            Console.WriteLine();
            int[] arWürfe = new int[] { 15, 3, 4, 11, 2, 8 };
            int a = 0;
            for (int i = 0; i < arWürfe.Length; i++) {
                a+=arWürfe[i];
                if (i == 0) { continue; }
                else { arWürfe[0] += arWürfe[i]; }
            }
            Console.WriteLine("Summe: "+ arWürfe[0]);
            Console.WriteLine("Summe: " + a);
            Console.ReadLine();
        }

        public static void SorrtirenArr() {

            int[] arWürfe = new int[] { 15, 3, 4, 11, 2, 8 };
            int a = 0;
            int b = 0;

            for (int i = 0;i<10; i++)
            {
                for (int j = 0; j < 5; j++) { 
                    if (arWürfe[j]> arWürfe[j + 1])
                {
                    a = arWürfe[j];
                    b = arWürfe[j+1];
                    arWürfe[j]=b;
                    arWürfe[j+1] = a;
                }
                }
            }
            Console.WriteLine("Zahlen: " + arWürfe[0] + " " + arWürfe[1] + " " + arWürfe[2] + " " + arWürfe[3] + " " + arWürfe[4] + " " + arWürfe[5]);
            Console.ReadLine(); 
        }


        public static void Lotto()
       {
            Random r = new Random();
            int[] ar1 = new int[49];
            int[] ar2 = new int[6];
            for (int i = 0; i < 49; i++)
            {
                ar1[i] = i + 1;
            }

            for (int i = 0; i < 6; i++)
            {
                int a;
                do
                {
                    a = r.Next(1, 50);
                } while (ar1[a - 1] == 0);

                ar2[i] = a;
                ar1[a - 1] = 0;
            }

            Console.WriteLine("Lotto Zahlen: " + ar2[0] + " " + ar2[1] + " " + ar2[2] + " " + ar2[3] + " " + ar2[4] + " " + ar2[5]);
            Console.ReadLine();
        }


        public static void TaschenRechner(bool exit) {
            while (!exit) {
                Console.WriteLine("Herzlich willkommen in TaschenRechner, was möchtest du tun? ");
                Console.WriteLine("1. Summe.");
                Console.WriteLine("2. Substraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quadrat");
                Console.WriteLine("6. Wurzel");
                Console.WriteLine("7. Ausgang");
                Console.WriteLine("\n");
                Console.WriteLine("Was möchtest du weiter tun");
                string? wahlStr = Console.ReadLine();
                int wahlInt;
                if (int.TryParse(wahlStr, out wahlInt))
                {
                    
                    Console.WriteLine("Dein Zahl: " + wahlInt);
                }
                else
                {
                    // Konwersja się nie powiodła, obsłuż błąd
                    Console.WriteLine("Falsche Zahl.");
                }
                switch (wahlInt) 
                {
                    case 1:
                        Summe();
                        break;
                    case 2:
                        Substraktion();
                        break;
                    case 3:
                        Multiplikation();
                        break;
                    case 4:
                        Devision();
                        break;
                    case 5:
                        Qudrat();
                        break;
                    case 6:
                        Wurzel();
                        break;
                    case 7:
                        exit = true;
                        break;
                   
                    default:
                        Console.Clear();    
                        Console.WriteLine("Etwas ist schief gelaufen");
                        
                        break;

                }

            }
        
        }


        private static void Wurzel()
        {
            Console.Clear();
            double a = NimmWert();

            a = Math.Sqrt(a);
            Console.WriteLine("Ergenis Wurzel von a ist: " + a);
            Console.Read();
        }
        private static void Qudrat()
        {
            Console.Clear();
            double a = NimmWert();
         
            a = a * a;
            Console.WriteLine("Ergenis a^2 ist: " + a);
            Console.Read();
        }
        private static void Devision()
        {
            Console.Clear();
            double a = NimmWert();
            double b = NimmWert();
            b = b / a;
            Console.WriteLine("Ergenis b/a ist: " + b);
            Console.Read();
        }
        private static void Multiplikation()
        {
            Console.Clear();
            double a = NimmWert();
            double b = NimmWert();
            b = b * a;
            Console.WriteLine("Ergenis b*a ist: " + b);
            Console.Read();
        }
        private static void Substraktion()
        {
            Console.Clear();
            double a = NimmWert();
            double b = NimmWert();
            b = b-a;
            Console.WriteLine("Ergenis b-a ist: " + b);
            Console.Read();
        }
        private static void Summe() {
            Console.Clear();
            double a = NimmWert();
            double b = NimmWert();
            b = a + b;
            Console.WriteLine("Ergenis a+b ist: " + b);
            Console.Read(); 
        }
        private static double NimmWert(){
            Console.WriteLine("Gib mir der Zahl: ");
            string? a=Console.ReadLine();
            double b = Convert.ToDouble(a);
            return b; }

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
