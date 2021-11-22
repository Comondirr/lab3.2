using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите накопления");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стипендию");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите расходы");
            double b = double.Parse(Console.ReadLine());
            double m = 0;
            for (int i = 0; s + a > b; i++)
            {
                s = s + a - b;
                b = b + b * 0.03;
                m = m + 1;
            }
            Console.WriteLine($"Студент проживет {m} месяцев");




        }

    }
}
