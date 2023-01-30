// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// 

System.Console.WriteLine("Введите число, A");
System.Console.WriteLine("Введите число, B");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

while (numberA > 0 && numberB > 0)
{
    System.Console.WriteLine(Math.Pow(numberA, numberB));
    break;

}


// int Power(int numberP)
// {
//     int numberA = Convert.ToInt32(Console.ReadLine());
//     int numberB = Convert.ToInt32(Console.ReadLine());
//     while (numberA > 0 && numberB > 0)
//     {
//         System.Console.WriteLine(Math.Pow(numberA, numberB));
//         break;
//     } 
//     return numberP;
// }
