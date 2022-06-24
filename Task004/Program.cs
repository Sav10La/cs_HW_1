// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите диапазон, начиная с 1 ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все четные числа с 1 до {number}:");

int i = 2;

while (i <= number)
{
    Console.Write($"{i} ");
    i +=2;
}