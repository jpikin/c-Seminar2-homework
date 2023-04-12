// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num / 100 < 1 || num / 100 >= 10)
//     {
//         while (num / 100 < 1 || num / 100 >= 10)
//         {
//             Console.Clear();
//             Console.WriteLine("Введено не трехзначное число...");
//             Console.WriteLine("Введите трехзначное число");
//             num = Convert.ToInt32(Console.ReadLine());
//         }    
//     }

// Console.WriteLine($"Вторая цифра этого числа - {num / 10 % 10}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
string? num = Console.ReadLine();
if (num.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
else
    {
        Console.WriteLine(num[2]);
    }