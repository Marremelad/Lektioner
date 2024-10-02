namespace Lektioner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IComparable> comparables =
            [
                new Person("Mauricio", 26),
                new Person("Per", 10),
                new Person("Leo", 26),
                new Person("Bosse", 100),
                new Dog("Doggy", 10),
                new Cat("Kitty", 5),

            ];
            CompareAge(comparables);
        }
        
        public interface IComparable
        {
            public int Age { get; set; }
            public string Name { get; set; }

            void Speak();
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
        static void CompareAge(List<IComparable> comparables)
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

                    if (comparables[i] is Person person && comparables[j] is Person otherPerson)
                    {
                        Console.WriteLine(person.Age == otherPerson.Age ? $"{person.Name} and {otherPerson.Name} are the same age." :
                            person.Age < otherPerson.Age ? $"{person.Name} is younger than {otherPerson.Name}." :
                            $"{person.Name} is older than {otherPerson.Name}."); 
                    }
                    else if (comparables[i] is not Person || comparables[j] is not Person)
                    {
                        Console.WriteLine($"Object of type {comparables[i].GetType().Name} can not be compared to object of type {comparables[j].GetType().Name}.");
                    }
                }    
            }
        }
    }
}
