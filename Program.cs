using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Lektioner;

using System;

class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

    }    
    
}


