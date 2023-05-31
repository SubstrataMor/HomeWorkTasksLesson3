// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Input()
{
    Console.WriteLine("Ведите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void CoubTable(int n)
{
    for (int i = 1; i < n + 1; i++)
    {
        int x = i * i * i;
        Console.Write($"{x}, ");
    }
}
int num = Input();
Console.Write($"Таблица кубов чисел от 1 до {num} = ");
CoubTable(num);