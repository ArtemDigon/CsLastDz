// Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintFromTo(int N)
{
    if (N > 0) {
        if (N == 1)
            Console.Write(N);
        else {
            Console.Write(N + ", ");
            PrintFromTo(N - 1);
        }
    }
}
Console.WriteLine("Введите натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write ("N = "+ N + " -> ");
PrintFromTo(10);
