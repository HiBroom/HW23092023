// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ThreeDigitNumber(string message)
{
    Console.Write(message);
    int vallue = Convert.ToInt32(Console.ReadLine());
    return vallue;
}


int number = ThreeDigitNumber("Input number: ");
if (number < 100 || number >= 999)
{
    Console.WriteLine("This number isn't three-digit number");
    return;
}

int SecondNumber = number / 10 % 10;
Console.WriteLine($"SecondNumber: {SecondNumber}");
