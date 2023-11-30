// Задача 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите, пожалуйста, любое число между 10 и 99: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10 || number > 99)
    Console.WriteLine("Вы ввели неверное число!");
else if ((number / 10) > (number % 10))
    Console.WriteLine(number / 10);
else 
    Console.WriteLine(number % 10);
