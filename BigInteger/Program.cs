using System;
using System.Numerics;

namespace myApp
{
    class Program
    {
        public static void Main()
        {
            int n = 2;
            int p = 1000;
            BigInteger rez = new BigInteger(1);
            for(int i = 0; i < p; i++)
            {
                rez *= n;
            }

            Console.WriteLine(rez);


        }
    }
}

