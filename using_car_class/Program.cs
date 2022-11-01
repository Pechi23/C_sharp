using System;

namespace using_car_class
{
    class Program
    {
        static void Main(string[] args)
        {
            cars myCar = new cars();
            myCar.name = "Bmw";
            Console.WriteLine(myCar.name);
        }
    }
}