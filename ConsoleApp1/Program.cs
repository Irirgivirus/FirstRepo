using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sultanova Karina");

            Console.WriteLine("Введите два числа для подсчета суммы:");
            //int FirstNumber, SecondNumber;
            Calc calculation = new Calc();
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = calculation.Add(FirstNumber, SecondNumber);

            Console.WriteLine("Сумма = " + sum);
            Console.ReadLine();
            Console.ReadLine();
        }

        class Calc
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
