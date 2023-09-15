using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lönen för 3 personer på företaget separerade med kommatecken");
            string svar = Console.ReadLine();

            byte index1 = (byte)svar.IndexOf(",");
            byte index2 = (byte)svar.IndexOf(",",(index1+1));

            int lön1 = int.Parse(svar[..index1]);
            int lön2 = int.Parse(svar[(index1+1)..index2]);
            int lön3 = int.Parse(svar[(index2 + 1)..]);

            Console.WriteLine($"Medellönen är {(lön1+lön2+lön3)/3} kronor.");

            Console.ReadKey();
        }
    }
}