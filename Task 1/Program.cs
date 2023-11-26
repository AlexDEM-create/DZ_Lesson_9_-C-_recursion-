/* 
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNaturalNum(int M, int N)
{
    if (N < M+1)
    {
        return;
    }
   
    PrintNaturalNum(M,N-1);
    if ((N-1)%2==0)
    {
       System.Console.Write($"{N-1}\t");
    }
    else
    {
       System.Console.Write(" ");

    }
}
int M = ReadInt("Введите число M");
int N = ReadInt("Введите число N");
PrintNaturalNum(M,N);