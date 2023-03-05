<<<<<<< HEAD
﻿string NumSec(int num)
{
    if ((-1000 < num < -100) || (num < 1000 && num > 100))
        
        return $"{num / 10 % 10}";
    return "Нет";
}

Console.WriteLine(NumSec(int.Parse(Console.ReadLine()!)));
=======
﻿
void NumRendom()
{
    int num = numRandom().Next(100, 1000);
    Console.WriteLine($"{num} {num / 100}{num % 10}");
}

>>>>>>> 2_Lesson
