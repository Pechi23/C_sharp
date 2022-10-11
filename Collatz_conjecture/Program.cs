/*
 * 1. Scrieti un program care determina lungimea unei secvente Collatz.
 * 2. Cea mai mare valoare dintr-o secventa Collatz.
 * 3. Determinati x din intervalul [a,b] pentru care se obtine cea mai lunga secventa Collatz.
 */

using System;

namespace Collatz_conjecture
{
    class Program
    {
        private static void Main(String[] args)
        {
            ex1();
            ex2();
            ex3();
        }

        public static List<int> collatz_function_values(int x)
        {
            List<int> retList = new List<int>();
            while(x>1)
            {
                retList.Add(x);
                if (x % 2 == 0)
                    x /= 2;
                else
                    x = x * 3 + 1;     
            }
            return retList;
        }

        private static void ex1()
        {
            Console.Write("1. Dati o valoare n: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            List<int> Collatz = collatz_function_values(n);
            int lenght = Collatz.Count;

            Console.WriteLine($"lungimea secventei Collatz pornind de la valoarea {n} este de {lenght} termeni");
        }

        private static void ex2()
        {
            Console.Write("2. Dati o valoare n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> Collatz = collatz_function_values(n);
            int maxx = 1; //minimum value possible
            foreach(int value in Collatz)
                if(maxx < value)
                    maxx = value;

            Console.WriteLine($"cea mai mare valoare din secventa Collatz pornind de la valoarea {n} este {maxx}");
        }

        private static void ex3()
        {
            //reads a and b
            Console.Write("3. Dati 2 valori pentru intervalul [a,b]: ");
            string line = Console.ReadLine();
            string[] ab = line.Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            //swap variables if a is greater than b
            if(a>b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            int maxx = 1;//minimum value possible
            int sol = a;
            for (int i=a; i<=b; i++)
            {
                List<int> Collatz_i = collatz_function_values(i);
                if (Collatz_i.Count > maxx)
                {
                    maxx = Collatz_i.Count;
                    sol = i;
                }
            }

            Console.WriteLine($"prima valoare pentru care se obtine cea mai lunga secventa din intervalul [{a},{b}] este {sol} ({maxx} termeni)");
        }
    }
}
