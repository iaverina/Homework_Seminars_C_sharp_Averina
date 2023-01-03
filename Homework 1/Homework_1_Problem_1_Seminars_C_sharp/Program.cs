// Задача 2: Напишите программу, которая на вход принимает два целых числа 
// и выдаёт, какое число большее, а какое меньшее.

// запрос первого числа от пользователя
        Console.WriteLine("Input number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

// запрос второго числа от пользователя
        Console.WriteLine("Input number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

// ввод переменных, обозначающих наибольшее и наименьшее числа
        int max = 0;
        int min = 0;

// сравнение чисел с помощью оператора ветвления

    if (number1>number2)
        {
            max = number1;
            min = number2;
        }

    if (number1<number2)
    {
            max = number2;
            min = number1;
    }
    
    if (number1 == number2)
    {  
            Console.WriteLine("Numbers are equal");
            return;
    }

// вывод в консоль чисел с присвоенными аттрибутами 0 наибольшего и наименьшего чисел
        Console.WriteLine($"the bigger number={max}");
        Console.WriteLine($"the lesser number={min}");