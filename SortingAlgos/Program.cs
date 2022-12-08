using System;

namespace myApp
{
    class Program
    {
        private static void Main()
        {
            var line = Console.ReadLine().Split(' ');
            var v = new int[line.Length];
            var rez = new int[line.Length];
            for (int i=0;i<line.Length;i++)
            {
                v[i] = Convert.ToInt32(line[i]);
            }
            MergeSort(v,rez,0,v.Length-1);

            Console.WriteLine(string.Join(" ", v));
            
        }

        private static void MergeSort(int[] v,int[] rez,int st,int dr)
        {
            if (st >= dr)
                return;
            int mid = st + (dr - st)/2;
            MergeSort(v,rez,st,mid);
            MergeSort(v,rez,mid + 1, dr);

            int i1=st, i2=mid+1, i=0;
            while (i1 <= mid && i2 <= dr)
                if (v[i1] <= v[i2])
                    rez[i++] = v[i1++];
                else
                    rez[i++] = v[i2++];
            while(i1 <= mid)
                rez[i++] = v[i1++];
            while (i2 <= dr)
                rez[i++] = v[i2++];
            for (i = st; i <= dr; i++)
                v[i] = rez[i - st];
        }



    }
}
