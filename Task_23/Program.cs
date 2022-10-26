// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.WriteLine();

System.Console.Write($"Введите число: ");
string writeN = Console.ReadLine()!;
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    for (int i = 0, number = 1; i < N; i++, number++)
    {
        SqrtArray[i] = number * number * number;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);