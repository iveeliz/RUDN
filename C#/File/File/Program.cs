using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        string copyFilePath = "example_copy.txt";

        try
        {
            // Создание файла и запись данных
            Console.WriteLine("1. Создание файла и запись данных");
            GenerateTextFile(filePath);
            Console.WriteLine($"Файл '{filePath}' создан и данные записаны.\n");

            // Чтение данных из файла
            Console.WriteLine("2. Чтение данных из файла");
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"Содержимое файла:\n{content}\n");

            // Добавление данных в конец файла
            Console.WriteLine("3. Добавление данных в конец файла");
            File.AppendAllText(filePath, "Четвёртая строка файла.");
            Console.WriteLine("Данные добавлены в конец файла.\n");

            // Копирование файла
            Console.WriteLine("4. Копирование файла");
            File.Copy(filePath, copyFilePath, true);
            Console.WriteLine($"Файл '{filePath}' успешно скопирован в '{copyFilePath}'.\n");

            // Чтение данных из скопированного файла
            Console.WriteLine("5. Чтение данных из скопированного файла");
            string copyContent = File.ReadAllText(copyFilePath);
            Console.WriteLine($"Содержимое скопированного файла:\n{copyContent}\n");

            // Удаление файлов
            Console.WriteLine("6. Удаление файлов");
            File.Delete(filePath);
            File.Delete(copyFilePath);
            Console.WriteLine($"Файлы '{filePath}' и '{copyFilePath}' успешно удалены.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void GenerateTextFile(string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Пример текстового файла.");
            writer.WriteLine("Вторая строка файла.");
            writer.WriteLine("Третья строка файла.");
        }
    }
}
