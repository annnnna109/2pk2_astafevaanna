using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную - а"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double a = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double
            Console.WriteLine("Введите переменную - b"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double b = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double
            Console.WriteLine("Введите переменную - с"); // Выводим строку подсказывающую какую переменную необходимо ввести
            double c = Convert.ToDouble(Console.ReadLine()); // Ввод любых значений в консоли, конвертируем строку в тип Double

            double result; // Переменная результата

            result = (3 * Math.Log(2)) * 8 / Math.Sin(Math.PI) / 3 * (2) - 3 * (Math.Sqrt(5) * (Math.Pow(2, 2) + 7) + 4 * (Math.Abs(0 - 2 * 2) + 1)) / (Math.Sqrt(8 * 2)); // Математическое уравнение


            Console.WriteLine(result); // Вывод результата
            Console.WriteLine(); // Необходимо чтобы окно консоли не закрывалось после запуска
        }
    }
}