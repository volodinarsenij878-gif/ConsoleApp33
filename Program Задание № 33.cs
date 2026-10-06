using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву латиницы (заглавную): ");
            char upper = Console.ReadLine()[0];
            int code = upper + 32; // в ASCII между заглавной и строчной 32
            char lower = (char)code;

            Console.WriteLine($"Исходный символ: {upper} (код {(int)upper})");
            Console.WriteLine($"Код + 32: {code}");
            Console.WriteLine($"Результат: {lower} (код {(int)lower})");
        }
    }
}