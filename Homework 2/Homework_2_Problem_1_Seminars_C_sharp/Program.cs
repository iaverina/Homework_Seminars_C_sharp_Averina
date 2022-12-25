// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Asking for input from the user
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;

// Checking whether the entered number is a thee-digit number
int numberOfDigit=0;
int count=0;

    while (number > 0)
        {
            number = number / 10;
            count++;
        }    

//if the condition is met then we proceed to checking the second digit
if (numberOfDigit ==3)
    {
        secondDigit= (number / 10) - (number / 100);
        Console.Write($"the number od digits is, {numberOfDigit}");    }

else Console.Write("the number of digits is incorrect");
return;

