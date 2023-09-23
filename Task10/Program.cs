// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit( int num)
{
    int thirdD = num / 10;
    int secondD = thirdD % 10;
    return secondD;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = SecondDigit(number);
Console.WriteLine($"SecondDigit -> {res}");
