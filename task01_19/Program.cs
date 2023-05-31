// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// ============== Универсальное решение для любых целых чисел:
Console.WriteLine("Введите число:");
int count = Convert.ToInt32(Console.ReadLine());

void Compare(int number)
{
    if(number < 0 || (number % 10 == 0 && number != 0))
    {
        Console.WriteLine("false");
        return;
    }
    int num = 0;
    while(number > num)
    {
        num = num * 10 + number % 10;   // Разворот числа
        number /= 10;
    }
    Console.WriteLine($"{number == num || number == num / 10}");    // Сравнение числа с развернутым и вывод true/false 
}
Compare(count);





// ============== Универсальное решение для любого палиндрома (манипуляция с текстом):
// Console.WriteLine("Введите число:");
// string? count = Console.ReadLine();

// void Palindrome(string text)
// {
//     int lenght = text.Length;
//     for (int i = 0, j = lenght - 1; i <= j; i++, j--)
//     {
//         if (text[i] == text[j]) { Console.WriteLine($"Число {text} является палиндромом"); break; }
//         else { Console.WriteLine($"Число {text} не является палиндромом"); break; }
//     }
// }
// Palindrome(count);



// ============== Решение для пятизначного числа (надо доработать):
// Console.WriteLine("Введите число:");
// int count = Convert.ToInt32(Console.ReadLine());

// int Num1(int number)
// {
//     int num1 = 0;
//     while (num1 <=9 ^ num1 >=1)
//     {
//         number = number / 10;
//         num1 = number;
//     }
//     return num1;
// }
// int Num2(int number)
// {
//     int num2 = number % 10;
//     return num2;
// }
// void Compare(int num1, int num2, int number)
// {
//     if (num1 == num2)
//     {
//         while (num1 == num2)
//         {
//             int x = 10000;
//             number = number - x;
//             int newcount = number - num2;
//             num1 = Num1(newcount);
//             num2 = Num2(newcount);
//             x = x/100;
//             Console.WriteLine($"Число {count} является палиндромом.");
//         }
//     }
//     else {Console.WriteLine($"Число {count} не является палиндромом");}
// }
// Compare(Num1(count), Num2(count), count);





// ============== Решение преподавателя на семинаре:
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int number = Convert.ToInt32(value);
//     return number;
// }

// int ReverseNumber(int a)
// {
//     int revNum = 0;
//     int temp = a; // 12321
//     while (temp > 0)
//     {
//         revNum = revNum * 10 + temp % 10; // 0 + 1 // 10 + 2 = 12 // 120 + 3=123 // 1230 + 2 //12320  +1 //12321
//         temp /= 10; // 1232 // 123 // 12 // 1 // 0 

//     }
//     return revNum;
// }

// int a = Prompt("Введите 5-и значное число: ");
// int reversed = ReverseNumber(a);

// if (a > 9999 && a < 1000000)
// {
//     if (reversed == a)
//     {
//         Console.WriteLine("Число является полиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ является полиндромом.");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }