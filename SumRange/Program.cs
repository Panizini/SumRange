while(true)
{
    Console.WriteLine("first number;");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("second number;");

    int b = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = a; i <= b; i++) 
    {
        sum = sum + i;
    }
    Console.WriteLine( "your number is"  + sum);
}