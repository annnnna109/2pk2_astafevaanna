using System.Numerics;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(1, 2, 3, 4);
            Console.WriteLine("Исходный вектор: " + vector);

            double scalar = 2;
            Vector newVector = scalar * vector;
            Console.WriteLine($"Умножение вектора на скаляр ({scalar}): " + newVector);
        }
    }
}