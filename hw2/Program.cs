// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num % 10;
int result2 = (num / 10) % 10;
// int result3 =

Console.WriteLine(result2);
