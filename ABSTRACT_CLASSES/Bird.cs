using System;

namespace ABSTRACT_CLASSES
{
    // The Bird class implements the Animal class the same way the Cat class does.
    // So no detailed explanation is necessary here.
    class Bird : Animal
    {
        public Bird()
        {
            Name = "bird";
        }

        public override void Speak()
        {
            Console.WriteLine($"The { Name } goes, \"Tweet!\".");
            GlobalValues.WaitForUser();
        }
    }
}
