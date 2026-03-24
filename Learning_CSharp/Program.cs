using System;
using static Learning_CSharp.FizzBuzz;

namespace Learning_CSharp
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void RunFizzBuzz()
        {
            List<IFizzBuzzRule> activeRules = [new FizzRule(), new BuzzRule()];
            FizzBuzzRunner engine = new(activeRules);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(engine.GetOutput(i));
            }
        }

        static void Main(string[] args)
        {
            RunFizzBuzz();
            /*
            MyMethod();

            // Using the Car Class below
            Car Ford = new("Mustang", "Red", 1969);
            Console.WriteLine(Ford.Color + " " + Ford.Year + " " + Ford.Model);
            // *** Inheritance ***
            Ford.Honk();


            // Using the Person Class below
            Person myObj = new();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            // *** Polymorphism ***
            Animal myAnimal = new();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();

            // *** Interface ***
            Cat myCat = new();  // Create a Cat object
            myCat.AnimalSound();

            // *** enum ***
            Level myEnum = Level.Medium;  // gets the enum label
            int myEnumNum = (int)Level.Medium; // gets enum index
            Console.WriteLine(myEnum);
            Console.WriteLine(myEnumNum);

            // Practice code
            House parentsHouse = new(4, 2, "1 How Where");
            Console.WriteLine(parentsHouse.description());

            // *** Exceptions ***
            ExceptionExample testError = new();
            testError.ExceptionTest();
            //testError.ForcedError(15);
            */
        }
    }
}
