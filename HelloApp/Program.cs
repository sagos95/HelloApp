// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber, secondNumber, lastNumber;
        Console.WriteLine("Введите первое число - ");

        firstNumber = Convert.ToString (Console.ReadLine());

        Console.WriteLine("Введите второе число - ");

        secondNumber = Convert.ToString(Console.ReadLine());

        string simvol;
        Console.WriteLine("Выберите действие: '+' '-' '*' '/');
            simvol = Console.ReadLine();

        for (simvol == "+")
            {
            Console,WriteLine(firstNumber + secondNumber);

        }

        else if (simvol == "-")
        {
            Console,WriteLine(firstNumber - secondNumber);

        }
        else if
        {
            simvol = '-';
            Console.WriteLine(firstNumber - secondNumber);

        }
    }
} 