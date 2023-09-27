// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



bool NumberOfDays( int number)
{
    if (number > 0 && number <= 7)
    {
        Console.Write($"{number} -> It's work day");
        return true;
    }
    else
    {
        Console.WriteLine($"{number} -> This day isn't exiting");
    }
    return false;
}
int DisplayDayOfWeek(int number)
{
    if (number > 5 && number <= 7)
    {
        Console.WriteLine($"{number} -> It's day off ");
    }
    return number;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

NumberOfDays(num);
DisplayDayOfWeek(num);
