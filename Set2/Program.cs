//Pecherle George-Daniel 10_25_2022
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
                    try {
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
                default: Console.WriteLine($"Problema cu numarul {n} nu exista :("); break;
            }
        }

        /// <summary>
        /// reads N and N integers, then returns these integers as an int type array
        /// </summary>
        /// <returns></returns>
        static int[] ReadInputs()
        {
            //basic reading
            Console.Write("Dati n, dupa care dati cele n numere pe linia urmatoare: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char[] separators = { ' ', ',', ':', ';' };
            string[] line = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] intsLine = Array.ConvertAll(line ,int.Parse);
            return intsLine;
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        static void P1()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            var line = ReadInputs();
            int counter = 0;
            foreach (int e in line)
            {
                if(e%2==0)
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
            var line = ReadInputs();
            int countNegatives = 0, countZero = 0, countPositives = 0;
            foreach (int e in line)
            {
                if(e<0) countNegatives++;
                else if(e==0) countZero++;
                else if(e>0) countPositives++;
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
            while (temp>0) 
            { 
                factorial *= temp;
                temp--;
            }
            Console.WriteLine($"Suma de la 1 la {n} este: {n*(n+1)/2}.\nProdusul de la 1 la n este {factorial}");
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
            for(int i=0;i<line.Length;i++)
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

        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        static void P6()
        {

        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        static void P7()
        {

        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        static void P8()
        {

        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        static void P9()
        {

        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        static void P10()
        {

        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        static void P11()
        {

        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        static void P12()
        {

        }

        /// <summary>
        /// O .secventa crescatoare rotita. este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        static void P13()
        {

        }

        /// <summary>
        /// O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        static void P14()
        {

        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        static void P15()
        {

        }

        /// <summary>
        /// O .secventa bitonica rotita. este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        static void P16()
        {

        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        static void P17()
        {

        }



    }
}
