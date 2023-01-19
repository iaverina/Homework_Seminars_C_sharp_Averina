// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int digitsQuantity = 1;

while (number/10 != 0)
{
    digitsQuantity ++;
    number = number / 10;
}

int digitsSum = 1;

    for (int i = 1; i<= digitsQuantity; i ++)
{
    digitsSum += number;
}

Console.WriteLine (digitsSum);

