using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем переменные
            double number1, number2;
            string calc;

            Console.WriteLine("Введите первое число");
            number1 = double.Parse(Console.ReadLine()); //Используем явное преобразование

            Console.WriteLine("Введите второе число");
            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+', '-', '*', '/'");
            calc = Console.ReadLine();

            switch (calc)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    if (number2 == 0) //Проверка деления на 0
                    {
                        Console.WriteLine("На 0 делить нельзя.");
                    }
                    else
                    {
                        Console.WriteLine(number1 / number2);
                    }
                    break;
                default:
                    Console.WriteLine("Неверный оператор");
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
