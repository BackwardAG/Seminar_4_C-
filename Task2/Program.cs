// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0; 

if (number / 10 > 0)
{
    while(number % 10 > 0 || number / 10 != 0)
    {
    
        sum = (sum + (number % 10));
        number = (number / 10);
    }
    System.Console.WriteLine(sum);
}
else
{
    System.Console.WriteLine("QQ");;
}





// if (number > 0)
// {
//     while (number > 10)
//     {
//         number /= 10;
//     }
//     sum = (sum + number);
//     System.Console.WriteLine(sum);
// }



    // for(int i = number; i > 0; i=i%10)
    // {
    //     System.Console.WriteLine(sum = sum + i);
        
    // }
    


