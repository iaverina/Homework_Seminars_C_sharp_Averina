// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Asking for input from the user
Console.Write("Enter a three-digit number: ");
int InitialNumber = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;

// Checking whether the entered number is a thee-digit number
int number=InitialNumber;
int numberOfDigits = 0;

while (number > 0)
        {
            int count=0;
            number = number % 10;
            count ++;
            numberOfDigits = count;
        }    

//if the condition is met then we proceed to checking the second digit
if (numberOfDigits ==3)
{
    secondDigit= (InitialNumber / 10 % 10);
    Console.Write($"the second digit of {InitialNumber} is {secondDigit}");
    return; 
}

else 
{
    Console.Write("the number of digits is incorrect");
    return;
}
