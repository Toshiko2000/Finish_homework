// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел.

Console.Clear();
Console.Write("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите В: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите С: ");
int C = Convert.ToInt32(Console.ReadLine());
int maxNumbers = A ;
if (maxNumbers<B)
maxNumbers = B;
if (maxNumbers < C)
maxNumbers = C;
Console.Write(maxNumbers);