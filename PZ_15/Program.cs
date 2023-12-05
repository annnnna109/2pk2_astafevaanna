namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь к каталогу: ");
            string directoryPath = Console.ReadLine();

            // Проверка наличия каталога по указанному пути
            if (Directory.Exists(directoryPath))
            {
                // Получение списка файлов в каталоге
                string[] files = Directory.GetFiles(directoryPath, "*.exe");

                // Вывод информации о каждом файле в списке
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Console.WriteLine($"Имя файла: {fileInfo.Name}, " +
                                      $"Время создания: {fileInfo.CreationTime}");
                }
            }
            else
            {
                Console.WriteLine("Каталог не найден");
            }

            Console.ReadLine();

        }
    }
}
