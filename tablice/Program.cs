using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new double[1000];
            int i = 0;
            string linia;
          
            do
            {
                Console.WriteLine("Podaj liczbę nr {0}. Enter kończy wczytywanie.", i);
                linia = Console.ReadLine();
                if (linia.Length == 0) break;
                tab[i++] = Convert.ToDouble(linia);
            } while (i < tab.Length );

            Console.WriteLine("Podano tyle liczb: {0}", i);
            Console.WriteLine("A teraz w odwrotnej kolejności");

            for (int k = i-1; k >=0 ; k--)
            {
                Console.WriteLine("Element {0} wynosi {1}", k, tab[k]);
            }
        }
    }
}
