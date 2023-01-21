// таблица кубов от 1 до N
int num = new Random().Next(1, 12);

System.Console.WriteLine($"num = {num}");

for(int i = 1; i <= num; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}

