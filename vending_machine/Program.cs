using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace myApp
{
    class VendingMachine
    {
        public List<int> AvailableCoins = new List<int>();
        private int TotalValue { get; set; }
        private int ProductValue { get; set; }

        public void SetProductValue()
        {
            bool stop = false;
            while (!stop)
            {
                Console.Write("Alege valoarea pe care o are produsul din aparat: ");
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    ProductValue = value;
                    stop = true;
                }
            }
        }

        public void SetAvailableCoins()
        {
            bool stop = false;
            while (!stop)
            {
                Console.Write("Alege valoarea pe care o poate avea moneda (sau \"next\" pentru pasul urmator): ");
                string input = Console.ReadLine();
                if (input.CompareTo("next") == 0)
                {
                    if (AvailableCoins.Count != 0)
                        stop = true;
                    else
                        Console.WriteLine("trebuie sa existe cel putin un tip de moneda pentru a se putea cumpara un produs! ");
                }
                else
                    try
                    {
                        AddCoin(int.Parse(input));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
            }
        }

        public void Action()
        {
            bool stop = false;
            while (!stop)
            {
                Console.Write("Alege valoarea monedei pe care vrei sa o introduci in aparat (sau \"stop\" pentru oprire): ");
                string input = Console.ReadLine();
                if (input.CompareTo("stop") == 0)
                    stop = true;
                else
                {
                    try
                    {
                        Insert(int.Parse(input));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        private void AddCoin(int value)
        {
            AvailableCoins.Add(value);
            AvailableCoins.Sort();
        }
        private void Insert(int value)
        {
            if (AvailableCoins.Contains(value))
            {
                TotalValue += value;
                while (TotalValue >= ProductValue)
                {
                    DispenseProducts(TotalValue / ProductValue);
                    DispenseRemainder(TotalValue % ProductValue);
                }
            }
            else
                CoinDoesNotExistMessage(value);
        }
        private void DispenseProducts(int count)
        {
            TotalValue -= ProductValue * count;
            Console.WriteLine($"felicitari! Ai primit {count} produse in valoare de {ProductValue * count} bani! ");
        }
        private void DispenseRemainder(int value)
        {
            if (value > 0)
            {
                Console.WriteLine($"restul dumneavoastra este {value} bani si il puteti primi astfel: ");
                for (int i = AvailableCoins.Count - 1; i >= 0 && value > 0; i--)
                {
                    while (value >= AvailableCoins[i])
                    {
                        Console.Write($"{AvailableCoins[i]} ");
                        value -= AvailableCoins[i];
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Dupa impartirea restului, raman {value} bani in aparat");
            }
            else
                Console.WriteLine($"Nu exista rest in aparat");
        }

        private void CoinDoesNotExistMessage(int value)
        {
            Console.Write($"nu exista o moneda cu valoarea de {value} centi, doar: ");
            foreach (var coin in AvailableCoins)
            {
                Console.Write($"{coin} ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Machine = new VendingMachine();
            Machine.SetProductValue();
            Machine.SetAvailableCoins();
            Machine.Action();
        }
    }
}
