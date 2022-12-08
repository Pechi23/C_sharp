using System;
namespace myApp
{
    class Program
    {
        private static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] zero = new int[n+1]; //zero[i] = nr de secvente de lungime i care se termina cu 0 
            int[] unu = new int[n+1]; //unu[i] = nr de secvente de lungime i care se termina cu 1 
            zero[1] = unu[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                zero[i] = zero[i - 1] + unu[i - 1];
                unu[i] = zero[i - 1];
            }
            int x = zero[n] + unu[n];
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
