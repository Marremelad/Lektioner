// Parent class
public class Animal
{
    public string AnimalName { get; set; }
    public int NumberOfLegs { get; set; }
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Interface
public interface IWalkable
{
    void Walk();
}

// Derived class that inherits from Animal and implements IWalkable
public class Dog : Animal, IWalkable
{
    public bool LikesToPlay = true;
    public Dog(string animalName, int numberOfLegs)
    {
        AnimalName = animalName;
        NumberOfLegs = numberOfLegs;
    }

    
    // Implement the interface method
    public override void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }
    
    public void Walk()
    {
        Console.WriteLine("Dog walks.");
    }
}

public class Cat: Animal, IWalkable
{
    public bool LikesToPlay = false;
    public Cat()
    {
        AnimalName = "Cat";
    }
    // Implement the interface method
    public override void Eat()
    {
        Console.WriteLine("Cat is eating.");
    }
    
    public void Walk()
    {
        Console.WriteLine("Cat walks.");
    }
}

public class Program
{
    public static void Main()
    {
        Dog myDog = new("Dog1", 4);
        Cat myCat = new();
        
        List<Animal> animalList = new();
        animalList.Add(myDog);
        animalList.Add(myCat);

        foreach (Animal animal in animalList)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.LikesToPlay);
            }
            else Console.WriteLine(animal.AnimalName);
        }
    }
}