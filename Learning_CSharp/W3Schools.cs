namespace Learning_CSharp
{
    // *** Inheritance ***
    class Vehicle  // Base class
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // Derived class
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Person
    {
        public string Name { get; set; } // This is a short hand referred to as 'Automatic Properties'
    }

    // *** Polymorphism *** 
    // Need to use the key word 'override' for the derived methods to work
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    // *** Interface ***
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Cat : IAnimal
    {
        public void animalSound()
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
        public void exceptionTest()
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

        public void forcedError(int age)
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