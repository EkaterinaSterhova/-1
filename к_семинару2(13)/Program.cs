// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear(); 
Console.WriteLine("Введите трехзначное число: ");
int nov = Convert.ToInt32(Console.ReadLine());

if(nov>=100||nov<1000)
{
      Console.Write(nov%100);
      
}
if(nov<100)

 Console.WriteLine("  нет третьей цифры");