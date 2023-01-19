// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int digitsQuantity = 1;

while (number/10 != 0)
{
    digitsQuantity ++;
    number = number / 10;
}

Console.WriteLine (digitsQuantity);