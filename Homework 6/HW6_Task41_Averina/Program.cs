// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" 
// и производится при помощи нажатия Enter

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


Console.Write("Input as many integers as you like dividing them with space: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"The number of integers > 0 = {count}");