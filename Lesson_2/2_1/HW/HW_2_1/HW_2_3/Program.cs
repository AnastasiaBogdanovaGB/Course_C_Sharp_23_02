void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("Нет третьего числа");
        return;
    }

while (num > 999) num /=10;
Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()!));
