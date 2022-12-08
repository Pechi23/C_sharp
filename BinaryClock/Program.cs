using System;

namespace myApp
{
    class Program
    {
        private static void Main()
        {
            String data = DateTime.Now.ToString("HH:mm:ss");
            //Console.WriteLine($"{data}");
            String[] line = data.Split(':');
            /*
            Console.WriteLine($"H:{base10ToBaseK(2, line[0][0])}");
            Console.WriteLine($"H:{base10ToBaseK(2, line[0][1])}");
            Console.WriteLine($"M:{base10ToBaseK(2, line[1][0])}");
            Console.WriteLine($"M:{base10ToBaseK(2, line[1][1])}");
            Console.WriteLine($"S:{base10ToBaseK(2, line[2][0])}");
            Console.WriteLine($"S:{base10ToBaseK(2, line[2][1])}");
            */
            base10ToBaseK(2, line[0][0]);
            base10ToBaseK(2, line[0][1]);
            base10ToBaseK(2, line[1][0]);
            base10ToBaseK(2, line[1][1]);
            base10ToBaseK(2, line[2][0]);
            base10ToBaseK(2, line[2][1]);
        }
        
        /*
        /// <summary>
        /// converts an input from base 10 to base b1(b1<=10) and returns the result
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string base10ToBaseK(int b1, int input)
        {
            string sol = "";
            Stack<char> stack = new Stack<char>();
            while (input > 0)
            {
                stack.Push((char)('0' + input % b1));
                input /= b1;
            }
            foreach (char c in stack)
                sol += c;
            return sol;
        }
        */
        private static void base10ToBaseK(int k,int x)
        {
            if (x == 0)
            {
                Console.WriteLine();
                return;
            }
            base10ToBaseK(k,x / k);
            Console.Write(x%k);
        }






    }
}
