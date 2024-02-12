// See https://aka.ms/new-console-template for more information
int Num, M;
Console.WriteLine("Write a number");
Num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    M = Num * i;
    Console.WriteLine(Num + "X" + i + "=" + M);
}
Console.ReadKey();
