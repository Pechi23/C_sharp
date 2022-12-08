namespace myApp
{
    class Program
    {
        static void WriteLongestSequence(int[] v,int[] p, int poz)
        {
            if (p[poz] > 1)
            {
                WriteLongestSequence(v, p, poz - 1);
                Console.Write($"{v[poz]} ");
            }
        }

        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, 4, 1, 2, 3, 4, 1, 1, 1, 4, 4, 4 };
            int[] p = new int[v.Length];

            for (int i=0;i<v.Length;i++)
                p[i] = 1;
            

            for(int i=1;i<v.Length-1;i++)
            {
                for(int j=i+1;j<v.Length;j++)
                {
                    if (v[i] == v[j] && v[i-1] == v[j-1])
                        p[j] = p[j - 1] + 1;
                }
            }

            int maxVal = p[0];
            int pozMaxVal = 0;
            for(int i=1;i<v.Length;i++)
            {
                if(maxVal< p[i])
                {
                    maxVal = p[i];
                    pozMaxVal = i;
                }
            }

            WriteLongestSequence(v, p, pozMaxVal);






            
            
        }
    }
}
