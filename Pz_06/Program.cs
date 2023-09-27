namespace Pz_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[50]; int[] array2 = new int[50];
            Random random = new Random();
            // Заполняем первый массив случайными значениями от -100 до 100
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(-100, 101);
            }
            // Копируем значения из первого массива во второй массив, если они находятся в диапазоне от -10 до 10
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] >= -10 && array1[i] <= 10)
                {
                    array2[i] = array1[i]; sum += Math.Abs(array1[i]);
                }
            }
            Console.WriteLine("Исходный массив:");
            PrintArray(array1);
            Console.WriteLine("\nМассив со значениями от -10 до 10:"); PrintArray(array2);
            Console.WriteLine("\nСумма абсолютных значений: " + sum);
        }
        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}
    
