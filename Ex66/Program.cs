// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N с помощью рекурсии.

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void GetSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GetSum(numberM, numberN, sum);
}

GetSum(numberM, numberN, 0);