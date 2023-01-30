// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0,9);
    }
}

void PrintArray(int[] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    System.Console.Write("]");
}


int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);
System.Console.WriteLine();

