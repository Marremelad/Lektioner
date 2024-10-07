using System.Diagnostics;

namespace Lektioner;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> myNumbers = [1, 2, 3];
        List<string> myStrings = ["Mauricio", "Tobias", "Leo"];
        List<object> myObjects = ["Jake", 1, 2, 3];

        Stopwatch sw = new Stopwatch();
        sw.Start();

        for (int i = 0; i < 1000000; i++)
        {
            myObjects.Add(i);
        }
        sw.Stop();
        Console.WriteLine($"List of objects took: {sw.ElapsedMilliseconds} milliseconds.");

        sw = new Stopwatch();
        sw.Start();
        
        for (int i = 0; i < 1000000; i++)
        {
            myNumbers.Add(i);
        }
        sw.Stop();
        Console.WriteLine($"List of numbers took: {sw.ElapsedMilliseconds} milliseconds.");

        sw = new Stopwatch();
        sw.Start();
        
        for (int i = 0; i < 1000000; i++)
        {
            myStrings.Add($"{i}");
        }
        sw.Stop();
        Console.WriteLine($"List of strings took: {sw.ElapsedMilliseconds} milliseconds.");
        
        
        sw = new Stopwatch();
        sw.Start();
        
        for (int i = 0; i < 1000000; i++)
        {
            myObjects.Add($"{i}");
        }
        sw.Stop();
        Console.WriteLine($"List of strings in object list took: {sw.ElapsedMilliseconds} milliseconds.");
    }
}

