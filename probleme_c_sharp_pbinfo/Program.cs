using System;

namespace myApp
{
    class Program
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.Read());
            Console.ReadLine();
            string[] line = Console.ReadLine().Split();
            int suma = 0;
            foreach (string e in line)
                suma += Convert.ToInt32(e);
            Console.WriteLine(suma);
        }
    }
}
