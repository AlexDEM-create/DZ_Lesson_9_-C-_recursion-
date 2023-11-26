/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Sum = 0;

int GetSum (int M, int N)
{
    Sum+=M;
    if (M==N)
    {
        return Sum;
    }
    return  GetSum (M+1,N);
}

int M = ReadInt ("Введите число М");
int N= ReadInt ("Введите число N");
System.Console.WriteLine(GetSum(M,N));

