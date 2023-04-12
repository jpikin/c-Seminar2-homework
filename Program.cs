// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 < 1 || num / 100 >= 10)
    {
        while (num / 100 < 1 || num / 100 >= 10)
        {
            Console.Clear();
            Console.WriteLine("Введено не трехзначное число...");
            Console.WriteLine("Введите трехзначное число");
            num = Convert.ToInt32(Console.ReadLine());
        }    
    }

Console.WriteLine($"Вторая цифра этого числа - {num / 10 % 10}");