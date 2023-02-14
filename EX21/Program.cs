//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между 
//ними в 2D пространстве.

Console.Clear();

Console.WriteLine("Введите число х1 :");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число у1:");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число х2 :");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число у2:");
int y2 = int.Parse(Console.ReadLine()!);



double yy = Math.Pow((y1 - y2), 2);
double xx = Math.Pow((x1 - x2), 2);
double a = Math.Sqrt(yy + xx);
//a = Math.Round(a, 2);
Console.WriteLine($"Расстояние между точками равно:  {a:f2} ");