using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация двумерного массива слов
            string[,] wordsArray = new string[,]
          { { "Города:", "Страны:", "Океаны:" },
            { "Уфа", "Россия", "Тихий" },
            { "Оренбург", "Корея", "Атлантический" }
            };
            // Получение размерности массива
            int rows = wordsArray.GetLength(0);
            int columns = wordsArray.GetLength(1);
            // Создание и заполнение текстового массива
            string[] textArray = new string[columns];
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    textArray[j] += wordsArray[i, j] + " ";
                }
            }
            // Вывод полученного текста
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine(textArray[j]);

            }
        }
    }
}
