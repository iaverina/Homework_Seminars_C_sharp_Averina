// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
Console.WriteLine("Input firstOf8");
int firstOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input secondOf8");
int secondOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input thirdOf8");
int thirdOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input fourthOf8");
int fourthOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input fifthOf8");
int fifthOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input sixthsOof8");
int sixthsOof8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input seventhOf8");
int seventhOf8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input eighthOf8");
int eighthOf8 = Convert.ToInt32(Console.ReadLine());

int[] arrayOf8 = {firstOf8, secondOf8, thirdOf8, fourthOf8, fifthOf8, sixthsOof8, seventhOf8, eighthOf8};;

Console.WriteLine(string.Join(", ", arrayOf8));