// Задача 19 Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input 5-digit number: ");
string number = Console.ReadLine();

if (number[0]==number[4] || number[1]==number[3])
{
    Console.WriteLine($"The number {number} is a palindrome");
}
    else Console.WriteLine($"The number {number} is not a palindrome");


//Задача 21 Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distanse(double x, double y, double x1, double y1, double z, double z1)
{
  return Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1-y), 2) + Math.Pow((z1-z), 2));
}
Console.Write("input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("input z-coordinate: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("input x1-coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y1-coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input z1-coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistance = Math.Round(Distanse(x, y, x1, y1, z, z1), 2);
Console.WriteLine($"The distanse in 3D is {findDistance}");

//Задача 23 Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.


void ShowCubeNumber(int num)
{
    int count = 1;
    while(count <= num)
    {
      double n = Math.Pow(count, 3);
      Console.Write(n + " ");
      count++;
    }
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCubeNumber(number);