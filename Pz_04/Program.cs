namespace Pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            // Задание 1.

            for (int r = 0; r <= 90; r += 5) // Цикл с шагом 5 
            {
                Console.WriteLine(r); // Вывод числа
            }


            Console.WriteLine("Задание 2.");
            // Задание 2.

            char startChar = 'b';  // Начальный символ
            for (int d = 0; d < 6; d++) // Количество символов
            {
                char currentChar = (char)(startChar +d); // Вычисление текущего символа
                Console.WriteLine(currentChar + ""); // Вывод текущего символа
            }


            Console.WriteLine("Задание 3.");
            // Задание 3.

            for (int f = 0; f < 5; f++) // Цикл для строк
            {
                for (int h = 0;h < 4; h++) //Цикл для символов в строке
                {
                    Console.Write("#");  // Вывод символа "#"
                }
                Console.WriteLine(); // Переход на новую строку
            }


            Console.WriteLine("Задание 4.");
            // Задание 4.

            int count = 0; // Переменная для подсчета количества кратных чисел

            for (int k = -200; k <= 200; k++) // Цикл для перебора чисел в диапазоне
            {
                if (k % 7 == 0) // Проверка на кратность числа 7
                {
                    Console.Write(k + " "); // Вывод кратного числа с пробелом
                    count++; // Увеличение счетчика
                }
            }

            Console.WriteLine("\nКоличество кратных чисел: " + count); // Вывод количества кратных чисел


            Console.WriteLine("Задание 5.");
            // Задание 5.

            int i = 1;
            int j = 40;

            for (int aa = i, oo = j; j - aa >= 20; aa++, oo--)
            {
                Console.WriteLine("i: " + aa + ", j: " + oo);
            }
        }
    }

}