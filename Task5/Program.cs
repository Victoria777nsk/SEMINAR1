Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = number % 10;

if ((number >= 100) && (number < 1000))
{
    Console.WriteLine("Последняя цифра: " + lastNumber);
}
else
{
    Console.WriteLine("ERROR");
}
