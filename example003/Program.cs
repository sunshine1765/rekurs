// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9 
// m = 3, n = 2 -> A(m,n) = 29 
 
int InputNum(string message) 
{ 
    System.Console.WriteLine(message); 
    return int.Parse(Console.ReadLine()!); 
} 
 
int  ack(int n, int m){  
   if(n == 0){ 
    return m + 1; 
   } 
     
   else if(m == 0) 
   { 
     return ack (n - 1, 1); 
   } 
   else 
   {  
     return ack(n - 1, ack (n, m - 1)); 
   } 
}   
 
Console.Clear(); 
int m = InputNum("Введите число M: "); 
int n = InputNum("Введите число N: "); 
 
int res = ack(m, n); 
 
System.Console.WriteLine(res);