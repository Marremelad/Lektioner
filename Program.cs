using System.IO.Compression;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Lektioner;

using System;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting asynchronous task");
        await DoWorkAsync();
        Console.WriteLine("Asynchronous task done");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Working asynchronously...");
        await Task.Delay(2000);
        Console.WriteLine("Done");
    }
}


