using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class StudentList
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.WriteLine("Введите информацию о студентах. Для завершения ввода введите пустую строку.");

        while (true)
        {
            Console.Write("\nВведите фамилию студента: ");
            string LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(LastName))
            {
                break;
            }

            Console.Write("Введите имя студента: ");
            string FirstName = Console.ReadLine();

            Console.Write("Введите отчество студента: ");
            string Patronymic = Console.ReadLine();

            Console.Write("Введите рейтинг студента: ");
            if (double.TryParse(Console.ReadLine(), out double rating))
            {
                students.Add(new Student { LastName = LastName, FirstName = FirstName, Patronymic = Patronymic, Rating = rating });
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный формат рейтинга.\n");
            }
        }

        Console.WriteLine("\nСписок студентов:");
        foreach (var student in students)
        {
            Console.WriteLine(student.LastName + " " + student.FirstName + " " + student.Patronymic + ", " + student.Rating);
        }

        Console.WriteLine($"\nКоличетво студентов в списке: {students.Count}");

        using var file = File.CreateText("Students.csv");

        foreach (var student in students)
        {
            file.WriteLine("{0}, {1}, {2}, {3}", student.LastName, student.FirstName, student.Patronymic, student.Rating);
        }

        file.Close();

        var encoding = Encoding.GetEncoding("UTF-8");
        using var csv = new StreamReader("Students2.csv", encoding);
        var students2 = new List<Student>();

        while (!csv.EndOfStream)
        {
            var line = csv.ReadLine();
            var items = line.Split(',');
            var student2 = new Student();

            student2.LastName2 = items[0];
            student2.FirstName2 = items[1];
            student2.Patronymic2 = items[2];
            student2.Rating2 = double.Parse(items[3]);

            students2.Add(student2);
        }

        file.Close();

        Console.WriteLine("\nСписок студентов 2:");
        foreach (var student2 in students2)
        {
            Console.WriteLine(student2.LastName2 + " " + student2.FirstName2 + " " + student2.Patronymic2 + ", " + student2.Rating2);
        }

        Console.WriteLine($"\nКоличетво студентов в списке: {students2.Count}");
    }
}

class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public double Rating { get; set; }
    public string LastName2 { get; set; }
    public string FirstName2 { get; set; }
    public string Patronymic2 { get; set; }
    public double Rating2 { get; set; }
}