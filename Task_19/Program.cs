/* Задача 19
   Напишите программу, которая принимает на вход 
   пятизначное число и проверяет, является ли оно палиндромом.
 
   14212 -> нет
   12821 -> да
   23432 -> да
*/

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int reverse = 0;


int ReverseNumber(int num)
{
    while (num != 0)
    {
        reverse *= 10;
        reverse += num % 10;
        num = num / 10;
    }
    return reverse;
}

bool IsPalindrome(int ReverseNumber)
{
    
    if (num < 0) return false;
    if (num % 10 == 0) return false;
    if (num < 10) return true;
    if (num == reverse || num == reverse / 10)
    {
        return true;
    }
    else if (num != reverse) 
    {
        return false;
    } 
    return true || false;
}


if (IsPalindrome(ReverseNumber(num)))
{
    Console.WriteLine($"{num} -> Да");
}
else
{
    Console.WriteLine($"{num} -> Нет");
}