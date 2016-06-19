using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Book:Item
    {
        public Guid ID { get; set; }
        public string Isbn { get; set; }
        public string AuthorName { get; set; }

        public Dictionary<string, string> ItemFields { get; private set; }
        public Dictionary<string, string> AuthorFields { get; private set; }
        public Dictionary<string, string> BookFields { get; private set; }

        public Book() { }
        
        public Book(string name, string publisher, DateTime publishedDate, 
            string isbn, string authorName): this (Guid.Empty, name,publisher,publishedDate,isbn,authorName)
        {

        }
        public Book(Guid id, string name, string publisher, DateTime publishedDate,
            string isbn, string authorName)
        {
            ID = id;
            Name = name;
            Publisher = publisher;
            PublicationDate = publishedDate;
            Isbn = isbn;
            AuthorName = authorName;

            ItemFields = new Dictionary<string, string>(3);
            ItemFields.Add("Name",Name);
            ItemFields.Add("Publisher", Publisher);
            ItemFields.Add("PublicationDate", PublicationDate.ToString());

            AuthorFields = new Dictionary<string, string>(1);
            AuthorFields.Add("Name", AuthorName);

            BookFields = new Dictionary<string, string>(1);
            BookFields.Add("ISBN", Isbn);
            
        }

    }
}
