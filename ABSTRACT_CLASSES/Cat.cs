using System;

namespace ABSTRACT_CLASSES
{
    class Cat : Animal
    {
        // We'll set the default Name for a cat object in its constructor method.
        public Cat()
        {
            Name = "cat";
        }

        // Notice that the Cat class does not implement its own version of the Move method.
        // So it will inherit the Animal class's Move method.

        // Like all classes that inherit Animal, the Cat class must implement the Speak method.
        public override void Speak()
        {
            Console.WriteLine($"The { Name } goes, \"Meow!\".");
            GlobalValues.WaitForUser();
        }
    }
}
