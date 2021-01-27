using System;

namespace ABSTRACT_CLASSES
{
    // Duck extends Bird which itself extends Animal.
    // But the Duck class has the "sealed" modifier.
    // So nothing can extend the Duck class.

    sealed class Duck : Bird
    {
        public Duck()
        {
            Name = "duck";
        }

        public override void Speak()
        {
            Console.WriteLine($"The { Name } goes, \"Quack!\".");
            GlobalValues.WaitForUser();
        }
    }
}
