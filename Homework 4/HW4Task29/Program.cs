// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine("Input left border of array");
int left = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input left border of array");
int left = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int size, int left, int right)
{
int[] array = new int[size];
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(left, right+1);
}
return array;
}
int size = 8;
int left = -9;
int right = 9;
int[] massive = GetRandomArray(size, left, right);
Console.WriteLine(string.Join(", ", massive));
for (int i = 0; i < size; i++)
{
massive[i] = massive[i] * (-1);
}
Console.WriteLine(string.Join(", ", massive));