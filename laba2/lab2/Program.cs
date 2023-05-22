using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());


            switch (oper)
            {
                case '+':
                    Console.WriteLine(a+b);
                    break;
                case '-':
                    Console.WriteLine(a-b);
                    break;
                case '*':
                    Console.WriteLine(a*b);
                    break;
                case '/':
                    Console.WriteLine(a/b);
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;
            }
        }
    }
}