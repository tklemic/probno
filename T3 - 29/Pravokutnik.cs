using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3___29
{
    class Pravokutnik
    {
        public string Boja;
        public int Sirina;
        public int Visina;
        public int Trajanje;

        public void Unos()
        {
            Console.Write("Unesite zeljenu sirinu: ");
            Sirina = int.Parse(Console.ReadLine());
            Console.Write("Unesite zeljenu visinu: ");
            Visina = int.Parse(Console.ReadLine());
            Console.Write("Unesite zeljeno trajanje: ");
            Trajanje = int.Parse(Console.ReadLine());
            Console.Write("Unesite zeljenu boju (Crvena, Plava, Zelena) : ");
            Boja = Console.ReadLine();
        }

        public void Ispis()
        {
            
            if (Boja=="Crvena")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Boja == "Plava")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            for (int i = 0; i < Visina; i++)
            {
                string ispis = "";
                for (int j = 0; j < Sirina; j++)
                {
                    ispis += "o";
                }
                Console.WriteLine(ispis);
            }
            System.Threading.Thread.Sleep(Trajanje);
        }
    }
}
