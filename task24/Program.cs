// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до введенного числа: {sum}");

}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
GetSumNums(n);