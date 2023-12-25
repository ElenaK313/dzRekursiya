// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
System.Console.WriteLine("Введите неотрицательное число n: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите неотрицательное число m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Akkerman(int n, int m) 
{
    if(n == 0)
    {
        return m+1;
    }
    else
    {
        if((n != 0) && (m == 0))
        {
            return Akkerman(n-1,1);
        }
        else
        {
            return Akkerman(n-1, Akkerman(n,m-1));
        }
    }
}
Console.WriteLine(Akkerman(N,M));