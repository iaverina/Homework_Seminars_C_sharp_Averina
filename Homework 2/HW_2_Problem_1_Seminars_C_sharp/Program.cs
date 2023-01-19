// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Asking for input from the user
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

// Checking if the number is three-digit
int numberOfDigit=DigitNumber(number);
if (numberOfDigit ==3)
   {
    int result = number / 10 % 10; 
    Console.WriteLine("The second digit of "+ number+ " is " + result);
   }

else
   {
    Console.WriteLine(""+ number + " is not a three-digit number!" );
    return;
   }

// Finding the second digit of the number
   int DigitNumber (int number)// Function to find number of digit
{
int numberOfDigit=0;
double buffer = number;
while (buffer>=1)
   {
    buffer=buffer/10;
    numberOfDigit++;
   }
return numberOfDigit;
}