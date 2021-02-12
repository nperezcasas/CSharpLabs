using System;
namespace COMS201_LAB_1
{
    public class Book
    {
        private readonly string _isbn;
        private string _title;
        public Author Author {get;set;}
        public string Title
        {
            get { return _title; }
        }
        public string Isbn
        {
            get { return _isbn; }
        }
        public void AskUserForTitle()
        {
            Console.Write ($"What is the title of the book with ISBN {Isbn} ?");
            _title = Console.ReadLine();
        }
        public Book(string BookNumber)
        {
            _isbn = BookNumber;
        }
        public Book(string BookNumber, string BookTitle)
        {
            _isbn = BookNumber;
            _title = BookTitle;
        }
    }
}
