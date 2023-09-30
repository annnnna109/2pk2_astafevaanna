namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 15; // Задаем размеры массива
            int[] columns = new int[rows];

            Random random = new Random(); // Заполняем массив с произвольными значениями для второго измерения
            for (int i = 0; i < rows; i++)
            {
                columns[i] = random.Next(2, 25); // Генерируем случайное значение от 2 до 25
            }

            string[][] array = new string[rows][]; // Создаем ступенчатый массив строк

            for (int i = 0; i < rows; i++) // Заполняем массив значениями по произвольной формуле
            {
                array[i] = new string[columns[i]];
                for (int j = 0; j < columns[i]; j++)
                {
                    array[i][j] = $"[{i + 1}, {j + 1}]";
                }
            }

            Console.WriteLine("Сгенерированный массив:"); // Выводим сгенерированный массив в консоль;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine(); // Переход на новую строку
            }

            string[] lastElements = new string[rows]; // Создаем новый одномерный массив и записываем в него последние элементы каждой строки
            for (int i = 0; i < rows; i++)
            {
                lastElements[i] = array[i][columns[i] - 1];
            }

            Console.WriteLine("\nПоследние элементы каждой строки:"); // Выводим массив последних элементов в консоль
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(lastElements[i]);
            }

            string[] maxElements = new string[rows]; // Создаем новый одномерный массив и записываем в него максимальные элементы каждой строки
            for (int i = 0; i < rows; i++)
            {
                string maxElement = array[i][0];
                for (int j = 1; j < columns[i]; j++)
                {
                    if (String.Compare(array[i][j], maxElement) > 0)
                    {
                        maxElement = array[i][j];
                    }
                }
                maxElements[i] = maxElement;
            }

            Console.WriteLine("\nМаксимальные элементы каждой строки:"); // Выводим массив максимальных элементов в консоль
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(maxElements[i]);
            }

            for (int i = 0; i < rows; i++) // Меняем местами первый элемент и максимальный элемент в каждой строке
            {
                string temp = array[i][0];
                array[i][0] = maxElements[i];
                maxElements[i] = temp;
            }

            Console.WriteLine("\nОбновленный массив:"); // Выводим обновленный массив в консоль
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine(); // Переход на новую строку
            }

            for (int i = 0; i < rows; i++) // Реверс каждой строки ступенчатого массива
            {
                Array.Reverse(array[i]);
            }

            Console.WriteLine("\nМассив с реверсированными строками:"); // Выводим массив с реверсированными строками в консоль
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine(); // Переход на новую строку  // Подсчитываем общее количество символов в строках каждой строки
            }

        }
    }
}