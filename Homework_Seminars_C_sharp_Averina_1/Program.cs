// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// запрос первого числа от пользователя
        Console.WriteLine("Input number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

// запрос второго числа от пользователя
        Console.WriteLine("Input number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

// запрос третьего числа от пользователя
        Console.WriteLine("Input number3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

// ввод переменной, обозначающей максимальное числа
        int max = 0;


// сравнение чисел с помощью оператора ветвления

    if (number1>number2 && number1>number3)
        {
            max = number1;
        }

    if (number2>number1 && number2>number3)
    {
            max = number2;
    }
    
    if (number3>number1 && number3>number2)
    {
            max = number3;
    }
    
    if (number1 == number2 && number2 == number3)
    {  
            Console.WriteLine("Numbers are equal");
            return;
    }

// вывод в консоль чисел с присвоенными аттрибутами 0 наибольшего и наименьшего чисел
        Console.WriteLine($"the bigger number={max}");