﻿// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе
// показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Мансур Рустэмович: Задача №7.

Console.Clear();
Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        
       for (int i = -n; i <= n; i++);
        
            Console.Write(i + " ");


