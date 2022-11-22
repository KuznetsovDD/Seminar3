Console.Write("Введите пятизначное число: ");
try
{
    var num = Convert.ToInt32(Console.ReadLine());

    if(num>99999 || num < 10000)
    {
        Console.WriteLine("Не пятизначное число");
    }
    else
    {
        var first = num/1000;
        var second = num%100;
        second = second%10*10 + second/10;

        if (first == second )
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
        }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}