void Main()
{
	while (true)
	{
		int task = ReadInt("номер задания");

		switch (task)
		{
			case 34: Task34(); break;
	        case 36: Task36(); break;
	        case 38: Task38(); break;
		}
	}
}

void Task34() // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
{
    int[] threeDigitNumbersArray = GetArray(10, 100, 999);
    PrintArray(threeDigitNumbersArray);
    AmountEvenNumbers(threeDigitNumbersArray);

    void AmountEvenNumbers(int[] array)
    {
        int amount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            amount++;
        }

        Console.WriteLine($"Количество чётных чисел в массиве равняется {amount}.");
    }
}


void Task36() // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
{
    int[] randomNumbersArray = GetArray(10, -30, 50);
    PrintArray(randomNumbersArray);
    SumElements(randomNumbersArray);

    void SumElements(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"Элемент {array[i]} стоит на позиции {i}");
                sum = sum + array[i];
            }
        }

        Console.WriteLine($"Сумма элементов массива на нечётных позициях равняется {sum}");
    }
}


void Task38() // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
{
    double[] realNumbersArray = GetRealNumbersArray(10, -5, 12);
    PrintRealArray(realNumbersArray);
    Console.WriteLine($"Максимальный элемент в массиве - {FindMax(realNumbersArray)}, минимальный элемент в массиве - {FindMin(realNumbersArray)}. Разница между максимальным и минимальным элементом массива равняется {FindMax(realNumbersArray) - FindMin(realNumbersArray)}");
    
    double [] GetRealNumbersArray(int length, int min, int max)
    {
        double[] array = new double [length];
        Random number = new Random();

        for (int count = 0; count < length; count++)
        {
            if (count % 2 == 0)
            array[count] = number.Next(min, max + 1) + number.NextDouble();
            else
            array[count] = number.Next(min, max + 1);
        }

        return array;        
    }

    void PrintRealArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(array[i],2);
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
    }

    double FindMin(double[] array)
    {
        double min = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            min = array[i];        
        }

        return min;        
    }

    double FindMax(double[] array)
    {
        double max = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            max = array[i];        
        }

        return max;        
    }
}

int ReadInt(string argument)
{
	Console.Write($"Введите {argument}: ");
    int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Ошибка ввода, пожалуйста, введите корректное число");
	}

    return number;
}

int [] GetArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random number = new Random();

    for (int count = 0; count < length; count++)
    {
        array[count] = number.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}