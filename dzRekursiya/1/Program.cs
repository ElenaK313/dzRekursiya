// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void PrintNumbers(int firstNum, int secondNum) 
{
    System.Console.Write(firstNum + ", ");
    if(firstNum == secondNum)
    {
        return;
    }
    PrintNumbers(firstNum+1, secondNum);  
}

PrintNumbers(M,N);