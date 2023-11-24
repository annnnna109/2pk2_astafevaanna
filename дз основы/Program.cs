using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_основы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача №1
            // Вводим значения боковой стороны и радиуса основания
            Console.WriteLine("Введите значение боковой стороны конуса:");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение радиуса основания конуса:");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Вызываем метод GetArea и выводим результат
            double area = GetArea(side, radius);
            Console.WriteLine("Площадь поверхности конуса: " + area);

            Console.ReadKey();
        }

        // Метод для вычисления площади поверхности конуса
        static double GetArea(double side, double radius)
        {
            // Формула для вычисления площади поверхности конуса
            double area = Math.PI * radius * (radius + Math.Sqrt(radius * radius + side * side));

            return area;
        }

        // Задача №2

    }
}
