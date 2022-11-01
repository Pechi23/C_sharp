using System;

namespace myApp
{
    class Program
    {
        private static char[] cifre = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private static void Main(string[] args)
        {
            Console.WriteLine("Se vor converti numere din baza b1 in baza b2");
            int b1 = 10, b2 = 10;//bases will be 10 by default
            readBases(ref b1, ref b2);
            readNums(b1, b2);
        }

        /// <summary>
        /// reads two bases values
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        private static void readBases(ref int b1, ref int b2)
        {
            bool okBase = false;

            while (!okBase)
            {
                char[] separators = { ' ', ',', ';' };
                Console.WriteLine("Dati baza1 si baza2 pe o singura linie, separate prin spatii");
                string[] line = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                b1 = Convert.ToInt32(line[0]);
                b2 = Convert.ToInt32(line[1]);
                if (b1 >= 2 && b1 <= cifre.Length && b2 >= 2 && b2 <= cifre.Length)
                    okBase = true;
                if (!okBase)
                    Console.WriteLine($"Valorile bazelor trebuie sa fie intre 2 si {cifre.Length}");
            }
        }

        /// <summary>
        /// reads numbers in b1 and shows their conversion in base b2
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        private static void readNums(int b1, int b2)
        {
            Console.WriteLine("Scrieti \"stop\" pt a opri citirea");
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write($"Dati numarul scris in baza {b1}: ");
                    string input = Console.ReadLine();
                    if (input.CompareTo("stop") == 0)
                        stop = true;
                    else
                        base1ToBase2(b1, b2, input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// converts an input from base b1 in base b2 and shows the result
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <param name="input"></param>
        public static void base1ToBase2(int b1, int b2, string input)
        {
            int temp = baseKToBase10(b1, input);
            string sol2 = base10ToBaseK(b2, temp);
            Console.WriteLine($"{input} din baza {b1} este {sol2} in baza {b2}");
        }

        /// <summary>
        /// converts an input from base b1 to base 10 and returns the result
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int baseKToBase10(int b1, string input)
        {
            int sol = 0;
            for (int i = 0; i < input.Length; i++)
                sol += (int)Math.Pow(b1, input.Length - i - 1) * Array.IndexOf(cifre, input[i]);
            return sol;
        }

        /// <summary>
        /// converts an input from base 10 to base b1 and returns the result
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string base10ToBaseK(int b1, int input)
        {
            string sol = "";
            Stack<char> stack = new Stack<char>();
            while (input > 0)
            {
                stack.Push(cifre[input % b1]);
                input /= b1;
            }
            foreach (char c in stack)
                sol += c;
            return sol;
        }
    }
}
