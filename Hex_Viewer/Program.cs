using System;
using System.IO;
using System.Text;
using System.Runtime;

namespace myApp
{
    class Program
    {
        static char[] cifreHex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private static void Main(string[] args)
        {
            string path = @"C:\Users\George\source\repos\C_sharp\Hex_Viewer\fisier.txt";

            if(!File.Exists(path))
                File.Create(path);
            
            /*
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("dafahkjfbjkbfuwbq");
            }
            */
            
            

            ShowHexBar();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for(int i=0;i<line.Length;i++)
                    {
                        if (i % 16==0 && i!=0)
                        {
                            Console.Write($"| ");
                            for (int j = Math.Max(i-16,0); j <= i; j++)
                            {
                               
                                Console.Write($"{line[j]}");
                            }
                            
                            Console.WriteLine();
                        }
                        Console.Write($"{base10ToBase16((int)line[i])} ");
                    }
                    for (int j = line.Length % 16; j < 16; j++)
                    {
                        Console.Write("00 ");
                    }
                    Console.Write($"| ");
                    for (int j = line.Length - line.Length%16+1; j < line.Length; j++)
                    {
                        Console.Write($"{line[j]}");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void ShowHexBar()
        {
            foreach (var el in cifreHex)
            {
                Console.Write($"{el}  ");
            }
            Console.Write("| ");
            foreach (var el in cifreHex)
            {
                Console.Write(el);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// converts an input from base 10 to base 16 and returns the result
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string base10ToBase16(int input)
        { 
            string sol = "";
            Stack<char> stack = new Stack<char>();
            while (input > 0)
            {
                stack.Push(cifreHex[input % 16]);
                input /= 16;
            }
            foreach (char c in stack)
                sol += c;
            return sol;
        }
    }
}
