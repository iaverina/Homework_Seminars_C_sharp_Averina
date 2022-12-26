// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
  Console.WriteLine("the third digit is: " + numberText[2]);
}
else
{
  Console.WriteLine("there is no third digit in this number");
}
