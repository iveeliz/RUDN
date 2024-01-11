using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Создаем два экземпляра класса Random
        Random random1 = new Random();
        Random random2 = new Random();

        // Генерируем набор данных
        List<double> data1 = GenerateData(random1, 50);
        List<double> data2 = GenerateData(random2, 50);

        // Выводим сгенерированные данные на консоль
        Console.WriteLine("Сгенерированные данные:");
        Console.WriteLine("Data1: " + string.Join(", ", data1.Select(d => d.ToString("F4"))));
        Console.WriteLine("Data2: " + string.Join(", ", data2.Select(d => d.ToString("F4"))));

        // Рассчитываем коэффициент корреляции
        double correlation = CalculateCorrelation(data1, data2);

        // Выводим результат
        Console.WriteLine($"Коэффициент корреляции: {correlation:F4}");
    }

    static List<double> GenerateData(Random random, int count)
    {
        // Генерируем набор данных
        List<double> data = new List<double>();
        for (int i = 0; i < count; i++)
        {
            data.Add(random.NextDouble());
        }
        return data;
    }

    static double CalculateCorrelation(List<double> data1, List<double> data2)
    {
        // Проверяем, что данные имеют одинаковую длину
        if (data1.Count != data2.Count)
        {
            throw new ArgumentException("Длины массивов данных должны быть одинаковыми");
        }

        // Рассчитываем средние значения
        double mean1 = data1.Average();
        double mean2 = data2.Average();

        // Рассчитываем числитель и знаменатель для формулы корреляции Пирсона
        double numerator = data1.Select((x, i) => (x - mean1) * (data2[i] - mean2)).Sum();
        double denominator1 = Math.Sqrt(data1.Select(x => Math.Pow(x - mean1, 2)).Sum());
        double denominator2 = Math.Sqrt(data2.Select(x => Math.Pow(x - mean2, 2)).Sum());

        // Рассчитываем коэффициент корреляции
        double correlation = numerator / (denominator1 * denominator2);

        return correlation;
    }
}
