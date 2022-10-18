/* 
20.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Scrieti de la tastatura \"stop\" cand vreti sa opriti programul");
            while (!stop)
            {
                Console.Write("Dati numarul problemei pe care doriti sa o accesati (sau \"stop\" pentru oprire): ");
                string instruction = Console.ReadLine();
                if (instruction.CompareTo("stop") != 0) 
                {
                    try
                    {
                        int n = Convert.ToInt32(instruction);
                        Solve(n);
                    }
                    catch (Exception ex) 
                    { 
                        Console.WriteLine(ex.Message); 
                    }  
                }
            }
        }
        /// <summary>
        /// solve the n-th exercise 
        /// </summary>
        /// <param name="n"></param>
        public static void Solve(int n)
        {
            switch (n)
            {
                case 1:  P1();  break;
                case 2:  P2();  break;
                case 3:  P3();  break;
                case 4:  P4();  break;
                case 5:  P5();  break;
                case 6:  P6();  break;        
                case 7:  P7();  break;
                case 8:  P8();  break;
                case 9:  P9();  break;
                case 10: P10(); break;
                case 11: P11(); break;
                case 12: P12(); break;
                case 13: P13(); break;
                case 14: P14(); break;
                case 15: P15(); break;
                case 16: P16(); break;
                case 17: P17(); break;
                case 18: P18(); break;
                case 19: P19(); break;
                case 20: P20(); break;
                case 21: P21(); break;
            }
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        public static void P1()
        {
            Console.Write("Dati A si B din ecuatia: Ax + B = 0, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);

            double sol = -b / a;
            Console.WriteLine($"x este: {sol}");
        }
        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
        /// </summary>
        public static void P2()
        {
            Console.Write("Dati A, B si C din ecuatia: Ax^2 + Bx + C = 0, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);
            int c = Convert.ToInt32(line[2]);

            int alpha = b * b - 4 * a * c;
            if (alpha > 0)
            {
                double sol1 = (-b - Math.Sqrt(alpha)) / (2 * a);
                double sol2 = (-b + Math.Sqrt(alpha)) / (2 * a);
                Console.WriteLine($"Solutiile sunt: {sol1} {sol2}");
            }
            else if (alpha == 0)
            {
                double sol = -b / (2 * a);
                Console.WriteLine($"Solutia este: {sol}");
            }
            else
            {
                Console.WriteLine("nu exista solutii reale");
            }
        }
        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        public static void P3()
        {
            Console.Write("Dati N si K pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = Convert.ToInt32(line[0]);
            int k = Convert.ToInt32(line[1]);

            bool seDivide = false;
            if (n % k == 0)
                seDivide = true;

            if (seDivide)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
        }

        /// <summary>
        /// Detreminati daca un an y este an bisect. 
        /// </summary>
        public static void P4()
        {
            Console.Write("Dati Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (isLeapYear(y))
                Console.WriteLine($"Anul {y} este bisect");
            else
                Console.WriteLine($"Anul {y} nu este bisect");
        }

        /// <summary>
        /// returns true if year x is leap
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool isLeapYear(int x)
        {
            if (x % 4 == 0 && x % 100 != 0 || x % 400 == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.  
        /// </summary>
        public static void P5()
        {
            Console.Write("Dati N si K pe o singura linie, separate prin spatiu (K mai mic sau egal cu nr de cifre a lui N): ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = Convert.ToInt32(line[0]);
            int k = Convert.ToInt32(line[1]);

            int aux = n;
            aux = aux / (int)Math.Pow(10 ,k - 1);
            double sol = aux % 10;

            Console.WriteLine($"A {k} cifra a nr {n}, de la dreapta la stanga, este {sol}");
        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        public static void P6()
        {
            Console.Write("Dati A, B si C, laturile unui triunghi, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);
            int c = Convert.ToInt32(line[2]);

            bool isTriangle = false;
            if (a + b > c && a + c > b && b + c > a)
                isTriangle = true;

            if (isTriangle)
                Console.WriteLine($"Laturile {a}, {b} si {c} pot forma un triunghi");
            else
                Console.WriteLine($"Laturile {a}, {b} si {c} nu pot forma un triunghi");
        }

        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        /// </summary>
        public static void P7()
        {
            Console.Write("Dati A si B, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Dupa inversare: a={a} si b={b}");
        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        public static void P8()
        {
            Console.Write("Dati A si B, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);

            a *= b;
            b = a / b;
            a /= b;


            Console.WriteLine($"Dupa inversare: A={a} si B={b}");
        }

        /// <summary>
        /// Afisati toti divizorii numarului n.
        /// </summary>
        public static void P9()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());


            SortedSet<int> divizori = new SortedSet<int>();

            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                {
                    divizori.Add(i);
                    divizori.Add(n / i);

                }

            Console.Write($"Divizorii lui {n} sunt: ");
            foreach (int element in divizori)
                Console.Write($"{element} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        public static void P10()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (isPrimeNumber(n))
                Console.WriteLine($"{n} este numar prim");
            else
                Console.WriteLine($"{n} nu este numar prim");
        }
        /// <summary>
        /// returns true if x is a prime number.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool isPrimeNumber(int x)
        {
            if (x < 2)
                return false;
            if (x % 2 == 0 && x != 2)
                return false;
            for (int d = 3; d * d <= x; d += 2)
                if (x % d == 0)
                    return false;
            return true;
        }


        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        public static void P11()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Cifrele lui {n}, afisate in ordine inversa, sunt: ");
            if (n == 0)
                Console.Write(0);
            else
            {
                while (n > 0)
                {
                    Console.Write($"{n % 10} ");
                    n /= 10;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        /// </summary>
        public static void P12()
        {
            Console.Write("Dati 3 valori, N si capetele intervalului [A,B], pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = Convert.ToInt32(line[0]);
            int a = Convert.ToInt32(line[1]);
            int b = Convert.ToInt32(line[2]);

            //swaps a and b in case that a is greater than b
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int counter = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    counter++;

            Console.WriteLine($"Sunt {counter} numere intregi divizibile cu {n} in intervalul [{a},{b}]");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        public static void P13()
        {
            Console.Write("Dati anii Y1 si Y2, pe o singura linie, separati prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int y1 = Convert.ToInt32(line[0]);
            int y2 = Convert.ToInt32(line[1]);

            //swaps y1 and y2 in case that y1 is greater than y2
            if (y1 > y2)
            {
                int temp = y1;
                y1 = y2;
                y2 = temp;
            }

            int counter = 0;
            for (int i = y1; i <= y2; i++)
                if (isLeapYear(i))
                    counter++;

            Console.WriteLine($"Sunt {counter} ani bisecti in intervalul [{y1},{y2}]");
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        /// </summary>
        public static void P14()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (isPalindromeNumber(n))
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        /// <summary>
        /// returns true if number n is palindrome
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool isPalindromeNumber(int n)
        {
            int aux = 0, temp = n;
            while (temp > 0)
            {
                aux *= 10;
                aux += temp % 10;
                temp /= 10;
            }
            if (aux == n)
                return true;
            return false;
        }
        /// <summary>
        /// Se dau 3 (n) numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        public static void P15()
        {
            Console.Write("Dati N,(un numar de numere), nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati cele N numere, separate prin spatii: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();
            foreach (string element in line)
                numbers.Add(Convert.ToInt32(element));
            numbers.Sort();

            Console.Write("Numerele ordonate sunt: ");
            foreach (int number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();
        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        public static void P16()
        {
            Console.WriteLine("Dati 5 numere intregi, separate prin spatii: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);
            int c = Convert.ToInt32(line[2]);
            int d = Convert.ToInt32(line[3]);
            int e = Convert.ToInt32(line[4]);

            //to be sure that e is the greatest number after swaping it
            if (e < d)
                Swap(ref e, ref d);
            if(e < c)
                Swap(ref e, ref c);
            if(e < b)
                Swap(ref e, ref b);
            if(e < a)
                Swap(ref e, ref a);

            //to be sure that d is the second greatest number after swaping it
            if (d < c)
                Swap(ref d, ref c);
            if (d < b)
                Swap(ref d, ref b);
            if (d < a)
                Swap(ref d, ref a);

            //same for c
            if (c < b)
                Swap(ref c, ref b);
            if (c < a)
                Swap(ref c, ref a);

            //final possible swap
            if (b < a)
                Swap(ref b, ref a);

            Console.Write($"numerele sortate sunt: {a} < {b} < {c} < {d} < {e}");
            Console.WriteLine();
        }

        /// <summary>
        /// swaps 2 integers
        /// </summary>
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        public static void P17()
        {
            Console.Write("Dati A si B, pe o singura linie, separate prin spatiu: ");
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(line[0]);
            int b = Convert.ToInt32(line[1]);

            int sol = Gcd(a, b);
            
            Console.WriteLine($"Cel mai mare divizor comun a lui {a} si {b} este: {sol}");
        }
        /// <summary>
        /// returns the greatest common divisor of integers a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Gcd(int a,int b)
        {
            while(b>0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        public static void P18()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Descompunerea in factori primi a lui {n} este: ");
            int d = 2;
            while (n > 1)
            {
                int p = 0;
                while (n%d==0)
                {
                    n /= d;
                    p++;
                }
                if(p!=0)
                {
                    //add to prime factors list the pair {d,p}
                    Console.Write($" {d}^{p} *");
                }
                if (d == 2)
                    d++;
                else
                    d += 2;
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        public static void P19()
        {
            Console.Write("Dati N, un nr natural: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //a set that stores digits from number n, if the size of the set is 2 the answer yes and no otherwise.
            SortedSet<int> cifre = new SortedSet<int>();
            int aux = n;
            while(aux>0)
            {
                cifre.Add(aux%10);
                aux /= 10;
            }

            if(cifre.Count()==2)
                Console.WriteLine($"Numarul {n} este format doar din 2 tipuri de cifre");
            else
                Console.WriteLine($"Numarul {n} nu este format doar din 2 tipuri de cifre");
        }
        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)   
        /// </summary>
        public static void P20()
        {
             /*
                O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
                O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
                O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
             */
            Console.Write("Dati M si N, fractia M/N, pe o singura linie, separate prin spatiu: ");
            char[] separators = { ' ', '/', ';', ',' };
            string[] line = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int m = Convert.ToInt32(line[0]);
            int n = Convert.ToInt32(line[1]);

            int parteIntreaga = m / n;
            int parteFractionara = m % n;
            Console.Write($"Fractia {m}/{n} se scrie {parteIntreaga}.");

            List<int> cifre = new List<int>(); //lista cifrelor zecimale
            List<int> resturi = new List<int>(); //lista resturilor impartirii cu n

            //inmultim partea fractionara cu 10 dupa care o impartim cu n, extragem cea mai semnificativa cifra din rezultat si continuam pana cand restul e 0
            bool periodica = false;
            int rest = m % n;
            resturi.Add(rest);
            do {
                int cifra = parteFractionara * 10 / n;
                cifre.Add(cifra);
                rest = parteFractionara * 10 % n;
                if (resturi.Contains(rest))//daca restul se repeta inseamna ca intram intr-o bucla infinita si ne oprim
                {
                    periodica = true;
                    break;
                }
                else
                    resturi.Add(rest);
                parteFractionara = rest;//continuam cu restul ca parte fractionara
            } while (rest!=0);

            //afisare
            if(!periodica)
                foreach (int element in cifre)
                    Console.Write(element);
            else
            {
                for(int i=0;i<resturi.Count;i++)
                {
                    if (resturi[i] == rest)
                        Console.Write('(');
                    Console.Write(cifre[i]);
                }
                Console.Write(')');
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>
        public static void P21()
        {
            Console.WriteLine("Ganditi-va la un numar natural n intre 1 si 1024, iar eu il voi ghici, dupa maxim 10 intrebari! (raspunsul va fi yes sau no)");

            int left = 1;
            int right = 1024;

            while (left<=right)
            {
                int mid = left + (right - left) / 2;

                bool isBigger = false;
                Console.Write($"Is your number bigger than {mid}?");
                string response = Console.ReadLine();
                if(response.CompareTo("yes")==0)
                    isBigger = true;

                if (isBigger)
                    left = mid + 1;
                else
                    right = mid - 1;

            }
            Console.Write($"Numarul la care te-ai gandit este {left}");
            Console.WriteLine();
        }
    }
}

