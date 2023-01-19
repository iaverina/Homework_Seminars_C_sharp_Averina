// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Please enter day number from 1 to 7: ");
int dayNumber=Convert.ToInt32(Console.ReadLine());

if ((dayNumber > 7) || (dayNumber < 1))
{
    Console.WriteLine("Only digits from 1 to 7 are relevant here");
    return;
}

if (dayNumber > 5)
{
    Console.WriteLine("Weekend day");
}
else
{
    Console.WriteLine("Weekday");
}