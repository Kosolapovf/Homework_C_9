/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* void ShowNumbers(int numN)
{
    Console.Write($"{numN} ");
    if (numN > 1 ) ShowNumbers(numN -1);
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number); */


/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
/* int ShowNumber(int numM, int numN)
{
    if (Math.Min(numM, numN) != Math.Max(numM, numN)) return ShowNumber(Math.Min(numM, numN) + 1, Math.Max(numM, numN)) + Math.Min(numM, numN);
    else return Math.Min(numM, numN);
}

int res = ShowNumber(1, 15);
Console.Write(res); */



/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/* int FunctionAckermann(int m, int n)
{

    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    else return 0;
}
int res = FunctionAckermann(3, 0);
Console.Write(res); */
