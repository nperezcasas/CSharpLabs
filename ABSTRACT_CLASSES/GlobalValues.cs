using System;

namespace ABSTRACT_CLASSES
{
    static class GlobalValues
    {
        // This demonstrates static classes as well
        // as introduces the enumeration data type.
        // An enumeration is a set of named constants.
        // Each named constant has an integer value
        // starting with the first item in the list
        // which is 0.
        public enum Direction
        {
            North,
            Northeast,
            East,
            Southeast,
            South,
            Southwest,
            West,
            Northwest
        }

        public static void WaitForUser()
        {
            Console.WriteLine("\nPress any key...\n");
            Console.ReadKey();
        }
    }
}
