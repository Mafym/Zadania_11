using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Tablice
    {
        public int liczba = 20;
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice!");
        }
        public int[] Stworz_Tablice()
        {
            //zapytanie o dł tablicy
            Console.WriteLine("Jaka ma być długość tablicy: ");
            int dł = int.Parse(Console.ReadLine());
            //stworzyc tablicę o danej długości
            int[] tab = new int[dł];
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj kolejny element tablicy:");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return tab;
            //zapełnic tablice w pętli, liczbami podanymi



        }
    }
}
