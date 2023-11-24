namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                static void Main(string[] args)
                {
                    // Ввод значений интервала от пользователя
                    Console.WriteLine("Введите нижнюю границу интервала:");
                    int m = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите верхнюю границу интервала:");
                    int n = Int32.Parse(Console.ReadLine());

                    int summ;
                    GetSquareSumm(m, n, out summ); // Вызов метода GetSquareSumm с передачей выходного параметра summ

                    Console.WriteLine($"Сумма квадратов простых чисел в интервале ({m}..{n}) = {summ}");
                }

                static bool IsPrime(int number)
                {
                    // Проверка, является ли число простым
                    if (number < 2)
                        return false;

                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                            return false;
                    }
                    return true;
                }

                static void GetSquareSumm(int m, int n, out int summ)
                {
                    summ = 0;

                    // Вычисление суммы квадратов простых чисел в интервале (m..n)
                    for (int i = m; i <= n; i++)
                    {
                        if (IsPrime(i))
                            summ += i * i;
                    }
                }
            }

        }

    }
}

