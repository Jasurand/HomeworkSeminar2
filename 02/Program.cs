// Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка

Console.Clear();
Console.Write("Введите, пожалуйста, координату точки по оси х (кроме 0): ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите, пожалуйста, координату точки по оси у (кроме 0): ");
int y = int.Parse(Console.ReadLine()!);
if (x == 0 || y == 0)
    Console.WriteLine("Вы почему-то ввели 0, не смотря на то, что мы вас просили не вводить");
else if (x > 0 && y > 0)
    Console.WriteLine("1");
else if (x > 0 && y < 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else if (x < 0 && y > 0)
    Console.WriteLine("4");

