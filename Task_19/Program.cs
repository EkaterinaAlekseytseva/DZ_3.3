// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int len = number.Length;

int Palindrome(int len)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
    return len;
}

if (len == 5)
{
    Palindrome(len);
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}