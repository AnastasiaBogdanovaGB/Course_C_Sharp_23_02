<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "Weekend";
    else if (num < 6 && num > 0) text = "Рабочий";
    else text = "не число недели";
    Console.WriteLine($"{num} -> {text}");

}
Weekend(int.Parse(Console.ReadLine()!));
>>>>>>> 2_Lesson
