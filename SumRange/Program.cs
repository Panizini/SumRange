using System.Diagnostics.CodeAnalysis;
{
    Console.WriteLine("first number;");
    int a = 5; int.Parse(Console.ReadLine());

    Console.WriteLine("second number;");

    int b = 9; int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = a; i <= b; i++) 
    {
        sum = sum + i;
    }
    Console.WriteLine(sum);

    Console.WriteLine("paniz");
}