using System;

namespace ABSTRACT_CLASSES
{
    class Dog : Animal
    {
        // We'll set the default Name for a dog object in its constructor method.
        public Dog()
        {
            Name = "dog";
        }

        // The Dog class is overriding its base Animal class's Move method with its own version.
        public override void Move(GlobalValues.Direction direction, int distance)
        {
            Console.WriteLine($"The { Name } ran a distance of { distance } in a { direction } direction.");
            GlobalValues.WaitForUser();
        }

        // Since Animal.Speak() is an abstract method, all classes that extend Animal must include their own Speak method.
        public override void Speak()
        {
            Console.WriteLine($"The { Name } goes, \"Woof!\".");
            GlobalValues.WaitForUser();
        }
    }
}
