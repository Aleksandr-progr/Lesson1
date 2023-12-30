// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число из отрезка [10, 99]: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            int number = int.Parse(input); // Используйте int.Parse, если уверены, что input не null
            if (number < 10 || number > 99) // Проверьте, что число действительно принадлежит отрезку [10, 99]
            {
                Console.WriteLine("Некорректный ввод");
            }
            else
            {
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                int maxDigit = Math.Max(firstDigit, secondDigit); // Используйте метод Math.Max для нахождения максимума из двух чисел
                Console.WriteLine(maxDigit);
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}
