using System;

namespace Learning_CSharp
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();

            // Using the Car Class below
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            // *** Inheritance ***
            Ford.honk();


            // Using the Person Class below
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            // *** Polymorphism ***
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            // *** Interface ***
            Cat myCat = new Cat();  // Create a Cat object
            myCat.animalSound();

            // *** enum ***
            Level myEnum = Level.Medium;
            int myEnumNum = (int)Level.Medium;
            Console.WriteLine(myEnum);
            Console.WriteLine(myEnumNum);

            // *** Exceptions ***
            ExceptionExample testError = new ExceptionExample();
            testError.exceptionTest();
            testError.forcedError(15);
        }
    }
}
