namespace PZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            int a1 = 2;
            int d = 6;

            Console.WriteLine("Введите номер члена прогрессии: ");
            int n = int.Parse(Console.ReadLine());

            int an = CalculateNthTerm(a1, d, n);
            Console.WriteLine($"n-ый член прогрессии: {an}");

            static int CalculateNthTerm(int a1, int d, int n)
            {
                if (n == 1)
                {
                    return a1;
                }
                else
                {
                    return CalculateNthTerm(a1, d, n - 1) + d;
                }
            }

            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите номер элемента в геометрической прогрессии:");
            int s = Convert.ToInt32(Console.ReadLine());
            int result = CalculateGeometricProgression(2, 0/5, n);
            Console.WriteLine($"n-ый член геометрической прогрессии: {result}");

            static int CalculateGeometricProgression(int b1, int q, int n)
            {
                if (n == 1)
                {
                    return b1;
                }
                else
                {
                    return q * CalculateGeometricProgression(b1, q, n - 1);
                }
            }

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число B:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Все числа от A до B: ");
            if (A < B)
            {
                PrintNumbersAscending(A, B);
            }
            else
            {
                PrintNumbersDescending(A, B);
            }



            static void PrintNumbersAscending(int A, int B)
            {
                if (A <= B)
                {
                    Console.WriteLine(A);
                    PrintNumbersAscending(A + 1, B);
                }
            }

            static void PrintNumbersDescending(int A, int B)
            {
                if (A >= B)
                {
                    Console.WriteLine(A);
                    PrintNumbersDescending(A - 1, B);
                }
            }
        }
    }

}


    





