//Pecherle George-Daniel 11_10_2022
using System;

namespace Set2
{
    class Program
    {
        static void Main(String[] args)
        {
            bool stop = false;
            while (!stop)
            {
                Console.Write("Dati numarul problemei pe care doriti sa o accesati(sau \"stop\" pentru oprire): ");
                string line = Console.ReadLine();
                if (line.CompareTo("stop") == 0)
                    stop = true;
                else
                {
                    try
                    {
                        Solve(Convert.ToInt32(line));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
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
                case 1: P1(); break;
                case 2: P2(); break;
                case 3: P3(); break;
                case 4: P4(); break;
                case 5: P5(); break;
                case 6: P6(); break;
                case 7: P7(); break;
                case 8: P8(); break;
                case 9: P9(); break;
                case 10: P10(); break;
                case 11: P11(); break;
                case 12: P12(); break;
                case 13: P13(); break;
                case 14: P14(); break;
                case 15: P15(); break;
                case 16: P16(); break;
                case 17: P17(); break;
                default: Console.WriteLine($"Problema cu numarul {n} nu exista :("); break;
            }
        }

     
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        static void P1()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.Write("Dati n (numarul de numere pe care vreti sa-l cititi, iar pe urmatoarele n linii, numere intregi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for(int i= 0;i < n;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0)
                    counter++;
            }
            Console.WriteLine($"{counter} numere din secventa sunt pare");
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
        /// </summary>
        static void P2()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.Write("Dati n (numarul de numere pe care vreti sa-l cititi, iar pe urmatoarele n linii, numere intregi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int countNegatives = 0, countZero = 0, countPositives = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0) countNegatives++;
                else if (x == 0) countZero++;
                else if (x > 0) countPositives++;
            }
            Console.WriteLine($"{countNegatives} numere sunt negative. \n{countZero} numere sunt zero.\n{countPositives} numere sunt pozitive.\n");
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        static void P3()
        {
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n. ");
            Console.Write("Dati n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int factorial = 1;
            while (temp > 0)
            {
                factorial *= temp;
                temp--;
            }
            Console.WriteLine($"Suma de la 1 la {n} este: {n * (n + 1) / 2}.\nProdusul de la 1 la n este {factorial}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. Se considera ca primul element din secventa este pe pozitia zero. 
        /// Daca numarul nu se afla in secventa raspunsul va fi -1.
        /// </summary>
        static void P4()
        {
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. Se considera ca primul element din secventa este pe pozitia zero.\nDaca numarul nu se afla in secventa raspunsul va fi -1. ");
            var line = ReadInputs();
            Console.Write("Dati a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int poz = -1;
            if (a >= line.Length)
            {
                Console.WriteLine($"{a} nu se afla in secventa data.");
                return;
            }

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == a)
                    poz = i;
            }
            if (poz != -1)
                Console.WriteLine($"{a} se afla in secventa data la pozitia {poz}.");
            else
                Console.WriteLine($"{a} nu se afla in secventa data.");
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.
        /// </summary>
        static void P5()
        {
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");
            var line = ReadInputs();

            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == i)
                    counter++;
            }
            Console.WriteLine($"Sunt {counter} elemente cu valoarea egala cu pozitia din secventa");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        static void P6()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            var line = ReadInputs();

            bool isSorted = true;
            int ant = line[0];
            foreach (int e in line)
            {
                if (e < ant)
                {
                    isSorted = false;
                    break;
                }
            }
            if (isSorted)
                Console.WriteLine($"Cele {line.Length} elemente sunt in ordine crescatoare");
            else
                Console.WriteLine($"Cele {line.Length} elemente nu sunt in ordine crescatoare");

        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        static void P7()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            var line = ReadInputs();

            /*
            //using c# methods for min and max
            int maxValue = line.Max();
            int minValue = line.Min();
            */

            //without using predefined methods
            int max = line[0];
            int min = line[0];
            foreach (int e in line)
            {
                if (e < min)
                    min = e;
                if (e > max)
                    max = e;
            }
            Console.WriteLine($"{max} este maximul din secventa\n{min} este minimul din secventa");
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        static void P8()
        {
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.Write("Dati n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            /*
            //using recursive fibo method with memoization
            int[] fibo = new int[n+1];
            fibo[0] = 0;
            fibo[1] = 1;
            recFibo(n,ref fibo);
            Console.WriteLine($"{fibo[n]} este al {n}-lea element din sirul Fibonacci");
            */

            int a, b, c;
            a = 0;
            b = 1;
            c = 1;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine($"{c} este al {n}-lea numar din sirul Fibonacci");

        }
        /// <summary>
        /// recursive fibo method with memoization
        /// </summary>
        /// <param name="n"></param>
        /// <param name="fibo"></param>
        /// <returns></returns>
        public static int recFibo(int n, ref int[] fibo)
        {
            if (n < 2)
                return n;
            if (fibo[n] != 0)
                return fibo[n];
            return fibo[n] = recFibo(n - 1, ref fibo) + recFibo(n - 2, ref fibo);
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        static void P9()
        {
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");
            var line = ReadInputs();

            bool isSorted = true, isGrowing = true;
            monoton(line, ref isSorted, ref isGrowing);

            if (isSorted)
            {
                if (isGrowing)
                    Console.WriteLine("Sirul este monoton crescator");
                else
                    Console.WriteLine("Sirul este monoton descrescator");
            }
            else
                Console.WriteLine("Sirul nu este monoton");
        }
        /// <summary>
        /// this method analize a sequence and modify the last to parameters based on the sequence properties
        /// </summary>
        /// <param name="arr"></param>
        static void monoton(int[] arr, ref bool isSorted, ref bool isGrowing)
        {
            isSorted = true;
            isGrowing = true;

            for (int i = 1; i < arr.Length && isGrowing; i++)
                if (arr[i - 1] > arr[i])
                    isGrowing = false;

            for (int i = 1; i < arr.Length && isSorted; i++)
                if (isGrowing)
                {
                    if (arr[i - 1] > arr[i])
                        isSorted = false;
                }
                else
                {
                    if (arr[i - 1] < arr[i])
                        isSorted = false;
                }
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        static void P10()
        {
            Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            var line = ReadInputs();

            int sol = 0; //solution
            int ant = line[0];
            int counter = 0;
            foreach (int e in line)
            {
                if (e == ant)
                {
                    counter++;
                    if (counter > sol)//if the current sequence of equal elements is longer than the actual solution
                        sol = counter;//the solution get updated
                }
                else
                    counter = 0;//if the current element isn't equal to the one before it, the counter get restarted
                ant = e;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {sol}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        static void P11()
        {
            Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            var line = ReadInputs();

            int sum = 0;
            foreach (int e in line)
            {
                sum += reversedNum(e);
            }
            Console.WriteLine($"Suma inverselor (oglinditelor) din secventa este {sum} ");
        }

        /// <summary>
        /// reverse a number and return the result
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int reversedNum(int n)
        {
            int reversed = 0;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }
            return reversed;
        }


        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        static void P12()
        {
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");
            var line = ReadInputs();

            int sol = 0;
            int ant = 0;
            foreach (int e in line)
            {
                if (ant == 0 && e != 0)
                    sol++;
                ant = e;
            }
            Console.WriteLine($"Sunt {sol} grupuri de nr consecutive diferite de 0");
        }

        /// <summary>
        /// O .secventa crescatoare rotita. este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        static void P13()
        {
            Console.WriteLine("O .secventa crescatoare rotita. este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive \n(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). \nDeterminati daca o secventa de n numere este o secventa crescatoare rotita.");
            var line = ReadInputs();

            for (int i = 0; i < line.Length - 1; i++)
            {
                bool isSorted = true, isGrowing = true;
                monoton(line, ref isSorted, ref isGrowing);
                if (isSorted)
                {
                    if (isGrowing)
                    {
                        Console.WriteLine("Secventa este monotona rotita (crescatoare)");
                        return;
                    }
                }
                rotateToLeft(ref line);
            }
            Console.WriteLine("Secventa nu este crescatoare rotita");
        }

        /// <summary>
        /// O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        static void P14()
        {
            //simulez n-1 rotiri si pt fiecare rotire incerc sa vad daca secventa poate fi monotona, folosindu-ma de rezolvarea de la problema 9
            Console.WriteLine("O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.");
            var line = ReadInputs();

            for (int i = 0; i < line.Length - 1; i++)
            {
                bool isSorted = true, isGrowing = true;
                monoton(line, ref isSorted, ref isGrowing);
                if (isSorted)
                {
                    if (isGrowing)
                        Console.WriteLine("Secventa este monotona rotita (crescatoare)");
                    else
                        Console.WriteLine("Secventa este monotona rotita (descescatoare)");
                    return;
                }
                rotateToLeft(ref line);
            }

            Console.WriteLine("Secventa nu este monotona rotita");
        }

        /// <summary>
        /// rotate the actual array to left with one position (the leftmost element become the last after the rotation)
        /// </summary>
        /// <param name="arr"></param>
        public static void rotateToLeft(ref int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i + 1];
            arr[arr.Length - 1] = temp;
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        static void P15()
        {
            Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            var line = ReadInputs();

            if (isBitonic(line))
                Console.WriteLine("Secventa este bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica");
        }
        /// <summary>
        /// returns true if the given array is bitonic and false otherwise
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool isBitonic(int[] arr)
        {
            int posMax = Array.IndexOf(arr, arr.Max());

            if (posMax == 0 || posMax == arr.Length)
                return false;

            for (int i = 0; i < posMax; i++)
                if (arr[i] > arr[i + 1])
                    return false;

            for (int i = posMax; i < arr.Length - 1; i++)
                if (arr[i] < arr[i + 1])
                    return false;

            return true;
        }

        /// <summary>
        /// O .secventa bitonica rotita. este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        static void P16()
        {
            Console.WriteLine("O .secventa bitonica rotita. este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            var line = ReadInputs();

            bool sol = false;
            for (int i = 0; i < line.Length - 1 && !sol; i++)
            {
                if (isBitonic(line))
                    sol = true;
                rotateToLeft(ref line);
            }

            if (sol)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");

        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        static void P17()
        {
            Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.\nDeterminati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. \nDe exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");
            var line = ReadInputs();

            int level = 0;
            if (line.Length % 2 != 0)
            {
                Console.WriteLine($"Secventa contine un numar impar de paranteze, deci nu este corecta");
                return;
            }

            Stack<int> s = new Stack<int>();
            foreach (int e in line)
            {
                if (s.Count == 0)
                    s.Push(e);
                else
                {
                    if (e == 1 && s.Peek() == 0)
                        s.Pop();
                    else
                    {
                        s.Push(e);
                        if (s.Count > level)
                            level = s.Count;
                    }
                }
            }

            if (s.Count == 0)
                Console.WriteLine($"Parantezele sunt puse corect,iar nivelul de incuibare este {level}");
            else
                Console.WriteLine("Secventa de paranteze nu este corecta");
        }
    }
}
