namespace Lektioner;

class Program
{
    public class Person
    {
        private string _name;
        private int _age; 
        
        // Public constructor
        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be positive");
                }
            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old");
        }
    }
    
    public class ConstructionWorker : Person
    {
        private string _specialty;
        private int _experienceYears;

        // Constructor for ConstructionWorker
        public ConstructionWorker(string name, int age, string specialty, int experienceYears)
            : base(name, age) // Call the base constructor
        {
            this._specialty = specialty;
            this._experienceYears = experienceYears;
        }

        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }

        public int ExperienceYears
        {
            get { return _experienceYears; }
            set
            {
                if (value >= 0)
                {
                    _experienceYears = value;
                }
                else
                {
                    throw new ArgumentException("Experience years cannot be negative");
                }
            }
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working as a {_specialty} with {_experienceYears} years of experience.");
        }
    }
    static void Main(string[] args)
    {
        Person person = new Person("Mauricio", 26);
        
        Console.WriteLine(person.Name);

    }

}