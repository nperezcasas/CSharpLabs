using System;
namespace COMS201_LAB_03
{
    public class LibraryBook : Book
    {
        public String CatalogNumber { get; set; }

        public bool Available { get; set; }

        public LibraryPatron Holder { get; set; }

        public void CheckOut (LibraryPatron holder)
        {
            Holder = holder;
            Available = false;
            Console.WriteLine(holder + " has checked out the book.");
        }

        public void CheckIn()
        {
            Holder = null;
            Available = true;
            Console.WriteLine(Title + " has been checked in.");
        }
    }
}
