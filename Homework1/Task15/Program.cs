// Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine()); 

if (n > 0 && n <= 5) {
    Console.WriteLine("Work day");
}
else if (n > 5 && n < 8) {
    Console.WriteLine("Holly day");
}
else {
    Console.WriteLine("no");
}

    // if (n > 0 && n < 8);
    //     else if (n == 7 ||  n == 6)
    //     {
    //         Console.Write("Под цифрой " + n + " - Выходной");
    //     }
    //     else if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5 )
    //     {
    //         Console.Write("Под цифрой " + n + " - Рабочий");
    //     }
