//  Задача 27: Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Cумма цифр введенного числа: {sum}");
}
GetSumNums(n);
