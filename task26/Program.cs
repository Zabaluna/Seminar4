// Задача 26: Напишите программу, которая принимает на вход число и выдаёт
//  количество цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetCountNums(num);
Console.WriteLine($"Количество цифр = {sum}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


int GetCountNums(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;   //number = number/10
    }
    return count;
}