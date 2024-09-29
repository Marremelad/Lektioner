using System.Runtime.InteropServices.Marshalling;
using System.Text.Json.Serialization;

namespace Lektioner;

class Program
{
    static void Main(string[] args)
    {
        string[] values = { "12,3", "45", "ABC", "11", "DEF" };

        
        decimal sum = 0;
        string letters = "";

        foreach (string value in values)
        {
            if (decimal.TryParse(value, out decimal result))
            {
                sum += result;
            }
            else letters += value;
        }
        Console.WriteLine(sum);
        Console.WriteLine(letters);
    }
}