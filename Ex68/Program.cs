// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД)
// этих чисел с помощью рекурсии.

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
FindGreatestCommonDivisor(M, N);

void FindGreatestCommonDivisor(int M, int N)
{
 if (M > N) M = M - N;
        if (M == 0)
        {
            Console.WriteLine($"Наибольший общий делитель равен {M}");
            return;
        } 
        FindGreatestCommonDivisor(M, N);
}

