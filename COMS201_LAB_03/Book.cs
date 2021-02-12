using System;
namespace COMS201_LAB_03
{
    public abstract class Book
    {
        public enum Topic
        {
            Biology,
            Chemistry,
            ComputerScience,
            History,
            Mathematics
        }

        public readonly Guid Id = Guid.NewGuid();

        public string Title { get; set; }

        public Author Author { get; set; }

        public Topic Subject { get; set; }

    }
}
