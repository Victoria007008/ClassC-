Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 >= number2)
{
    Console.Write($"максимальное число { number1}");
}
else
{
    Console.Write($"максимальное число { number2}");
}