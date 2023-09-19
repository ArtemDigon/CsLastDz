// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

int A (int m,int n)
{
    while(m != 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = A(m,n - 1);
        }
        m--;
    }
    return n + 1;
}
Console.Write("Введите натуральное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n:");
int n = Convert.ToInt32(Console.ReadLine());
int a = A(m,n);
Console.WriteLine("m = "+m+", n = "+n+" -> A(m,n) = "+ a);
