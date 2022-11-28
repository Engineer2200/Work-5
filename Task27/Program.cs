Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int s =0;
while (number>0)
{
s=s+ (number % 10);
number=number/10;
}
Console.WriteLine(s);