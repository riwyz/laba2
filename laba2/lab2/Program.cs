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


            switch (oper)
            {
                case '+':
                    break;
                case '-':
                    Console.WriteLine(a - b);
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