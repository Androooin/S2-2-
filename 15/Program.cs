// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int num = ReadInt("Введите цифру обозначаующую день недели ");
if (Result(num) == -1)
{
    Console.WriteLine($"Ваше число {num} означает выходной день");
}
else
{
    Console.WriteLine($"Ваше число {num} означает что это не выходной день");
}
Lutsenko();


//Метод (авторство)
void Lutsenko()
{
    Console.WriteLine("                               Автор работы Луценко А.С.");
}
//Метод (выявляем выходной день)
int Result(int Num)
{
    if (Num == 6 || Num == 7)
    {
        Num = -1;
    }
    return Num;
}
//Метод(ввод числа)
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}