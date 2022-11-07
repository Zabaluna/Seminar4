// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

void GetMultiplyNums(int number)
{
    int mul = 1;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        mul= mul * i;
    } 
    Console.WriteLine($"Произведение цифр от 1 до введенного числа: {mul}");

}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

GetMultiplyNums(n);