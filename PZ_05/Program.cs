namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10; // Начальный пробег спортсмена
            int day = 1; // Номер текущего дня

            while (distance < 20) // Проверка пробега спортсмена
            {
                distance += distance * 0.1; // Увеличение пробега на 10%

                day++; // Увеличение номера дня
            }

            Console.WriteLine($"Пробег спортсмена составит не менее 20 километров на {day} день");
        }
    
    
    }
}