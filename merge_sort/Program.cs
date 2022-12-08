using System;

namespace myApp
{
   
    class Program
    {
        private static void mergesort(int[] a, int[] rez, int st, int dr)
        {
            if (st < dr)
            {
                int m = st + (dr - st) / 2;
                mergesort(a, rez, st, m);
                mergesort(a, rez, m + 1, dr);
                int ind1 = st, ind2 = m + 1, ind = 0;
                while (ind1 <= m && ind2 <= dr)
                    if (a[ind1] <= a[ind2])
                        rez[++ind] = a[ind1++];
                    else
                        rez[++ind] = a[ind2++];
                while (ind1 <= m)
                    rez[ind++] = a[ind1++];
                while (ind2 <= dr)
                    rez[ind++] = a[ind2++];
                for (int i = st; i <= dr; i++)
                    a[i] = rez[i - st];
            }
        }
        private static void Main()
        {
            var line = Console.ReadLine();
            var sv = line.Split(' ');
            var a = new int[sv.Length];
            for(int i=0;i<sv.Length;i++)
            {
                a[i] = int.Parse(sv[i]);
            }
            var rez = new int[a.Length];
            mergesort(a, rez, 0, a.Length - 1);
            foreach(var el in a)
                Console.Write($"{el} ");
        }

    }
}
