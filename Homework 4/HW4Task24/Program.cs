// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Input A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B");
int B = Convert.ToInt32(Console.ReadLine());

int i = 1;
int product = A;

    while (i < B)
    { 
        i++;
        product = product * A;
    }
 
 Console.WriteLine (product);

