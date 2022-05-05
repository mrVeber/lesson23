using System;
using System.Threading;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для расчёта факториала: ");
            int n = Convert.ToInt32(Console.ReadLine());
            GetFactorialAsync(n);
            Console.ReadKey();
        }
        static void GetFactorial (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Факториал числа {n} равен: {result}");
        }

        static async void GetFactorialAsync(int n)
        {
            await Task.Run(()=> GetFactorial(n));
        }
    }
}
