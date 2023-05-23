using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            char oper;

            Console.WriteLine("Введите первое число:");

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;
            }
        }
    }
}