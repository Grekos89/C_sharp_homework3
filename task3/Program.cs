// является ли число полиндромом
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int revers = 0;
int num3 = num;

while( num3 > 0 )
{
    num2 = num3 % 10;
    revers = revers * 10 + num2;
    num3 = num3 / 10;
}
if( num == revers)
{
    Console.WriteLine("полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}
