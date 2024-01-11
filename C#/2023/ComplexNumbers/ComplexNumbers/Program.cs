using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ComplexNumbers
{
    static void Main()
    {
        Console.Write("Введите действительную часть первого комплексного числа: ");
        double Re1 = double.Parse(Console.ReadLine());

        Console.Write("Введите мнимую часть первого комплексного числа: ");
        double Im1 = double.Parse(Console.ReadLine());

        Console.Write("\nВведите действительную часть второго комплексного числа: ");
        double Re2 = double.Parse(Console.ReadLine());

        Console.Write("Введите мнимую часть второго комплексного числа: ");
        double Im2 = double.Parse(Console.ReadLine());

        ComplexNumber complex1 = new ComplexNumber(Re1, Im1);
        ComplexNumber complex2 = new ComplexNumber(Re2, Im2);

        // Вывод комплекных чисел
        Console.WriteLine($"\nКомплексное число 1: {Re1} + {Im1}i");
        Console.WriteLine($"Комплексное число 2: {Re2} + {Im2}i");

        // Сложение
        ComplexNumber sum = complex1.Add(complex2);
        Console.WriteLine($"\nСумма: {sum}");

        // Умножение
        ComplexNumber product = complex1.Prod(complex2);
        Console.WriteLine($"Произведение: {product}");

        // Абсолютная величина (модуль)
        double abs1 = complex1.Abs;
        double abs2 = complex2.Abs;
        Console.WriteLine($"\nАбсолютная величина a: {abs1}");
        Console.WriteLine($"Абсолютная величина b: {abs2}");

        // Аргумент
        double arg1 = complex1.Arg;
        double arg2 = complex2.Arg;
        Console.WriteLine($"\nАргумент a: {arg1} радиан");
        Console.WriteLine($"Аргумент b: {arg2} радиан");
    }
}

public class ComplexNumber
{
    private double Re;
    private double Im;

    // Конструктор для создания комплексного числа
    public ComplexNumber(double real, double imaginary)
    {
        Re = real;
        Im = imaginary;
    }

    // Метод: сложение двух комплексных чисел
    public ComplexNumber Add(ComplexNumber other)
    {
        double ReResult = Re + other.Re;
        double ImResult = Im + other.Im;
        return new ComplexNumber(ReResult, ImResult);
    }

    // Метод: умножение двух комплексных чисел
    public ComplexNumber Prod(ComplexNumber other)
    {
        double ReResult = (Re * other.Re) - (Im * other.Im);
        double ImResult = (Re * other.Im) + (Im * other.Re);
        return new ComplexNumber(ReResult, ImResult);
    }

    // Метод: вычисление модуля (абсолютной величины) комплексного числа
    public double Abs
    {
        get
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }
    }

    // Метод: вычисление аргумента (угла) комплексного числа в радианах
    public double Arg
    {
        get
        {
            return Math.Atan2(Im, Re);
        }
    }

    // Вывод комплексного числа
    public override string ToString()
    {
        return $"{Re} + {Im}i";
    }
}