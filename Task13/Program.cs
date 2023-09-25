// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ThirdNumberIsNotExiting(int number)
{
    if(number < 100)
    {
        Console.WriteLine($"{number} -> Third digit isn't exeting");
        return false;
    }
    return true;
}


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int k = GetThirdRank(num);
if (ThirdNumberIsNotExiting(num))
{
    Console.WriteLine($"{num} -> {k}");
}







    