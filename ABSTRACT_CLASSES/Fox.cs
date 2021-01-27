using System;

namespace ABSTRACT_CLASSES
{
    // The Fox class implements the Animal class the same way the Cat class does.
    // So no detailed explanation is necessary here.
    sealed class Fox : Animal
    {
        public Fox()
        {
            Name = "fox";
        }

        public override void Speak()
        {
            Console.WriteLine($"What does the { Name } say?");
            GlobalValues.WaitForUser();
            Console.WriteLine($"Hatee-hatee-hatee-ho!\nHatee-hatee-hatee-ho!\nHatee-hatee-hatee-ho!\n");
            GlobalValues.WaitForUser();
        }
    }
}
