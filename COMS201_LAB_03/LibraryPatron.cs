using System;
namespace COMS201_LAB_03
{
    public class LibraryPatron : Person
    {
        public readonly string CardNumber;

        public readonly DateTime MemberSince;

        public LibraryPatron(string name, string cardNumber, DateTime memberSince)
        {
            Name = name;
            CardNumber = cardNumber;
            MemberSince = memberSince;
        }
    }
}
