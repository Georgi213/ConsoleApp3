using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write z");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"c=({a}+{b})*11*{z}-12*{x}");
            double c = (a + b) * 11 * z - 12 * x;
            Console.WriteLine("c={0}", c.ToString());
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();

            } while (nupp.Key != ConsoleKey.Backspace);
        }





    }
}
//   Console.WriteLine("c=12*x-18*(b-a)");
//           int a_ = rnd.Next(0, 10);
//    int b = rnd.Next(0, 10);
//    int x = rnd.Next(0, 10);
//    float c = 12 * x - 18 * (b - a_);
//    Console.WriteLine("Vastus on: {0}", c);
//          Console.WriteLine("Kirjuta sinu nimi ja perekonanimi:");
//           string FIO = Console.ReadLine();
//   Console.WriteLine("Kirjuta oma rühm:");
//           string ruhm = Console.ReadLine();
//    Console.WriteLine("Kirjuta oma variandi number:");
//            string n = Console.ReadLine();
//    Console.WriteLine("Kirjuta sinu vanus:");
//           string vana = Console.ReadLine();
//    Console.WriteLine("Kirjuta sinu sugu:");
//           string sugu = Console.ReadLine();
//    Console.WriteLine("labotitöö art ja pealkiri:");
//            string arv_ja_pealkiri = Console.ReadLine();
//    StreamWriter files = new StreamWriter(@"..\..\vastus.txt", true);
//    files.WriteLine("a:" + a_ + ", " + "b:" + b + ", " + "x:" + x);
//           files.WriteLine("c=12*x-18*(b-a)" + " " + "Vastus on: " + c);
//            files.WriteLine(FIO + ", " + sugu + ", " + vana + ", " + ruhm + "\n" + n + ", " + arv_ja_pealkiri);
//           files.Close();


