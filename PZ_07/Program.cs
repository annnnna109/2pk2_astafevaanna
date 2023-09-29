namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] arr = new char[8, 6];

            // Заполнение массива символами в порядке увеличения
            char symbol = 'A';
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = symbol;
                    symbol++;
                }
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            // Обмен первой и последней строки
            SwapRows(arr, 0, 7);

            Console.WriteLine("Измененный массив:");
            PrintArray(arr);

            Console.ReadLine();
        }

        // Метод для вывода массива
        static void PrintArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Метод для обмена строк массива
        static void SwapRows(char[,] arr, int row1, int row2)
        {
            int cols = arr.GetLength(1);
            for (int i = 0; i < cols; i++)
            {
                char temp = arr[row1, i];
                arr[row1, i] = arr[row2, i];
                arr[row2, i] = temp;
            }

        }
    }
}