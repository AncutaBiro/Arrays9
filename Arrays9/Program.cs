/*
La un magazin batoanele de ciocolată pot fi cumpărate în pachete de câte 1, 2, 3, 5 sau 10 bucăți.
Se dă un număr X de batoane de ciocolată. Să se determine numărul minim de pachete pe care îl putem cumpăra ca să achiziționăm cele X batoane de ciocolată. 
La consolă se va afișa și numărul de pachete achiziționate din fiecare tip.
Exemplu:
Pentru datele de intrare:
22
La consolă se va afișa:
3 pachete
2 x 10 buc
1 x 2 buc
 */


using System;

namespace Arrays9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(total(n) + " pachete");

            int[] pcsPerPack = { 10, 5, 3, 2, 1 };

            for (int i = 0; i < pcsPerPack.Length; i++)
            {

                if (n >= pcsPerPack[i])
                {
                    Console.WriteLine((n / pcsPerPack[i]) + " x " + pcsPerPack[i] + " buc");

                    n = n % pcsPerPack[i];
                }

            }

            static int total(int n)
            {
                int[] pcsPerPack = { 10, 5, 3, 2, 1 };
                int totalPack = 0;

                for (int i = 0; i < pcsPerPack.Length; i++)
                {

                    if (n >= pcsPerPack[i])
                    {

                        totalPack += n / pcsPerPack[i];

                        n = n % pcsPerPack[i];
                    }

                }
                return totalPack;
            }

        }
    }

}
             
