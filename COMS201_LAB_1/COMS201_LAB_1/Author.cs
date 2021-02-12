using System;
namespace COMS201_LAB_1
{
    public class Author
    {
        public string Name { get; set; }
        public string YearBorn { get; set; }
        public void AskUserForAuthorsBirthYear()
        {
            Console.Write("What is the author's birth year?");
            YearBorn = Console.ReadLine();
        }
        public Author(string _name)
        {
            Name = _name;
            AskUserForAuthorsBirthYear();
        }
        public Author(string _name, string _yearBorn)
        {
            Name = _name;
            YearBorn = _yearBorn;
        }
    }
}
