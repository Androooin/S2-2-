// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
//  вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



int num = ReadInt("Введите трехзначное число ");

if (num > 99)
{
    if (num < 1000) Console.WriteLine($"Вторая цифра этого числа {SecondDigit(num)}");
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

Lutsenko();

// метод (авторство)
void Lutsenko()
{
    Console.WriteLine("                               Автор работы Луценко А.С.");
}
// метод (ввод числа)
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// метод (нахочдение 2 цифры в числе)
int SecondDigit(int NummberA)
{
    int result = (NummberA / 10) % 10;
    return result;
}

