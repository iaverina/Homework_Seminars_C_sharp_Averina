// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.WriteLine("Input A");

int A = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;

while (i<A)
{ 
    i++;
    sum = sum + i;
}
Console.WriteLine (sum);