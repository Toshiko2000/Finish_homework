// Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
Console.WriteLine("Нет третьей цифры!!!");
else
{
    Console.WriteLine(InCenter(number));
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}