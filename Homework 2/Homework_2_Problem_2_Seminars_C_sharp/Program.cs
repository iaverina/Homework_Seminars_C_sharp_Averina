// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (number < -99 || number > 99)
{
    if (number > 0) Console.WriteLine($"the third number is = {number.ToString()[2]}");
    else Console.WriteLine($"the third number is = {number.ToString()[3]}");
}
else Console.WriteLine("there is no third number here");
