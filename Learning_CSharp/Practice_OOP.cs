using System;

namespace Learning_CSharp
{
    internal class Practice_OOP
    {
        public class BaseComponent
        {
            // 1. Visible everywhere
            public string PublicInfo = "Everyone can see me.";

            // 2. Visible only inside BaseComponent (Field)
            private string _secretId = "12345";

            // 3. Visible to BaseComponent and any class that inherits from it
            protected string ProtectedInfo = "Only family (subclasses) can see me.";

            // 4. Visible to anything inside the MyApp.Core assembly
            internal string InternalInfo = "Only colleagues in this project can see me.";

            // 5. Visible in this assembly OR to any subclass in another assembly
            protected internal string SharedInfo = "Colleagues OR distant family can see me.";

            // 6. Visible to subclasses, but ONLY if they are in this same assembly
            private protected string LocalFamilyInfo = "Only local family can see me.";

            public void ShowPrivate() => Console.WriteLine(_secretId);
        }

        public class LocalDerived : BaseComponent
        {
            public void AccessTest()
            {
                Console.WriteLine(PublicInfo);        // Works
                Console.WriteLine(ProtectedInfo);     // Works (Inherited)
                Console.WriteLine(InternalInfo);      // Works (Same Assembly)
                Console.WriteLine(SharedInfo);        // Works (Same Assembly)
                Console.WriteLine(LocalFamilyInfo);   // Works (Same Assembly + Subclass)

                // Console.WriteLine(_secretId);      // ERROR: Private
            }
        }

        // 1. Abstract: Cannot be instantiated, must be inherited
        public abstract class GameEntity
        {
            // 2. Readonly: Set once, then locked
            private readonly DateTime _createdAt = DateTime.Now;

            // 3. Static: Shared across all instances of GameEntity
            public static int EntityCount = 0;

            protected GameEntity() => EntityCount++;

            // 4. Abstract Method: No body, children MUST implement this
            public abstract void Update();

            // 5. Virtual: Has a body, but children CAN change it
            public virtual void OnDestroy() => Console.WriteLine("Cleaning up...");
        }

        // 6. Sealed: No one can inherit from Player
        public sealed class Player : GameEntity
        {
            // 7. Override: Providing the required implementation
            public override void Update() => Console.WriteLine("Player moving...");

            // 8. Override: Changing the default virtual behavior
            public override void OnDestroy()
            {
                base.OnDestroy(); // Call parent logic
                Console.WriteLine("Saving player progress!");
            }
        }
    }
}
