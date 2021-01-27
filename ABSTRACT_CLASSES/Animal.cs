using System;

namespace ABSTRACT_CLASSES
{
    // Animal is an abstract class. It cannot be instantiated itself.
    // It can only be used as a base class for other derived classes.
    abstract class Animal
    {
        // Derived classes will inherit the Animal class's Name and Color properties.
        public string Name { get; set; } 

        public string Color { get; set; }

        // Derived classes will inherit the Animal class's Move method.
        // Derived classes may also override the Animal class'e Move method.
        public virtual void Move(GlobalValues.Direction direction, int distance)
        {
            Console.WriteLine($"The { Color } { Name } has moved { direction } a distance of { distance }.");
            GlobalValues.WaitForUser();
        }

        // Derived classes must override the Animal class's Speak method becasue it is an abstract method.
        public abstract void Speak();
    }
}
