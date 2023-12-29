﻿// Задача 1: Проверка кратности числа 7 и 23
using System;

class Program {
    static void Main() {
        // Считываем число a с клавиатуры и преобразуем его в целое число
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        // Проверяем, кратно ли число a одновременно 7 и 23, используя оператор остатка от деления (%)
        // Если остаток от деления числа a на 7 и на 23 равен нулю, то число кратно обоим делителям
        if (a % 7 == 0 && a % 23 == 0) {
            // Выводим "да" на экран, если число кратно 7 и 23
            Console.WriteLine("да");
        }
        else {
            // Выводим "нет" на экран, если число не кратно 7 и 23
            Console.WriteLine("нет");
        }
    }
}
