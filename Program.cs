namespace Lektioner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<object> listOfObjects =
            [
                new Person("Mauricio", 26),
                new Person("Bosse", 100),
                new Person("Leo", 26),
                new Person("Billy", 21),
                new Animal("Leopard", "Mike", 7),
                new Dog("Doggy", 10),
                new Dog("Buster", 10),
                new Cat("Whiskers", 2),
                // new Car("Honda", "Civic", 1999), // Makes IsComparable return false.
            ];
            
            if (IsComparable(listOfObjects)) CompareAge(listOfObjects);
            else Console.WriteLine("One or more objects in the list are not comparable.");
            
        }
        
        public interface IComparable
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        
        public class Person : IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void Speak()
            {
                Console.WriteLine("Hello!");
            }
        } 
        
        public class Animal : IComparable
        {
            public string Species { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string species, string name, int age)
            {
                Species = species;
                Name = name;
                Age = age;
            }

            public virtual void Speak()
            {
                Console.WriteLine("The Animal makes a sound!");
            }
        }
        
        public class Dog : Animal
        {
            public Dog(string name, int age) : base("Dog", name, age)
            {
                Name = name;
                Age = age;
            }
            
            public override void Speak()
            {
                Console.WriteLine("Woff!");
            }
        }

        public class Cat : Animal
        { 
            public Cat(string name, int age) : base("Cat", name, age)
            {
                Name = name;
                Age = age;
            }

            public override void Speak()
            {
                Console.WriteLine("Meow!");
            }
        }

        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public void DisplayCar()
            {
                Console.WriteLine($"Make: {Make}\nModel: {Model}\nManufactured in {Year}");
            }
            
            public void Drive()
            {
                Console.WriteLine("Skrt Skrt!!!");
            }
        }
        
        public static bool IsComparable(List<object> list)
        {
            foreach (var item in list)
            {
                if (item is not IComparable)
                {
                    return false;
                }
            }
            return true;
        }
        
        static void CompareAge(List<object> comparables)
        {
            for (int i = 0; i < comparables.Count; i++)
            {
                for (int j = 0; j < comparables.Count; j++)
                {
                    if (i == j) continue;

                    if (comparables[i] is Animal animal && comparables[j] is Animal otherAnimal)
                    {
                        Console.WriteLine(animal.Age == otherAnimal.Age? $"{animal.Name} the {animal.Species} and {otherAnimal.Name} the {otherAnimal.Species} are the same age." :
                            animal.Age < otherAnimal.Age ? $"{animal.Name} the {animal.Species} is younger than {otherAnimal.Name} the {otherAnimal.Species}." :
                            $"{animal.Name} the {animal.Species} is older than {otherAnimal.Name} the {otherAnimal.Species}."); 
                    }
                    else if (comparables[i] is Person person && comparables[j] is Person otherPerson)
                    {
                        Console.WriteLine(person.Age == otherPerson.Age ? $"{person.Name} and {otherPerson.Name} are the same age." :
                            person.Age < otherPerson.Age ? $"{person.Name} is younger than {otherPerson.Name}." :
                            $"{person.Name} is older than {otherPerson.Name}."); 
                    }
                    else
                    {
                        Console.WriteLine($"Object of type {comparables[i].GetType().Name} can not be compared to object of type {comparables[j].GetType().Name}.");
                    }
                }    
            }
        }
    }
}
