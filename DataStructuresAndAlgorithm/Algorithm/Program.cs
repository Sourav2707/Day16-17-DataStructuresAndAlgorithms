using Algorithm;

Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Prime numbers between range 0-1000 are -");
for (int x = 2; x <= 1000; x++)
{
    if (Algo.prime(x) == true && Algo.palindrome(x) == true)
    {
        Console.WriteLine(x);
    }
}