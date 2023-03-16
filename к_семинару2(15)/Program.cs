// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear(); 
int[] DayArrye={1,2,3,4,5,6,7};
int langht=DayArrye.Length;
// int index=0;
Console.WriteLine("введите цифру дня недели");
int index = int.Parse (Console.ReadLine());
while (index==0||index<6)
{
  Console.WriteLine("Будни");  
  break;

}
   if (index>5)
{
     Console.WriteLine("выходные");
}