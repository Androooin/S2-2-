// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = ReadInt("Введите число ");

if (ThirdDigit(num) == -1)
    Console.WriteLine("Третьей цифры нет, введите число равное или более трехзначному");
else
    Console.WriteLine($"Третья цифра этого числа {ThirdDigit(num)}");

Lutsenko();

//Метод (нахождение 3 цифры)
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        for (int i = number; i > 99; i = i / 10)
        {
            number = i;
        }
        
        result = number % 10;
    }
    return result;
}
//Метод (авторство)
void Lutsenko()
{
    Console.WriteLine("                               Автор работы Луценко А.С.");
}
//метод(ввод числа)
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}