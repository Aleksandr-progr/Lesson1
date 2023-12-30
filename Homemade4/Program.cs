// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
using System;
using System.Collections.Generic; // Добавьте эту строку для использования списка

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = int.Parse(Console.ReadLine()); // Используйте int.Parse вместо Convert.ToInt32 для простоты
        List<int> digits = new List<int>(); // Создайте список для хранения цифр числа
        while (N > 0)
        {
            int currentDigit = N % 10;
            N /= 10;
            digits.Add(currentDigit); // Добавьте текущую цифру в список
        }
        digits.Reverse(); // Переверните список, чтобы цифры были в правильном порядке
        Console.WriteLine(string.Join(",", digits)); // Используйте метод string.Join для вывода цифр через запятую
    }
}

