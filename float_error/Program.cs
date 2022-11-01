using System;

namespace myApp
{
    class Program
    {
        static void Main(String[] Args)
        {
            const double constanta = 0.001;
            double suma = 0;
            for (int i = 0; i < 1000000; i++)
            {
                suma += constanta;
            }
            Console.WriteLine(suma);
        }
    }
}
