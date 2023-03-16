// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear(); 
Console.Write("Введите трехзначное число: ");
int choslo = Convert.ToInt32(Console.ReadLine());

if(choslo<100||choslo>=1000)
{  
 Console.WriteLine("Число не трехзначное!");
 }
else
Console.Write("Вторая цифра:" );
  Console.Write(choslo / 10 % 10);