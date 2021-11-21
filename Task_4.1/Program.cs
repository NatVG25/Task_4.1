using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое положительное целое число"); //Ввод исходного числа
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum = 0; //инициализвция переменной Sum
            for (int i = 1; i <= n; i++) //задание цикла с параметром
            {
                int q = 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, Sum += q); //вывод результата
            }
            Console.ReadKey();
        }
    }
}
