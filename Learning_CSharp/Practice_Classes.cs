namespace Learning_CSharp
{
    // *** Inheritance ***
    class Vehicle  // Base class
    {
        private string _shape = "SUV";  // This is field because it is private
        
        public string Brand = "Ford";  // Vehicle Property
        public void Honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
        public void SetShape(string shape)
        {
            _shape = shape;
        }
    }

    class Car : Vehicle  // Derived class
    {
        public string Model;
        public string Color;
        public int Year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            Model = modelName;
            Color = modelColor;
            Year = modelYear;
        }
    }

    class Person
    {
        public string Name { get; set; } // This is a short hand referred to as 'Automatic Properties'
    }

    // example of where a parent has a constructor
    public class Parent
    {
        public string Name { get; }

        // Parent constructor
        public Parent(string name)
        {
            Name = name;
        }
    }

    public class Child : Parent
    {
        public int Age { get; }

        // Child constructor passing 'name' to Parent via ': base(name)'
        public Child(string name, int age) : base(name)
        {
            Age = age;
        }
    }

    // *** Polymorphism *** 
    // Need to use the key word 'override' for the derived methods to work
    class Animal  // Base class (parent) 
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    // *** Interface ***
    interface IAnimal
    {
        void AnimalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Cat : IAnimal
    {
        public void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The cat says: mew mew");
        }
    }

    // *** enum ***
    enum Level
    {
        Low,
        Medium,
        High
    }

    // *** Exceptions ***
    class ExceptionExample
    {
        public void ExceptionTest()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                // Can write your own message
                //Console.WriteLine(e.Message || "Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }

        public void ForcedError(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

    }
}