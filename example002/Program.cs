// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30 
 
int InputNum(string message) 
{ 
    System.Console.WriteLine(message); 
    return int.Parse(Console.ReadLine()!); 
} 
 
int SumRange(int m, int n) 
{ 
   if(m == n) 
   { 
    return n; 
   } 
   return SumRange(m + 1, n) + m; 
} 
 
int m = InputNum("Введите число M: "); 
int n = InputNum("Введите число N: "); 
 
int res = SumRange(m, n); 
System.Console.WriteLine(res);