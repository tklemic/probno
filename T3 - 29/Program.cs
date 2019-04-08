using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3___29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pravokutnik> ListaPravokutnika = new List<Pravokutnik>();
            string ponovi = "d";
            do
            {
                Pravokutnik pomocniObjekt = new Pravokutnik();
                pomocniObjekt.Unos();
                try
                {
                    if (pomocniObjekt.Sirina<=0 || pomocniObjekt.Visina<=0)
                    {
                        throw new Iznimka("Sirina i visina pravokutnika moraju biti vece od 0!");
                    }
                }
                catch (Iznimka mojaIznimka)
                {

                    Console.WriteLine(mojaIznimka.Poruka);
                    Console.ReadLine();
                    return;
                }
                ListaPravokutnika.Add(pomocniObjekt);

                Console.Write("Zelite li ponovno unjeti d/n : ");
                ponovi = Console.ReadLine();
                
            } while (ponovi=="d");

            do
            {
                foreach (Pravokutnik pravokutnik in ListaPravokutnika)
                {
                    pravokutnik.Ispis();
                }
            } while (true);
        }
    }
}
