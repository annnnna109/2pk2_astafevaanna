namespace PZ_14
{
    internal class Program
    {
            static void Main(string[] args)
            {
                // Введите номер строки, которую нужно удалить
                int k = int.Parse(Console.ReadLine());

                // Укажите путь к текстовому файлу
                string filePath = @"C:\путь\к\файлу.txt";

                // Проверяем, существует ли файл
                if (File.Exists(filePath))
                {
                    // Читаем все строки из файла в массив строк
                    string[] lines = File.ReadAllLines(filePath);

                    // Проверяем, существует ли строка с номером K
                    if (k >= 0 && k < lines.Length)
                    {
                        // Создаем новый список строк для хранения измененных строк файла
                        var updatedLines = new List<string>();

                        // Добавляем все строки, кроме строки с номером K, в список
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i != k)
                            {
                                updatedLines.Add(lines[i]);
                            }
                        }

                        // Перезаписываем файл с обновленным списком строк
                        File.WriteAllLines(filePath, updatedLines.ToArray());

                        Console.WriteLine("Строка с номером " + k + " успешно удалена.");
                    }
                    else
                    {
                        Console.WriteLine("Строка с номером " + k + " не существует.");
                    }
                }
                else
                {
                    Console.WriteLine("Указанный файл не существует.");
                }
            }
        

    }
}
