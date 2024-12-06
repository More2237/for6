decimal a = decimal.Parse(Console.ReadLine());
decimal b;
for (decimal i = 1.2m; i<=2.0m; i += 0.2m )
{
    b = i * a;
    Console.WriteLine(b);
}