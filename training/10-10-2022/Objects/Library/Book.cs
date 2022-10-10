using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        //Class atributes
        public string title;
        public string author;
        public int pages;

        //Method for Constructor
        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
