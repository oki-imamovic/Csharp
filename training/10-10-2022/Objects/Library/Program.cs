using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            //Basic Class and Implementation
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 432;

            Console.WriteLine(book1.author);

            */

            // Constructor
            Book book1 = new Book("Harry Potter", "JK Rowling", 458);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 784);
            book2.title = "The Hobbit";
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
            
        }
    }
}
