using System;
using System.Text;
using System.Threading.Tasks;
 
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                double z;

                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите символ (/,+,-,*): ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        z = x + y;
                        Console.WriteLine("x + y = " + z);
                        break;
                    case "-":
                        z = x - y;
                        Console.WriteLine("x - y = " + z);
                        break;
                    case "*":
                        z = x * y;
                        Console.WriteLine("x * y = " + z);
                        break;
                    case "/":
                        z = x / y;
                        Console.WriteLine("x / y = " + z);
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }

                Console.WriteLine(" ");
                Console.Write("Вы хотите продолжить? (да/нет): ");
                value = Console.ReadLine();
                Console.WriteLine(" ");
            }
            while (value == "да" || value == "Да" || value == "ДА");
        }
    }

}