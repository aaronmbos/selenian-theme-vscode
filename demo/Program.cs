using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        foreach (var i in Fibonacci().Take(20))
        {
            Console.WriteLine(i);
        }
    }

    private static IEnumerable<int> Fibonacci()
    {
        int current = 1, next = 1;
        while (true)
        {
            yield return current;
            next = current + (current = next);
        }
    }
}
