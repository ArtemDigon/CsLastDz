// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromTo(int M, int N)
{
    if (M <= N)
    {
        return M + SumFromTo(M+1,N);
    }
    else
    {
        return 0;
    }
}

Console.Write("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());
int sumFromTo = SumFromTo(M,N);
Console.Write("M = "+M+"; "+"N = "+N+" -> "+ sumFromTo);
