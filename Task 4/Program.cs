﻿Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) 
    max = number2;
if (number3 > max) 
    max = number3;
Console.WriteLine($"Максимальное из трех: {max}");