// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int temp_num = num;
int sum = 0;
int ost = 1;

while (temp_num / 10 > 0)
{
    sum = sum + temp_num % 10;
    temp_num /= 10;
}

sum = sum + temp_num;

Console.WriteLine($"Cумма цифр в числе {num} = {sum}");
