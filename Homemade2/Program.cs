// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
using System;

class Program {
    static void Main() {
        Console.Write("Введите координаты точки X и Y через пробел: ");
        string[] coordinates = Console.ReadLine().Split(' ');
        int x = int.Parse(coordinates[0]); // Используйте int.Parse вместо Convert.ToInt32 для простоты
        int y = int.Parse(coordinates[1]);
        if (x == 0 || y == 0) { // Проверьте сначала, что точка не находится на оси координат
            Console.WriteLine("Точка находится на оси координат");
        }
        else {
            int quadrant = 0; // Объявите переменную для хранения номера четверти
            if (x > 0) {
                quadrant = (y > 0) ? 1 : 4; // Используйте тернарный оператор для присваивания значения
            }
            else {
                quadrant = (y > 0) ? 2 : 3;
            }
            Console.WriteLine(quadrant); // Выведите значение переменной
        }
    }
}
