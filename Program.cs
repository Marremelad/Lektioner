using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json.Serialization;

namespace Lektioner;

class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("KEK", "W", 1999);
        Vehicle kek = new Vehicle("hej", "dig", 2001, "bs");
        
        vehicle.Display();
        kek.Display();
    }
    
}