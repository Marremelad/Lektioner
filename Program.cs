namespace Lektioner;

public abstract class Program
{
    public static void Main(string[] args)
    {
        Storage<string> stringStorage = new();
        stringStorage.AddItem("Hello, World!");
        stringStorage.DisplayItems();
        
        Storage<int> intStorage = new();
        intStorage.AddItem(1);
        intStorage.DisplayItems();
    }

    private static void DisplayInput<T>(T input)
    {
        Console.WriteLine(input);
    }

    public class Storage<T>
    {
        private List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
            Console.WriteLine($"{item} was added to list.");
        }

        public void DisplayItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}