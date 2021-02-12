using System;
namespace COMS201_LAB_03
{
    public class Textbook : Book
    {
        public double ListPrice { get; set; }


        public void Buy(Person person)
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine($"The cost of \"{ Title }\" is {ListPrice:$0.00}");
            Console.WriteLine("Would you like to buy it (Y/N): ");
            string decision = Console.ReadLine();
            Console.WriteLine();
       
            if (decision == "Y")
            {
                Console.WriteLine(person + " bought the book.");
            }
            else
            {
            }
        }

        public void Sell (double price)
        {
            ListPrice = 2 * price;
            Console.WriteLine($"The cost of \"{ Title }\" is {ListPrice:$0.00}");
        }
    }
}
