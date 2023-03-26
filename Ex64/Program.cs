// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int GetNumbersFromMToN(int number1, int number2)
{
    if(number1>number2) return number2;
    
    else
    {
        Console.Write(number1 + ", ");
        number1++;
    
    }
    
    return GetNumbersFromMToN(number1++, number2);

}

Console.WriteLine("Enter M: ");
int numStart = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Enter M: ");
int numFinish = Convert.ToInt32(Console.ReadLine());

GetNumbersFromMToN(numStart,numFinish);