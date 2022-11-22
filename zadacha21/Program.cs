Console.Write("Введите X1 ");
var X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1 ");
var Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1 ");
var Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X2 ");
var X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2 ");
var Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2 ");
var Z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2) + Math.Pow((Z1-Z2),2));

Console.WriteLine("Растояние между точками" + " " + result);